using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrology_Setup
{
    public partial class WF_CTRL : UserControl
    {
        public WF_CTRL()
        {
            InitializeComponent();
        }

        private void Cb_Live_CheckedChanged(object sender, EventArgs e)
        {
            //Pen Redpen = new Pen(Color.Red,2);
            //Graphics g = Pnl_live_wf.CreateGraphics();

           // g.DrawLine(Redpen, 100, 200, 120, 210);
        }

        private void RtxtBox_WF_points_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Capture_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Default_combobox_message()
        {
            comboBox1.Text = "Select Type";
            comboBox2.Text = "Select Type";
            comboBox5.Text = "Select Type";
        }
    }
}
