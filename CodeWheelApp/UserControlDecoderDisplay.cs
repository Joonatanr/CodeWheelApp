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
    public partial class UserControlDecoderDisplay : UserControl
    {   
        public UserControlDecoderDisplay()
        {
            InitializeComponent();
        }

        public void setDisplayedValues(string top, string mid, string bottom)
        {
            textBoxInnerWheel.Text = top;
            textBoxMidWheel.Text = mid;
            textBoxOuterWheel.Text = bottom;
        }
    }
}
