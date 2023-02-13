namespace Metrology_Setup
{
    partial class WF_CTRL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cb_Live = new System.Windows.Forms.CheckBox();
            this.RtxtBox_WF_points = new System.Windows.Forms.RichTextBox();
            this.Btn_Capture = new System.Windows.Forms.Button();
            this.Pb_Wf = new System.Windows.Forms.PictureBox();
            this.Btn_SAVE_wf = new System.Windows.Forms.Button();
            this.TxtB_NoOf_Sample = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.Chkbox_Wf_select1 = new System.Windows.Forms.CheckBox();
            this.Chkbox_Wf_select2 = new System.Windows.Forms.CheckBox();
            this.Chkbox_Wf_select3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Wf)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb_Live
            // 
            this.Cb_Live.AutoSize = true;
            this.Cb_Live.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cb_Live.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Live.Location = new System.Drawing.Point(318, 196);
            this.Cb_Live.Name = "Cb_Live";
            this.Cb_Live.Size = new System.Drawing.Size(93, 17);
            this.Cb_Live.TabIndex = 2;
            this.Cb_Live.Text = "Live Stream";
            this.Cb_Live.UseVisualStyleBackColor = false;
            this.Cb_Live.CheckedChanged += new System.EventHandler(this.Cb_Live_CheckedChanged);
            // 
            // RtxtBox_WF_points
            // 
            this.RtxtBox_WF_points.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RtxtBox_WF_points.Enabled = false;
            this.RtxtBox_WF_points.Location = new System.Drawing.Point(232, 13);
            this.RtxtBox_WF_points.Name = "RtxtBox_WF_points";
            this.RtxtBox_WF_points.Size = new System.Drawing.Size(501, 152);
            this.RtxtBox_WF_points.TabIndex = 3;
            this.RtxtBox_WF_points.Text = "";
            this.RtxtBox_WF_points.TextChanged += new System.EventHandler(this.RtxtBox_WF_points_TextChanged);
            // 
            // Btn_Capture
            // 
            this.Btn_Capture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_Capture.FlatAppearance.BorderSize = 0;
            this.Btn_Capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Capture.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Capture.Location = new System.Drawing.Point(192, 188);
            this.Btn_Capture.Name = "Btn_Capture";
            this.Btn_Capture.Size = new System.Drawing.Size(93, 30);
            this.Btn_Capture.TabIndex = 5;
            this.Btn_Capture.Text = "CAPTURE";
            this.Btn_Capture.UseVisualStyleBackColor = false;
            this.Btn_Capture.Click += new System.EventHandler(this.Btn_Capture_Click);
            // 
            // Pb_Wf
            // 
            this.Pb_Wf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pb_Wf.Location = new System.Drawing.Point(25, 224);
            this.Pb_Wf.Name = "Pb_Wf";
            this.Pb_Wf.Size = new System.Drawing.Size(708, 281);
            this.Pb_Wf.TabIndex = 6;
            this.Pb_Wf.TabStop = false;
            // 
            // Btn_SAVE_wf
            // 
            this.Btn_SAVE_wf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SAVE_wf.FlatAppearance.BorderSize = 0;
            this.Btn_SAVE_wf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SAVE_wf.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SAVE_wf.Location = new System.Drawing.Point(462, 188);
            this.Btn_SAVE_wf.Name = "Btn_SAVE_wf";
            this.Btn_SAVE_wf.Size = new System.Drawing.Size(93, 30);
            this.Btn_SAVE_wf.TabIndex = 8;
            this.Btn_SAVE_wf.Text = "SAVE DATA";
            this.Btn_SAVE_wf.UseVisualStyleBackColor = false;
            // 
            // TxtB_NoOf_Sample
            // 
            this.TxtB_NoOf_Sample.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TxtB_NoOf_Sample.Location = new System.Drawing.Point(140, 150);
            this.TxtB_NoOf_Sample.Name = "TxtB_NoOf_Sample";
            this.TxtB_NoOf_Sample.Size = new System.Drawing.Size(34, 20);
            this.TxtB_NoOf_Sample.TabIndex = 9;
            this.TxtB_NoOf_Sample.Text = "78";
            this.TxtB_NoOf_Sample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "NO. OF SAMPLES:-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NONE",
            "VOL R",
            "VOL Y",
            "VOL B",
            "VOL R 90Deg",
            "VOL Y 90Deg",
            "VOL B 90Deg",
            "CURR R",
            "CURR Y",
            "CURR B"});
            this.comboBox1.Location = new System.Drawing.Point(3, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "NONE",
            "VOL R",
            "VOL Y",
            "VOL B",
            "VOL R 90Deg",
            "VOL Y 90Deg",
            "VOL B 90Deg",
            "CURR R",
            "CURR Y",
            "CURR B"});
            this.comboBox2.Location = new System.Drawing.Point(3, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "NONE",
            "VOL R",
            "VOL Y",
            "VOL B",
            "VOL R 90Deg",
            "VOL Y 90Deg",
            "VOL B 90Deg",
            "CURR R",
            "CURR Y",
            "CURR B"});
            this.comboBox5.Location = new System.Drawing.Point(3, 93);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(95, 21);
            this.comboBox5.TabIndex = 15;
            // 
            // Chkbox_Wf_select1
            // 
            this.Chkbox_Wf_select1.AutoSize = true;
            this.Chkbox_Wf_select1.Location = new System.Drawing.Point(140, 15);
            this.Chkbox_Wf_select1.Name = "Chkbox_Wf_select1";
            this.Chkbox_Wf_select1.Size = new System.Drawing.Size(48, 17);
            this.Chkbox_Wf_select1.TabIndex = 16;
            this.Chkbox_Wf_select1.Text = "Raw";
            this.Chkbox_Wf_select1.UseVisualStyleBackColor = true;
            // 
            // Chkbox_Wf_select2
            // 
            this.Chkbox_Wf_select2.AutoSize = true;
            this.Chkbox_Wf_select2.Location = new System.Drawing.Point(140, 55);
            this.Chkbox_Wf_select2.Name = "Chkbox_Wf_select2";
            this.Chkbox_Wf_select2.Size = new System.Drawing.Size(48, 17);
            this.Chkbox_Wf_select2.TabIndex = 17;
            this.Chkbox_Wf_select2.Text = "Raw";
            this.Chkbox_Wf_select2.UseVisualStyleBackColor = true;
            // 
            // Chkbox_Wf_select3
            // 
            this.Chkbox_Wf_select3.AutoSize = true;
            this.Chkbox_Wf_select3.Location = new System.Drawing.Point(140, 95);
            this.Chkbox_Wf_select3.Name = "Chkbox_Wf_select3";
            this.Chkbox_Wf_select3.Size = new System.Drawing.Size(48, 17);
            this.Chkbox_Wf_select3.TabIndex = 18;
            this.Chkbox_Wf_select3.Text = "Raw";
            this.Chkbox_Wf_select3.UseVisualStyleBackColor = true;
            // 
            // WF_CTRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.Chkbox_Wf_select3);
            this.Controls.Add(this.Chkbox_Wf_select2);
            this.Controls.Add(this.Chkbox_Wf_select1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtB_NoOf_Sample);
            this.Controls.Add(this.Btn_SAVE_wf);
            this.Controls.Add(this.Pb_Wf);
            this.Controls.Add(this.Btn_Capture);
            this.Controls.Add(this.RtxtBox_WF_points);
            this.Controls.Add(this.Cb_Live);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WF_CTRL";
            this.Size = new System.Drawing.Size(745, 517);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Wf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox RtxtBox_WF_points;
        private System.Windows.Forms.Button Btn_Capture;
        public System.Windows.Forms.CheckBox Cb_Live;
        private System.Windows.Forms.Button Btn_SAVE_wf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Chkbox_Wf_select1;
        private System.Windows.Forms.CheckBox Chkbox_Wf_select2;
        private System.Windows.Forms.CheckBox Chkbox_Wf_select3;
        public System.Windows.Forms.TextBox TxtB_NoOf_Sample;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox5;
        public System.Windows.Forms.PictureBox Pb_Wf;
    }
}
