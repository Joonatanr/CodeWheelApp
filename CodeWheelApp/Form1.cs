namespace CodeWheelApp
{
    public partial class Form1 : Form
    {
        private SingleWheel InnerWheel;
        
        public Form1()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.TransparencyKey = Color.Black;

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

            InnerWheel = new SingleWheel(500);
            InnerWheel.ImageDictionary = InnerWheelDictionary;
            InnerWheel.WheelWidth = 80;

            textBox1.Text = InnerWheel.getCurrentSelectedValue();

            userControlInnerCodeWheel1.AddWheel(InnerWheel);

            //userControlInnerCodeWheel1.ImageDictionary = InnerWheelDictionary;
            //textBox1.Text = userControlInnerCodeWheel1.getCurrentSelectedValue();
        }

        private void buttonTurnLeft_Click(object sender, EventArgs e)
        {
            //userControlInnerCodeWheel1.Rotate(true);
            //textBox1.Text = userControlInnerCodeWheel1.getCurrentSelectedValue();
            InnerWheel.Rotate(true);
            textBox1.Text = InnerWheel.getCurrentSelectedValue();
        }

        private void buttonTurnRight_Click(object sender, EventArgs e)
        {
            //userControlInnerCodeWheel1.Rotate(false);
            //textBox1.Text = userControlInnerCodeWheel1.getCurrentSelectedValue();
            InnerWheel.Rotate(false);
            textBox1.Text = InnerWheel.getCurrentSelectedValue();
        }
    }
}
