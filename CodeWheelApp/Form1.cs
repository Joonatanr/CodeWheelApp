namespace CodeWheelApp
{
    public partial class Form1 : Form
    {
        private SingleWheel InnerWheel;
        private SingleWheel MidWheel;
        private SingleWheel OuterWheel;

        public Form1()
        {
            InitializeComponent();

            /* INNER WHEEL */
            Dictionary<string, Bitmap> InnerWheelDictionary = new Dictionary<string, Bitmap>();

            InnerWheelDictionary.Add("TURN", Properties.Resources.INNER_TURN);
            InnerWheelDictionary.Add("REPAIR", Properties.Resources.INNER_REPAIR);
            InnerWheelDictionary.Add("POUND", Properties.Resources.INNER_POUND);
            InnerWheelDictionary.Add("HIT", Properties.Resources.INNER_HIT);

            InnerWheelDictionary.Add("THROW", Properties.Resources.INNER_THROW);
            InnerWheelDictionary.Add("DANCE", Properties.Resources.INNER_DANCE);
            InnerWheelDictionary.Add("ATTACK", Properties.Resources.INNER_ATTACK);
            InnerWheelDictionary.Add("SING", Properties.Resources.INNER_SING);

            InnerWheelDictionary.Add("PUSH", Properties.Resources.INNER_PUSH);
            InnerWheelDictionary.Add("PICKUP", Properties.Resources.INNER_PICKUP);
            InnerWheelDictionary.Add("PULL", Properties.Resources.INNER_PULL);
            InnerWheelDictionary.Add("DISINTEGRATE", Properties.Resources.INNER_DISINTEGRATE);

            InnerWheel = new SingleWheel(300);
            InnerWheel.ImageDictionary = InnerWheelDictionary;
            InnerWheel.WheelWidth = 65;
            InnerWheel.WheelColor = Color.FromArgb(255, 229, 153);
            InnerWheel.setToValue("DANCE");

            textBoxInnerWheel.Text = InnerWheel.getCurrentSelectedValue();
            userControlInnerCodeWheel1.AddWheel(InnerWheel);

            /* MIDDLE WHEEL */
            Dictionary<string, Bitmap> MidWheelDictionary = new Dictionary<string, Bitmap>();

            MidWheelDictionary.Add("WHEEL", Properties.Resources.MID_WHEEL);
            MidWheelDictionary.Add("INTRUDERS", Properties.Resources.MID_INTRUDERS);
            MidWheelDictionary.Add("ROCK", Properties.Resources.MID_ROCK);
            MidWheelDictionary.Add("TREE", Properties.Resources.MID_TREE);

            MidWheelDictionary.Add("GATE", Properties.Resources.MID_GATE);
            MidWheelDictionary.Add("HUMAN", Properties.Resources.MID_HUMAN);
            MidWheelDictionary.Add("GNOME", Properties.Resources.MID_GNOME);
            MidWheelDictionary.Add("ELF", Properties.Resources.MID_ELF);

            MidWheelDictionary.Add("GOLEM", Properties.Resources.MID_GOLEM);
            MidWheelDictionary.Add("SELF", Properties.Resources.MID_SELF);
            MidWheelDictionary.Add("GROUND", Properties.Resources.MID_GROUND);
            MidWheelDictionary.Add("EVERYBODY", Properties.Resources.MID_EVERYBODY);

            MidWheel = new SingleWheel(InnerWheel.WheelDiameter + (InnerWheel.WheelWidth * 2));
            MidWheel.ImageDictionary = MidWheelDictionary;
            MidWheel.WheelWidth = InnerWheel.WheelWidth;
            MidWheel.WheelColor = Color.FromArgb(255, 217, 102);
            MidWheel.setToValue("HUMAN");

            textBoxMidWheel.Text = MidWheel.getCurrentSelectedValue();
            userControlInnerCodeWheel1.AddWheel(MidWheel);

            /* OUTER WHEEL */
            Dictionary<string, Bitmap> OuterWheelDictionary = new Dictionary<string, Bitmap>();

            OuterWheelDictionary.Add("CLOCKWISE", Properties.Resources.OUTER_CLOCKWISE);
            OuterWheelDictionary.Add("COUNTERCLOCKWISE", Properties.Resources.OUTER_COUNTERCLOCKWISE);
            OuterWheelDictionary.Add("HARD", Properties.Resources.OUTER_HARD);
            OuterWheelDictionary.Add("GENTLY", Properties.Resources.OUTER_GENTLY);

            OuterWheelDictionary.Add("FAST", Properties.Resources.OUTER_FAST);
            OuterWheelDictionary.Add("SLOWLY", Properties.Resources.OUTER_SLOWLY);
            OuterWheelDictionary.Add("VICIOUSLY", Properties.Resources.OUTER_VICIOUSLY);
            OuterWheelDictionary.Add("GRACEFULLY", Properties.Resources.OUTER_GRACEFULLY);

            OuterWheelDictionary.Add("THATRICALLY", Properties.Resources.OUTER_THEATRICALLY);
            OuterWheelDictionary.Add("DRAMATICALLY", Properties.Resources.OUTER_DRAMATICALLY);
            OuterWheelDictionary.Add("ROUGHLY", Properties.Resources.OUTER_ROUGHLY);
            OuterWheelDictionary.Add("SNEAKILY", Properties.Resources.OUTER_SNEAKILY);

            OuterWheel = new SingleWheel(MidWheel.WheelDiameter + (MidWheel.WheelWidth * 2));
            OuterWheel.ImageDictionary = OuterWheelDictionary;
            OuterWheel.WheelWidth = MidWheel.WheelWidth;
            OuterWheel.WheelColor = Color.FromArgb(241, 194, 50);
            OuterWheel.setToValue("SLOWLY");

            textBoxOuterWheel.Text = OuterWheel.getCurrentSelectedValue();
            userControlInnerCodeWheel1.AddWheel(OuterWheel);

        }

        private void buttonTurnLeft_Click(object sender, EventArgs e)
        {
            InnerWheel.Rotate(true);
            textBoxInnerWheel.Text = InnerWheel.getCurrentSelectedValue();
        }

        private void buttonTurnRight_Click(object sender, EventArgs e)
        {
            InnerWheel.Rotate(false);
            textBoxInnerWheel.Text = InnerWheel.getCurrentSelectedValue();
        }

        private void buttonTurnMidLeft_Click(object sender, EventArgs e)
        {
            MidWheel.Rotate(true);
            textBoxMidWheel.Text = MidWheel.getCurrentSelectedValue();
        }

        private void buttonTurnMidRight_Click(object sender, EventArgs e)
        {
            MidWheel.Rotate(false);
            textBoxMidWheel.Text = MidWheel.getCurrentSelectedValue();
        }

        private void buttonTurnOuterLeft_Click(object sender, EventArgs e)
        {
            OuterWheel.Rotate(true);
            textBoxOuterWheel.Text = OuterWheel.getCurrentSelectedValue();
        }

        private void buttonTurnOuterRight_Click(object sender, EventArgs e)
        {
            OuterWheel.Rotate(false);
            textBoxOuterWheel.Text = OuterWheel.getCurrentSelectedValue();
        }

        private void buttonPrintPress_Click(object sender, EventArgs e)
        {
            Bitmap top = InnerWheel.getCurrentSelectedImage();
            Bitmap middle = MidWheel.getCurrentSelectedImage();
            Bitmap bottom = OuterWheel.getCurrentSelectedImage();

            userControlScroll1.setGlyphImages(top, middle, bottom);
        }

        private void buttonPrintPress2_Click(object sender, EventArgs e)
        {
            Bitmap top = InnerWheel.getCurrentSelectedImage();
            Bitmap middle = MidWheel.getCurrentSelectedImage();
            Bitmap bottom = OuterWheel.getCurrentSelectedImage();

            userControlScroll2.setGlyphImages(top, middle, bottom);
        }
    }
}
