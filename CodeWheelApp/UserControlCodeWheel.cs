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

            drawSelector(e.Graphics);
        }

        private void drawSelector(Graphics g)
        {
            Pen myPen = new Pen(Color.Black, 4);

            float innerRadius = this.Width;
            float outerRadius = 0;

            foreach (SingleWheel wheel in Wheels)
            {
                if(wheel.InnerRadius < innerRadius)
                {
                    innerRadius = wheel.InnerRadius;
                }
                
                if(wheel.OuterRadius > outerRadius)
                {
                    outerRadius = wheel.OuterRadius;    
                }
            }

            PointF centerPoint = new PointF(this.Width / 2, this.Height / 2); ;


            PointF start = getPointOnCircularLine(270.0f + 15.0f, centerPoint, innerRadius);
            PointF end = getPointOnCircularLine(270.0f + 10.0f, centerPoint, outerRadius);
            g.DrawLine(myPen, start, end);

            start = getPointOnCircularLine(270.0f + 345.0f, centerPoint, innerRadius);
            end = getPointOnCircularLine(270.0f + 350.0f, centerPoint, outerRadius);
            g.DrawLine(myPen, start, end);
        }


        private static PointF getPointOnCircularLine(float angle, PointF centerPoint, float radius)
        {
            float myAngle = ((angle * (float)Math.PI) / 180f);

            float xPos = centerPoint.X - (radius * (float)(Math.Cos(myAngle)));
            float yPos = centerPoint.Y - (radius * (float)(Math.Sin(myAngle)));

            PointF location = new PointF(xPos, yPos);
            return location;
        }
    }
}
