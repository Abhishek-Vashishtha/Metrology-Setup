using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Metrology_Setup
{
    public partial class Metrology : Form
    {
        public Metrology()
        {
            InitializeComponent();
            Sidepanel.Height = Btn_wf.Height;
            Sidepanel.Top = Btn_wf.Top;
            //wF_CTRL1.Show();
            serial_port_init();
        }

        private void Btn_wf_Click(object sender, EventArgs e)
        {
            Sidepanel.Height=Btn_wf.Height;
            Sidepanel.Top=Btn_wf.Top;
        }

        private void Btn_Inst_data_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = Btn_Inst_data.Height;
            Sidepanel.Top=Btn_Inst_data.Top;
        }

        private void Btn_accuracy_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = Btn_accuracy.Height;
            Sidepanel.Top=Btn_accuracy.Top;
        }

        private void Btn_others_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = Btn_others.Height;
            Sidepanel.Top=Btn_others.Top;
        }

        private void Tmr_10ms_Tick(object sender, EventArgs e)
        {
            if(!wF_CTRL1.Cb_Live.Checked)
            {
              wF_CTRL1.Pb_Wf.BackgroundImage = null;
            }
        }

        private void wF_CTRL1_Load(object sender, EventArgs e)
        {
            wF_CTRL1.Default_combobox_message();
        }
        // Serial port functions

        public void serial_port_init()
        {
            SerialPort serialPort = new SerialPort();
        }
    }
}
