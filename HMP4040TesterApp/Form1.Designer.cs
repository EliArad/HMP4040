namespace HMP4040TesterApp
{
    partial class Form1
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
            this.btnOnOff = new JCS.ToggleSwitch();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.hmP4040Channel4 = new HMP4040TesterApp.HMP4040Channel();
            this.hmP4040Channel3 = new HMP4040TesterApp.HMP4040Channel();
            this.hmP4040Channel2 = new HMP4040TesterApp.HMP4040Channel();
            this.hmP4040Channel1 = new HMP4040TesterApp.HMP4040Channel();
            this.tgMasterOnOff = new JCS.ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(77, 439);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.Size = new System.Drawing.Size(50, 19);
            this.btnOnOff.TabIndex = 287;
            this.btnOnOff.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.btnOnOff_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1021, 446);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 288;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Settings";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 289;
            this.label1.Text = "Connect ->";
            // 
            // hmP4040Channel4
            // 
            this.hmP4040Channel4.BackColor = System.Drawing.Color.White;
            this.hmP4040Channel4.Location = new System.Drawing.Point(1069, 12);
            this.hmP4040Channel4.Name = "hmP4040Channel4";
            this.hmP4040Channel4.Size = new System.Drawing.Size(342, 394);
            this.hmP4040Channel4.TabIndex = 290;
            // 
            // hmP4040Channel3
            // 
            this.hmP4040Channel3.BackColor = System.Drawing.Color.White;
            this.hmP4040Channel3.Location = new System.Drawing.Point(724, 12);
            this.hmP4040Channel3.Name = "hmP4040Channel3";
            this.hmP4040Channel3.Size = new System.Drawing.Size(342, 394);
            this.hmP4040Channel3.TabIndex = 2;
            // 
            // hmP4040Channel2
            // 
            this.hmP4040Channel2.BackColor = System.Drawing.Color.White;
            this.hmP4040Channel2.Location = new System.Drawing.Point(376, 12);
            this.hmP4040Channel2.Name = "hmP4040Channel2";
            this.hmP4040Channel2.Size = new System.Drawing.Size(342, 394);
            this.hmP4040Channel2.TabIndex = 1;
            // 
            // hmP4040Channel1
            // 
            this.hmP4040Channel1.BackColor = System.Drawing.Color.White;
            this.hmP4040Channel1.Location = new System.Drawing.Point(12, 12);
            this.hmP4040Channel1.Name = "hmP4040Channel1";
            this.hmP4040Channel1.Size = new System.Drawing.Size(342, 394);
            this.hmP4040Channel1.TabIndex = 0;
            this.hmP4040Channel1.Load += new System.EventHandler(this.hmP4040Channel1_Load);
            // 
            // tgMasterOnOff
            // 
            this.tgMasterOnOff.Location = new System.Drawing.Point(398, 441);
            this.tgMasterOnOff.Name = "tgMasterOnOff";
            this.tgMasterOnOff.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgMasterOnOff.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgMasterOnOff.Size = new System.Drawing.Size(50, 19);
            this.tgMasterOnOff.TabIndex = 291;
            this.tgMasterOnOff.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleSwitch1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 292;
            this.label2.Text = "Master On Off";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1419, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tgMasterOnOff);
            this.Controls.Add(this.hmP4040Channel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.hmP4040Channel3);
            this.Controls.Add(this.hmP4040Channel2);
            this.Controls.Add(this.hmP4040Channel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMP4040";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMP4040Channel hmP4040Channel1;
        private HMP4040Channel hmP4040Channel2;
        private HMP4040Channel hmP4040Channel3;
        private JCS.ToggleSwitch btnOnOff;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private HMP4040Channel hmP4040Channel4;
        private JCS.ToggleSwitch tgMasterOnOff;
        private System.Windows.Forms.Label label2;
    }
}

