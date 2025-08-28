using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWheelApp
{
    public partial class UserControlCodeWheel : UserControl
    {
        private Bitmap myBitmap;
        
        public int DonutWidth = 60;
        
        public UserControlCodeWheel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            /* Set up the first bitmap. */
            myBitmap = new Bitmap(this.Width - 2, this.Height - 2);
            float radius = myBitmap.Width / 2;
            PointF center = new PointF(myBitmap.Width / 2, myBitmap.Height / 2);

            /* Lets just draw something to get started. */
            Graphics gfx = Graphics.FromImage(myBitmap);

            drawDonut(gfx, center, radius);
            drawMarkers(gfx, center, radius - (DonutWidth/ 2));

        }

        private void drawMarkers(Graphics gfx, PointF center, float radius)
        {
            Brush myBrush = new SolidBrush(Color.Black);

            for (float x = 0.0f; x <= 360.0f; x += 30.0f)
            {
                float myAngle = ((x * (float)Math.PI) / 180f);

                float xPos = center.X - (radius * (float)(Math.Cos(myAngle)));
                float yPos = center.Y - (radius * (float)(Math.Sin(myAngle)));

                PointF location = new PointF(xPos, yPos);

                drawSingleMarker(gfx, location, new SizeF(10.0f, 25.0f), myAngle);
            }
        }

        private void drawSingleMarker(Graphics gfx, PointF location, SizeF size, float angle)
        {
            gfx.FillEllipse(new SolidBrush(Color.Red), getRectangleAroundCenterPoint(location, size));
            //gfx.FillRectangle(new SolidBrush(Color.Red), getRectangleAroundCenterPoint(location, size));
        }


        private void drawDonut(Graphics gfx, PointF center, float radius)
        {

            gfx.SmoothingMode = SmoothingMode.AntiAlias;
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

            SolidBrush myBrush = new SolidBrush(Color.Blue);
            gfx.Clear(Color.Transparent);

            float innerRadius = radius - DonutWidth;
            float outerRadius = radius;

            gfx.FillRegion(myBrush, GetRingRegion(center, innerRadius, outerRadius));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            e.Graphics.DrawImage(myBitmap, 1, 1);
        }


        public static RectangleF getRectangleAroundCenterPoint(PointF center, SizeF size)
        {
            float xPos = center.X - size.Width / 2;
            float yPos = center.Y - size.Height / 2;

            return new RectangleF(xPos, yPos, size.Width, size.Height);
        }

        public static Region GetRingRegion(PointF center, float innerRadius, float outherRadius)
        {
            // You need a path for the outer and inner circles
            var path1 = new GraphicsPath();
            var path2 = new GraphicsPath();

            // Define the paths (where X, Y, and D are chosen externally)
            path1.AddEllipse(GetRectangle(center, outherRadius));
            path2.AddEllipse(GetRectangle(center, innerRadius));

            // Create a region from the Outer circle.
            Region region = new Region(path1);

            // Exclude the Inner circle from the region
            region.Exclude(path2);

            return region;
        }

        public static RectangleF GetRectangle(PointF center, float radius)
        {
            var rectangle = new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            return rectangle;
        }
    }
}
