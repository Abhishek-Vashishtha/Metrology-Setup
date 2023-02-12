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
            this.CB_Wf_livestrm = new System.Windows.Forms.CheckBox();
            this.Tmr_10ms = new System.Windows.Forms.Timer(this.components);
            this.Pnl_wf_live = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(234, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 56);
            this.panel1.TabIndex = 4;
            // 
            // CB_Wf_livestrm
            // 
            this.CB_Wf_livestrm.AutoSize = true;
            this.CB_Wf_livestrm.BackColor = System.Drawing.Color.PaleVioletRed;
            this.CB_Wf_livestrm.Location = new System.Drawing.Point(1096, 88);
            this.CB_Wf_livestrm.Name = "CB_Wf_livestrm";
            this.CB_Wf_livestrm.Size = new System.Drawing.Size(138, 26);
            this.CB_Wf_livestrm.TabIndex = 7;
            this.CB_Wf_livestrm.Text = "Live Stream";
            this.CB_Wf_livestrm.UseVisualStyleBackColor = false;
            this.CB_Wf_livestrm.CheckedChanged += new System.EventHandler(this.CB_Wf_livestrm_CheckedChanged);
            // 
            // Tmr_10ms
            // 
            this.Tmr_10ms.Enabled = true;
            this.Tmr_10ms.Tick += new System.EventHandler(this.Tmr_10ms_Tick);
            // 
            // Pnl_wf_live
            // 
            this.Pnl_wf_live.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pnl_wf_live.Location = new System.Drawing.Point(240, 234);
            this.Pnl_wf_live.Name = "Pnl_wf_live";
            this.Pnl_wf_live.Size = new System.Drawing.Size(1088, 434);
            this.Pnl_wf_live.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(964, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Capture";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Metrology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1340, 737);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pnl_wf_live);
            this.Controls.Add(this.CB_Wf_livestrm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Metrology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metrology Setup 1.0.0";
            this.MainPanel.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox CB_Wf_livestrm;
        private System.Windows.Forms.Timer Tmr_10ms;
        private System.Windows.Forms.Panel Pnl_wf_live;
        private System.Windows.Forms.Button button1;
    }
}

