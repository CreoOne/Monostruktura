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
        private readonly Size FACEBOOK_POST = new Size(960, 540);
        private readonly Size FACEBOOK_PROFILE = new Size(160, 160);
        private readonly Size FACEBOOK_COVER = new Size(849, 313);

        private IPart Core;
        private Random Rand;
        private Size CanvasSize;

        public StrukturaMainForm()
        {
            InitializeComponent();
        }

        private void StrukturaMainForm_Load(object sender, EventArgs e)
        {
            Rand = new Random((int)((DateTime.Now - DateTime.MinValue).TotalMilliseconds % int.MaxValue));
            cPreset.SelectedIndex = 1;
        }

        private void StrukturaMainForm_Shown(object sender, EventArgs e)
        {
            bRegenerate_Click(sender, e);
        }

        private void RegenerateStructure()
        {
            IPaletteProvider palette = new MonoPaletteSlow(Rand, Color.Black);
            Core = new DepthPartFactory(6, Rand, palette).Create(null);
            Text = Core.Cost.ToString();
        }

        private void RedrawStructure()
        {
            Bitmap image = new Bitmap(CanvasSize.Width, CanvasSize.Height);

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
                sfd.FilterIndex = 2; // default

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

        private void bRedraw_Click(object sender, EventArgs e)
        {
            RedrawStructure();
        }

        private void cPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cPreset.SelectedIndex)
            {
                default:
                case 0: break;
                case 1: CanvasSize = FACEBOOK_POST; break;
                case 2: CanvasSize = FACEBOOK_PROFILE; break;
                case 3: CanvasSize = FACEBOOK_COVER; break;
            }

            nWidth.Value = CanvasSize.Width;
            nHeight.Value = CanvasSize.Height;
        }

        private bool SameSize(Size q, Size r)
        {
            return (q.Width - r.Width) == 0 && (q.Height - r.Height) == 0;
        }

        private void nWidth_nHeight_Leave(object sender, EventArgs e)
        {
            CanvasSize = new Size((int)nWidth.Value, (int)nHeight.Value);

            if (SameSize(FACEBOOK_POST, CanvasSize))
                cPreset.SelectedIndex = 1;

            else if (SameSize(FACEBOOK_PROFILE, CanvasSize))
                cPreset.SelectedIndex = 2;

            else if (SameSize(FACEBOOK_COVER, CanvasSize))
                cPreset.SelectedIndex = 3;

            else
                cPreset.SelectedIndex = 0;
        }
    }
}
