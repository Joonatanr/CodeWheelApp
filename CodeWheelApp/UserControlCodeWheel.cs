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
        private struct WheelEntry_T
        {
            public string Value;
            public float Angle;
            public Bitmap Image;
        }
        
        private Bitmap myBitmap;

        private Dictionary<string, Bitmap> myImageDictionary = new Dictionary<string, Bitmap>();
        private List<WheelEntry_T> myValues = new List<WheelEntry_T>();
        private int selectedIndex = 0;
        private float currentAngle = 90.0f;

        public Color WheelColor { get; set; } = Color.Blue;
        public float WheelWidth { get; set; } = 80;

        public Dictionary<string, Bitmap> ImageDictionary 
        { 
            get { return myImageDictionary; } 
            
            set
            {
                myImageDictionary = value;
                myValues = new List<WheelEntry_T>();
                int x = 0;
                float angle = 0.0f;
                float interval = 360.0f / myImageDictionary.Count;

                foreach (var kvp in myImageDictionary)
                {
                    WheelEntry_T obj = new WheelEntry_T();

                    obj.Value = kvp.Key;
                    obj.Image = kvp.Value;
                    obj.Angle = angle;

                    myValues.Add(obj);

                    x++;
                    angle+= interval;
                }

                if (myValues.Count > 0)
                {
                    selectedIndex = 0;
                    updateBitmap();
                    currentAngle = myValues[selectedIndex].Angle;
                    rotateWheel(currentAngle);
                }
            }    
        }
        
        public UserControlCodeWheel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            /* Set up the bitmap object. */
            myBitmap = new Bitmap(this.Width - 2, this.Height - 2);

            updateBitmap();
        }

        /* Currently placeholders . TODO */
        public string getCurrentSelectedValue()
        {
            try
            {
                return myValues[selectedIndex].Value;
            }
            catch (Exception)
            {
                return "NONE";
            }
        }

        public void Rotate(bool direction)
        {
            if (direction)
            {
                selectedIndex++;
                
                if (selectedIndex >= myValues.Count)
                {

                    selectedIndex = 0; 
                }
            }
            else
            {
                selectedIndex--;
                if (selectedIndex < 0)
                {
                    selectedIndex = myValues.Count - 1;
                }
            }

            rotateWheel(myValues[selectedIndex].Angle);
        }

        private void updateBitmap()
        {
            if (myBitmap != null)
            {
                float radius = myBitmap.Width / 2;
                PointF center = new PointF(myBitmap.Width / 2, myBitmap.Height / 2);

                /* Lets just draw something to get started. */
                Graphics gfx = Graphics.FromImage(myBitmap);

                drawDonut(gfx, center, radius);
                //drawMarkers(gfx, center, radius - (DonutWidth / 2));
                drawImages(gfx, center, radius - (WheelWidth / 2));
            }
        }

        private void rotateWheel(float angle)
        {
            currentAngle = angle;
            this.Invalidate();
        }

        private void drawImages(Graphics gfx, PointF center, float radius)
        {
            for (int x = 0; x < myValues.Count; x++)
            {
                float myAngle = ((myValues[x].Angle * (float)Math.PI) / 180f);

                float xPos = center.X - (radius * (float)(Math.Cos(myAngle)));
                float yPos = center.Y - (radius * (float)(Math.Sin(myAngle)));

                PointF location = new PointF(xPos, yPos);

                Bitmap original = myValues[x].Image;
                /* Scaling down to 50% is hardcoded now. Could do this more dynamically ofcourse... */
                Bitmap resized = new Bitmap(original, new Size(original.Width / 2, original.Height / 2));

                using (Matrix m = new Matrix())
                {
                    m.RotateAt(myValues[x].Angle + 90.0f, location);
                    gfx.Transform = m;
                    gfx.DrawImage(resized, getRectangleAroundCenterPoint(location, resized.Size));
                    gfx.ResetTransform();
                }
            }
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

                drawSingleMarker(gfx, location, new SizeF(10.0f, 10.0f), myAngle);
            }
        }

        private void drawSingleMarker(Graphics gfx, PointF location, SizeF size, float angle)
        {
            gfx.FillEllipse(new SolidBrush(Color.Purple), getRectangleAroundCenterPoint(location, size));
            //gfx.FillRectangle(new SolidBrush(Color.Red), getRectangleAroundCenterPoint(location, size));
        }


        private void drawDonut(Graphics gfx, PointF center, float radius)
        {

            gfx.SmoothingMode = SmoothingMode.AntiAlias;
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

            SolidBrush myBrush = new SolidBrush(WheelColor);
            //gfx.Clear(Color.Black);

            float innerRadius = radius - WheelWidth;
            float outerRadius = radius;

            gfx.FillRegion(myBrush, GetRingRegion(center, innerRadius, outerRadius));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;


            using (Matrix m = new Matrix())
            {
                m.RotateAt((360.0f - currentAngle) - 90.0f, new PointF(myBitmap.Width / 2,myBitmap.Height / 2));
                e.Graphics.Transform = m;
                e.Graphics.DrawImage(myBitmap, 0,0);
                e.Graphics.ResetTransform();
            }
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
