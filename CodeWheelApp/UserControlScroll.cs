using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWheelApp
{
    public partial class UserControlScroll : UserControl
    {
        private Bitmap myBitmap;
        private Bitmap TopImage = null;
        private Bitmap MiddleImage = null;
        private Bitmap LowerImage = null;
        
        public UserControlScroll()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            drawBackground();

        }

        public void setGlyphImages(Bitmap upper, Bitmap middle, Bitmap lower)
        {
            TopImage  = new Bitmap(upper, new Size(upper.Width / 2, upper.Height / 2));
            MiddleImage = new Bitmap(middle, new Size(middle.Width / 2, middle.Height / 2));
            LowerImage = new Bitmap(lower, new Size(lower.Width / 2, lower.Height / 2));

            this.Invalidate();
        }

        private void drawBackground()
        {
            myBitmap = new Bitmap(this.Width, this.Height);
            Graphics gfx = Graphics.FromImage(myBitmap);

            Image original = Properties.Resources.scroll;
            Bitmap resized = new Bitmap(original, new Size(this.Width, this.Height));

            gfx.DrawImage(resized, 0, 0);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            paintScrollBackground(e.Graphics);
            paintGlyphs(e.Graphics);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            drawBackground();
        }

        private void paintGlyphs(Graphics g)
        {
            int yPos = 80;
            const int interval = 60;

            if (TopImage != null)
            {
                g.DrawImage(TopImage, (this.Width / 2) - (TopImage.Width / 2) , yPos);
            }

            yPos += interval;

            if (MiddleImage != null)
            {
                g.DrawImage(MiddleImage, (this.Width / 2) - (MiddleImage.Width / 2), yPos);
            }

            yPos += interval;

            if (LowerImage != null)
            {
                g.DrawImage(LowerImage, (this.Width / 2) - (LowerImage.Width / 2), yPos);
            }
        }

        private void paintScrollBackground(Graphics gfx)
        {
            gfx.DrawImage(myBitmap, 0, 0);
        }
    }
}
