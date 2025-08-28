using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CodeWheelApp
{
    public partial class UserControlCodeWheel : UserControl
    {
        private Bitmap myBitmap;
        
        public UserControlCodeWheel()
        {
            InitializeComponent();

            /* Set up the first bitmap. */
            myBitmap = new Bitmap(this.Width - 2, this.Height - 2);

            /* Lets just draw something to get started. */
            Graphics gfx = Graphics.FromImage(myBitmap);

            gfx.FillEllipse(new SolidBrush(Color.Aquamarine), new Rectangle(0,0,myBitmap.Width,myBitmap.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(myBitmap, 1, 1);
        }
    }
}
