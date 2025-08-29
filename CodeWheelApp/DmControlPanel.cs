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


    public partial class DmControlPanel : Form
    {
        public delegate void toggleShowDecodeListener();
        public toggleShowDecodeListener toggleShowDecode = null;
        
        public DmControlPanel()
        {
            InitializeComponent();
        }

        public void setDecodeValuesForWheel(string up, string mid, string down)
        {
            userControlDecoderDisplayWheel.setDisplayedValues(up, mid, down);
        }

        public void setDecodeValuesForScroll1(string up, string mid, string down)
        {
            userControlDecoderDisplayScroll1.setDisplayedValues(up, mid, down);
        }

        public void setDecodeValuesForScroll2(string up, string mid, string down)
        {
            userControlDecoderDisplayScroll2.setDisplayedValues(up, mid, down);
        }

        private void DmControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void buttonToggleTranslation_Click(object sender, EventArgs e)
        {
            toggleShowDecode?.Invoke();
        }
    }
}
