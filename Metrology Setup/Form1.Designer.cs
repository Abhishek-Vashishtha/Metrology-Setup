namespace Metrology_Setup
{
    partial class Metrology
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Btn_wf = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.Btn_others = new System.Windows.Forms.Button();
            this.Btn_accuracy = new System.Windows.Forms.Button();
            this.Btn_Inst_data = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tmr_10ms = new System.Windows.Forms.Timer(this.components);
            this.wF_CTRL1 = new Metrology_Setup.WF_CTRL();
            this.Cb_ComPort = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort_main = new System.IO.Ports.SerialPort(this.components);
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.Btn_wf);
            this.MainPanel.Controls.Add(this.Sidepanel);
            this.MainPanel.Controls.Add(this.Btn_others);
            this.MainPanel.Controls.Add(this.Btn_accuracy);
            this.MainPanel.Controls.Add(this.Btn_Inst_data);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(234, 737);
            this.MainPanel.TabIndex = 3;
            // 
            // Btn_wf
            // 
            this.Btn_wf.BackColor = System.Drawing.Color.Black;
            this.Btn_wf.FlatAppearance.BorderSize = 0;
            this.Btn_wf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_wf.ForeColor = System.Drawing.Color.Crimson;
            this.Btn_wf.Location = new System.Drawing.Point(36, 96);
            this.Btn_wf.Name = "Btn_wf";
            this.Btn_wf.Size = new System.Drawing.Size(195, 63);
            this.Btn_wf.TabIndex = 5;
            this.Btn_wf.Text = "Waveforms";
            this.Btn_wf.UseVisualStyleBackColor = false;
            this.Btn_wf.Click += new System.EventHandler(this.Btn_wf_Click);
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.Sidepanel.Location = new System.Drawing.Point(3, 96);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 65);
            this.Sidepanel.TabIndex = 6;
            // 
            // Btn_others
            // 
            this.Btn_others.BackColor = System.Drawing.Color.Black;
            this.Btn_others.FlatAppearance.BorderSize = 0;
            this.Btn_others.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_others.ForeColor = System.Drawing.Color.Crimson;
            this.Btn_others.Location = new System.Drawing.Point(33, 303);
            this.Btn_others.Name = "Btn_others";
            this.Btn_others.Size = new System.Drawing.Size(198, 63);
            this.Btn_others.TabIndex = 5;
            this.Btn_others.Text = "Others";
            this.Btn_others.UseVisualStyleBackColor = false;
            this.Btn_others.Click += new System.EventHandler(this.Btn_others_Click);
            // 
            // Btn_accuracy
            // 
            this.Btn_accuracy.BackColor = System.Drawing.Color.Black;
            this.Btn_accuracy.FlatAppearance.BorderSize = 0;
            this.Btn_accuracy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_accuracy.ForeColor = System.Drawing.Color.Crimson;
            this.Btn_accuracy.Location = new System.Drawing.Point(33, 234);
            this.Btn_accuracy.Name = "Btn_accuracy";
            this.Btn_accuracy.Size = new System.Drawing.Size(198, 63);
            this.Btn_accuracy.TabIndex = 5;
            this.Btn_accuracy.Text = "Accuracy";
            this.Btn_accuracy.UseVisualStyleBackColor = false;
            this.Btn_accuracy.Click += new System.EventHandler(this.Btn_accuracy_Click);
            // 
            // Btn_Inst_data
            // 
            this.Btn_Inst_data.BackColor = System.Drawing.Color.Black;
            this.Btn_Inst_data.FlatAppearance.BorderSize = 0;
            this.Btn_Inst_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Inst_data.ForeColor = System.Drawing.Color.Crimson;
            this.Btn_Inst_data.Location = new System.Drawing.Point(33, 165);
            this.Btn_Inst_data.Name = "Btn_Inst_data";
            this.Btn_Inst_data.Size = new System.Drawing.Size(198, 63);
            this.Btn_Inst_data.TabIndex = 5;
            this.Btn_Inst_data.Text = "Instant data";
            this.Btn_Inst_data.UseVisualStyleBackColor = false;
            this.Btn_Inst_data.Click += new System.EventHandler(this.Btn_Inst_data_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.Cb_ComPort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(234, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 56);
            this.panel1.TabIndex = 4;
            // 
            // Tmr_10ms
            // 
            this.Tmr_10ms.Enabled = true;
            this.Tmr_10ms.Tick += new System.EventHandler(this.Tmr_10ms_Tick);
            // 
            // wF_CTRL1
            // 
            this.wF_CTRL1.AutoScroll = true;
            this.wF_CTRL1.AutoSize = true;
            this.wF_CTRL1.Location = new System.Drawing.Point(246, 63);
            this.wF_CTRL1.Margin = new System.Windows.Forms.Padding(2);
            this.wF_CTRL1.Name = "wF_CTRL1";
            this.wF_CTRL1.Size = new System.Drawing.Size(1104, 664);
            this.wF_CTRL1.TabIndex = 5;
            this.wF_CTRL1.Load += new System.EventHandler(this.wF_CTRL1_Load);
            // 
            // Cb_ComPort
            // 
            this.Cb_ComPort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Cb_ComPort.FormattingEnabled = true;
            this.Cb_ComPort.Location = new System.Drawing.Point(146, 17);
            this.Cb_ComPort.Name = "Cb_ComPort";
            this.Cb_ComPort.Size = new System.Drawing.Size(75, 25);
            this.Cb_ComPort.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "57200"});
            this.comboBox2.Location = new System.Drawing.Point(359, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 25);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM PORT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD RATE:";
            // 
            // Metrology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1377, 737);
            this.Controls.Add(this.wF_CTRL1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Metrology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metrology Setup 1.0.0";
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button Btn_others;
        private System.Windows.Forms.Button Btn_accuracy;
        private System.Windows.Forms.Button Btn_Inst_data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_wf;
        private System.Windows.Forms.Timer Tmr_10ms;
        private WF_CTRL wF_CTRL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox Cb_ComPort;
        private System.IO.Ports.SerialPort serialPort_main;
    }
}

