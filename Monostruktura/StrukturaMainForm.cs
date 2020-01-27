using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Numerics;
using System.Windows.Forms;
using Monostruktura.Parts;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Monostruktura
{
    public partial class StrukturaMainForm : Form
    {
        private CancellationTokenSource RedrawCancellationTokenSource = new CancellationTokenSource();

        private IPart Core;
        private Random Rand;
        private Size CanvasSize;

        public StrukturaMainForm()
        {
            InitializeComponent();
            nWidth_nHeight_Leave(this, EventArgs.Empty);
            Rand = new Random(DateTime.UtcNow.Millisecond);
        }

        private void RedrawStructure()
        {
            Bitmap image = new Bitmap(CanvasSize.Width, CanvasSize.Height);
            image.SetResolution((int)nDpi.Value, (int)nDpi.Value);
            RedrawCancellationTokenSource.Cancel();
            RedrawCancellationTokenSource.Dispose();
            RedrawCancellationTokenSource = new CancellationTokenSource();
            CancellationToken redrawCancellationToken = RedrawCancellationTokenSource.Token;

            try
            {
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        using (Graphics context = Graphics.FromImage(image))
                        {
                            context.PixelOffsetMode = PixelOffsetMode.None;
                            context.SmoothingMode = SmoothingMode.AntiAlias;

                            ClearBackground(context);
                            Core.Draw(context, new Vector2(image.Width / 2, image.Height / 2), 0, redrawCancellationToken);
                            DrawVignette(image, context);
                        }
                    }

                    catch (ArgumentException) { }

                }, redrawCancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Current).ConfigureAwait(false);
            }

            catch (TaskCanceledException) { }

            if (!redrawCancellationToken.IsCancellationRequested)
                BeginInvoke((Action)delegate
                {
                    if (pMain.Image != null)
                        pMain.Image.Dispose();

                    pMain.Image = image;
                });
        }

        private static void ClearBackground(Graphics context)
        {
            context.Clear(Palette.Background);
        }

        private static void DrawVignette(Bitmap image, Graphics context)
        {
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddEllipse(-image.Width / 4f, -image.Height / 4f, image.Width * 1.5f, image.Height * 1.5f);

                using (PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath))
                {
                    pathGradientBrush.CenterPoint = new PointF(image.Width / 2, image.Height / 2);
                    pathGradientBrush.CenterColor = Color.FromArgb(0, Color.Black);
                    pathGradientBrush.SurroundColors = new Color[] { Palette.Vignette };
                    pathGradientBrush.FocusScales = new PointF(0.6f, 0.6f);

                    context.FillPath(pathGradientBrush, graphicsPath);
                }
            }
        }

        private void bRedraw_Click(object sender, EventArgs e)
        {
            RedrawStructure();
        }

        private bool SameSize(Size q, Size r)
        {
            return (q.Width - r.Width) == 0 && (q.Height - r.Height) == 0;
        }

        private void nWidth_nHeight_Leave(object sender, EventArgs e)
        {
            CanvasSize = new Size((int)nWidth.Value, (int)nHeight.Value);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.CheckFileExists = false;
                sfd.CheckPathExists = false;
                sfd.OverwritePrompt = true;
                sfd.Filter = "JPEG Image|*.jpeg|PNG Image|*.png";
                sfd.FilterIndex = 2; // default

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat imageFormat;

                    switch (sfd.FilterIndex)
                    {
                        default:
                        case 1: imageFormat = ImageFormat.Jpeg; break;
                        case 2: imageFormat = ImageFormat.Png; break;
                    }

                    pMain.Image.Save(sfd.FileName, imageFormat);
                }
            }
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            do { Core = buildRandomStructure(0, 8); }
            while (Math.Abs(Core.Cost) > 4e6);

            Text = string.Format("Cost: {0} Endpoints: {1}", Core.Cost.ToString("### ### ##0.000"), Core.Endpoints.ToString("### ### ##0"));

            RedrawStructure();
        }

        private IPart buildRandomStructure(int depth, int limit)
        {
            IPart result = null;

            switch (Rand.Next(0, 5))
            {
                default:
                case 0: result = new PointingLine(); break;
                case 1: result = new Circle(); break;
                case 2: result = new Rotor(); break;
                case 3: result = new Repeater(); break;
                case 4: result = new Parts.Splitter(); break;
            }

            result.Randomize(Rand);

            if (depth < limit)
                foreach (int index in Enumerable.Range(0, result.Childs.Count()))
                    result.SetChild(buildRandomStructure(depth + 1, limit), index);

            else if (depth == limit)
                foreach (int index in Enumerable.Range(0, result.Childs.Count()))
                {
                    PointingLine endline = new PointingLine();
                    endline.Randomize(Rand);
                    result.SetChild(endline, index);
                }

            return result;
        }
    }
}
