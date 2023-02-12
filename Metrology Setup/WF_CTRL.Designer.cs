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
            this.Pb_wf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_wf)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_wf
            // 
            this.Pb_wf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pb_wf.Location = new System.Drawing.Point(3, 3);
            this.Pb_wf.Name = "Pb_wf";
            this.Pb_wf.Size = new System.Drawing.Size(1144, 646);
            this.Pb_wf.TabIndex = 0;
            this.Pb_wf.TabStop = false;
            // 
            // WF_CTRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pb_wf);
            this.Name = "WF_CTRL";
            this.Size = new System.Drawing.Size(1150, 652);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_wf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_wf;
    }
}
