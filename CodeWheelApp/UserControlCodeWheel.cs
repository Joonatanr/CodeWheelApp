using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWheelApp
{
    public partial class UserControlCodeWheel : UserControl
    {        
        private List<SingleWheel> Wheels = new List<SingleWheel>();
        
        public UserControlCodeWheel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            //InnerWheel = new SingleWheel(500);
            //InnerWheel.requestRedraw = new SingleWheel.RequestRedrawHandler(this.Invalidate);
        }

        public void AddWheel(SingleWheel wheel)
        {
            wheel.requestRedraw = new SingleWheel.RequestRedrawHandler(this.Invalidate);
            Wheels.Add(wheel);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            foreach(SingleWheel sw in Wheels)
            {
                sw.Draw(e.Graphics, new PointF(this.Width / 2, this.Height / 2));
            }
        }
    }
}
