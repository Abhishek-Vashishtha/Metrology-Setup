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
    public partial class Metrology : Form
    {
        public Metrology()
        {
            InitializeComponent();
            Sidepanel.Height = Btn_wf.Height;
            Sidepanel.Top = Btn_wf.Top;
            //wF_CTRL1.Hide();
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
            if(CB_Wf_livestrm.Checked)
            {
              //  wF_CTRL1.BringToFront();
              //  wF_CTRL1.Show();
            }
            else
            {
               // wF_CTRL1.Hide();
            }
        }

        private void CB_Wf_livestrm_CheckedChanged(object sender, EventArgs e)
        {
            Pen Redpen = new Pen(Color.Red,2);
            Redpen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            
            Graphics gfx = Pnl_wf_live.CreateGraphics();
            //gfx.Clear(Color.Black);
            gfx.DrawLine(Redpen,10,20,30,40);
        }
    }
}
