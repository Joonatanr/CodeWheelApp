using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace CodeWheelApp
{
    public class SingleWheel
    {
        private struct WheelEntry_T
        {
            public string Value;
            public float Angle;
            public Bitmap Image;
        }

        private Dictionary<string, Bitmap> myImageDictionary = new Dictionary<string, Bitmap>();
        private List<WheelEntry_T> myValues = new List<WheelEntry_T>();
        private int selectedIndex = 0;
        private float currentAngle = 90.0f;
        private Color wheelColor = Color.Blue;

        private Bitmap myBitmap;

        public Color WheelColor 
        {   get
            {
                return wheelColor;
            }
            set
            {
                wheelColor = value;
                updateBitmap();
            }
        }

        private int _wheelWidth = 80;
        private int _wheelDiameter = 480;

        public int WheelWidth 
        {
            get
            {
                return _wheelWidth;
            }


            set
            {
                _wheelWidth = value;

            }
        }
        public int WheelDiameter 
        { 
            get 
            { 
                return _wheelDiameter; 
            } 
            set
            {
                if (_wheelDiameter != value)
                {
                    _wheelDiameter = value;
                    myBitmap = new Bitmap(WheelDiameter, WheelDiameter);
                    updateBitmap();
                }
            } 
        }

        public Boolean IsDynamicGlyphResize { get; set; } = false;

        public float OuterRadius { get { return WheelDiameter / 2; } }
        public float InnerRadius { get { return (OuterRadius - WheelWidth); } }

        /* Called when the user control should redraw. */
        public delegate void RequestRedrawHandler();
        public RequestRedrawHandler requestRedraw = null;

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
                    angle += interval;
                }

                if (myValues.Count > 0)
                {
                    selectedIndex = 0;
                    currentAngle = myValues[selectedIndex].Angle;
                    rotateWheel(currentAngle);
                }
            }
        }

        public SingleWheel() 
        {
            /* Set up the main bitmap object. */
            myBitmap = new Bitmap(WheelDiameter, WheelDiameter);

            updateBitmap();
        }

        public SingleWheel(int diameter)
        {
            this.WheelDiameter = diameter;

            /* Set up the main bitmap object. */
            myBitmap = new Bitmap(WheelDiameter, WheelDiameter);

            updateBitmap();
        }

        public void Draw(Graphics gfx, PointF canvasCenter)
        {
            using (Matrix m = new Matrix())
            {
                PointF centerPoint = new PointF(myBitmap.Width / 2, myBitmap.Height / 2);
                m.Translate(canvasCenter.X - (myBitmap.Width / 2), canvasCenter.Y - (myBitmap.Height / 2));
                m.RotateAt((360.0f - currentAngle) - 90.0f, centerPoint);
                
                gfx.Transform = m;
                gfx.DrawImage(myBitmap, 0, 0);
                gfx.ResetTransform();
            }
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

                Bitmap resized;

                if (IsDynamicGlyphResize)
                {
                    int divisor;
                    int multiplier = 1;

                    if (this.WheelWidth < 10)
                    {
                        divisor = 8;
                    }else if (this.WheelWidth < 30)
                    {
                        divisor = 6;
                    }else if (this.WheelWidth < 70)
                    {
                        divisor = 4;
                    }
                    else if (this.WheelWidth < 100)
                    {
                        divisor = 2;
                    }
                    else if(this.WheelWidth < 150)
                    {
                        multiplier = 2;
                        divisor = 3;
                    }
                    else
                    {
                        divisor = 1;
                    }

                    resized = new Bitmap(original, new Size(original.Width * multiplier / divisor, original.Height * multiplier / divisor));

                }
                else
                {
                    resized = new Bitmap(original, new Size(original.Width / 2, original.Height / 2));
                }

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
        }

        private void drawDonut(Graphics gfx, PointF center, float radius)
        {

            gfx.SmoothingMode = SmoothingMode.AntiAlias;
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

            SolidBrush myBrush = new SolidBrush(WheelColor);

            float innerRadius = radius - WheelWidth;
            float outerRadius = radius;

            gfx.FillRegion(myBrush, GetRingRegion(center, innerRadius, outerRadius));

            gfx.DrawEllipse(new Pen(Color.Black, 2), getRectangleAroundCenterPoint(center, new SizeF(outerRadius * 2 - 2, outerRadius * 2 - 2)));
            gfx.DrawEllipse(new Pen(Color.Black, 2), getRectangleAroundCenterPoint(center, new SizeF(innerRadius * 2, innerRadius * 2)));
        }

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

        public void setToValue(string value)
        {
            for (int x = 0; x < myValues.Count; x++)
            { 
                if (myValues[x].Value == value)
                {
                    /* Set the position of the code wheel. */
                    selectedIndex = x;
                    rotateWheel(myValues[x].Angle);
                    break;
                }
            }
        }

        public Bitmap getCurrentSelectedImage()
        {
            try
            {
                return myValues[selectedIndex].Image;
            }
            catch (Exception)
            {
                return null;
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


        public static RectangleF getRectangleAroundCenterPoint(PointF center, SizeF size)
        {
            float xPos = center.X - size.Width / 2;
            float yPos = center.Y - size.Height / 2;

            return new RectangleF(xPos, yPos, size.Width, size.Height);
        }

        public static Region GetRingRegion(PointF center, float innerRadius, float outerRadius)
        {
            // You need a path for the outer and inner circles
            var path1 = new GraphicsPath();
            var path2 = new GraphicsPath();

            // Define the paths (where X, Y, and D are chosen externally)
            path1.AddEllipse(GetRectangle(center, outerRadius));
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

        private void updateBitmap()
        {
            if (myBitmap != null)
            {
                float radius = WheelDiameter / 2;
                PointF center = new PointF(myBitmap.Width / 2, myBitmap.Height / 2);

                /* Get the graphics object from the bitmap.  */
                Graphics gfx = Graphics.FromImage(myBitmap);
                gfx.Clear(Color.Transparent);

                drawDonut(gfx, center, radius);
                drawImages(gfx, center, radius - (WheelWidth / 2));
            }

            requestRedraw?.Invoke();
        }

        private void rotateWheel(float angle)
        {
            currentAngle = angle;
            updateBitmap();
        }
    }
}
