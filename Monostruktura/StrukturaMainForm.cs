using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Numerics;
using System.Windows.Forms;
using Monostruktura.Paletter;
using Monostruktura.Parts;
using Monostruktura.PartsFactory;

namespace Monostruktura
{
    public partial class StrukturaMainForm : Form
    {
        private IPart Core;
        private Random Rand;

        public StrukturaMainForm()
        {
            InitializeComponent();
        }

        private void StrukturaMainForm_Load(object sender, EventArgs e)
        {
            Rand = new Random((int)((DateTime.Now - DateTime.MinValue).TotalMilliseconds % int.MaxValue));
        }

        private void StrukturaMainForm_Shown(object sender, EventArgs e)
        {
            bRegenerate_Click(sender, e);
        }

        private void RegenerateStructure()
        {
            IPaletteProvider palette = new MonoPaletteSlow(Rand, Color.Black);
            Core = new DepthPartFactory(6).Create(Rand, null, palette);
            Text = Core.Cost.ToString();
        }

        private void RedrawStructure()
        {
            Bitmap image = new Bitmap(960, 540);

            using (Graphics context = Graphics.FromImage(image))
            {
                context.PixelOffsetMode = PixelOffsetMode.None;
                context.SmoothingMode = SmoothingMode.AntiAlias;

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(242, 242, 246)))
                    context.FillRectangle(brush, 0, 0, image.Width, image.Height);

                Core.Draw(context, new Vector2(image.Width / 2, image.Height / 2), 0);
            }

            if (pMain.Image != null)
                pMain.Image.Dispose();

            pMain.Image = image;
        }

        private void bRegenerate_Click(object sender, EventArgs e)
        {
            RegenerateStructure();
            RedrawStructure();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.CheckFileExists = false;
                sfd.CheckPathExists = false;
                sfd.OverwritePrompt = true;
                sfd.Filter = "JPEG Image|*.jpeg|PNG Image|*.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat imageFormat;

                    switch(sfd.FilterIndex)
                    {
                        default:
                        case 1: imageFormat = ImageFormat.Jpeg; break;
                        case 2: imageFormat = ImageFormat.Png; break;
                    }

                    pMain.Image.Save(sfd.FileName, imageFormat);
                }
            }
        }
    }
}
