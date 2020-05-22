namespace HMP4040TesterApp
{
    partial class HMP4040Channel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutputVoltageLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputCurrentLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOverProtectionLevel = new System.Windows.Forms.TextBox();
            this.tsOutputEnable = new JCS.ToggleSwitch();
            this.lbOnOff = new Bulb.LedBulb();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ssMeasureDCVoltage = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.ssCurrent = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.ssVoltage = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ssMeasureDCVoltage);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOutputVoltageLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOutputCurrentLevel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOverProtectionLevel);
            this.groupBox1.Controls.Add(this.tsOutputEnable);
            this.groupBox1.Controls.Add(this.lbOnOff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ssCurrent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ssVoltage);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 398);
            this.groupBox1.TabIndex = 243;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 297;
            this.label6.Text = "M.DC Voltage";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 295;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 294;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 293;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 292;
            this.label5.Text = "Output voltage level";
            // 
            // txtOutputVoltageLevel
            // 
            this.txtOutputVoltageLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtOutputVoltageLevel.Location = new System.Drawing.Point(83, 316);
            this.txtOutputVoltageLevel.Name = "txtOutputVoltageLevel";
            this.txtOutputVoltageLevel.Size = new System.Drawing.Size(165, 26);
            this.txtOutputVoltageLevel.TabIndex = 291;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 290;
            this.label4.Text = "Output current level";
            // 
            // txtOutputCurrentLevel
            // 
            this.txtOutputCurrentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtOutputCurrentLevel.Location = new System.Drawing.Point(80, 263);
            this.txtOutputCurrentLevel.Name = "txtOutputCurrentLevel";
            this.txtOutputCurrentLevel.Size = new System.Drawing.Size(165, 26);
            this.txtOutputCurrentLevel.TabIndex = 289;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 288;
            this.label3.Text = "Over voltage protection level";
            // 
            // txtOverProtectionLevel
            // 
            this.txtOverProtectionLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtOverProtectionLevel.Location = new System.Drawing.Point(80, 204);
            this.txtOverProtectionLevel.Name = "txtOverProtectionLevel";
            this.txtOverProtectionLevel.Size = new System.Drawing.Size(165, 26);
            this.txtOverProtectionLevel.TabIndex = 287;
            // 
            // tsOutputEnable
            // 
            this.tsOutputEnable.Location = new System.Drawing.Point(16, 360);
            this.tsOutputEnable.Name = "tsOutputEnable";
            this.tsOutputEnable.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsOutputEnable.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsOutputEnable.Size = new System.Drawing.Size(50, 19);
            this.tsOutputEnable.TabIndex = 286;
            this.tsOutputEnable.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.tsOutputEnable_CheckedChanged);
            // 
            // lbOnOff
            // 
            this.lbOnOff.Location = new System.Drawing.Point(292, 10);
            this.lbOnOff.Name = "lbOnOff";
            this.lbOnOff.On = false;
            this.lbOnOff.Size = new System.Drawing.Size(41, 38);
            this.lbOnOff.TabIndex = 242;
            this.lbOnOff.Text = "ledBulb1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 242;
            this.label2.Text = "Current";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 240;
            this.label1.Text = "DC Voltage";
            // 
            // ssMeasureDCVoltage
            // 
            this.ssMeasureDCVoltage.ArrayCount = 8;
            this.ssMeasureDCVoltage.ColorBackground = System.Drawing.Color.Black;
            this.ssMeasureDCVoltage.ColorDark = System.Drawing.Color.Black;
            this.ssMeasureDCVoltage.ColorLight = System.Drawing.Color.Lime;
            this.ssMeasureDCVoltage.DecimalShow = true;
            this.ssMeasureDCVoltage.ElementPadding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.ssMeasureDCVoltage.ElementWidth = 10;
            this.ssMeasureDCVoltage.ItalicFactor = -0.1F;
            this.ssMeasureDCVoltage.Location = new System.Drawing.Point(80, 87);
            this.ssMeasureDCVoltage.Name = "ssMeasureDCVoltage";
            this.ssMeasureDCVoltage.Size = new System.Drawing.Size(168, 37);
            this.ssMeasureDCVoltage.TabIndex = 296;
            this.ssMeasureDCVoltage.TabStop = false;
            this.ssMeasureDCVoltage.Value = "00000000";
            // 
            // ssCurrent
            // 
            this.ssCurrent.ArrayCount = 8;
            this.ssCurrent.ColorBackground = System.Drawing.Color.Black;
            this.ssCurrent.ColorDark = System.Drawing.Color.Black;
            this.ssCurrent.ColorLight = System.Drawing.Color.Lime;
            this.ssCurrent.DecimalShow = true;
            this.ssCurrent.ElementPadding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.ssCurrent.ElementWidth = 10;
            this.ssCurrent.ItalicFactor = -0.1F;
            this.ssCurrent.Location = new System.Drawing.Point(80, 139);
            this.ssCurrent.Name = "ssCurrent";
            this.ssCurrent.Size = new System.Drawing.Size(168, 37);
            this.ssCurrent.TabIndex = 241;
            this.ssCurrent.TabStop = false;
            this.ssCurrent.Value = "00000000";
            // 
            // ssVoltage
            // 
            this.ssVoltage.ArrayCount = 8;
            this.ssVoltage.ColorBackground = System.Drawing.Color.Black;
            this.ssVoltage.ColorDark = System.Drawing.Color.Black;
            this.ssVoltage.ColorLight = System.Drawing.Color.Lime;
            this.ssVoltage.DecimalShow = true;
            this.ssVoltage.ElementPadding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.ssVoltage.ElementWidth = 10;
            this.ssVoltage.ItalicFactor = -0.1F;
            this.ssVoltage.Location = new System.Drawing.Point(80, 35);
            this.ssVoltage.Name = "ssVoltage";
            this.ssVoltage.Size = new System.Drawing.Size(168, 37);
            this.ssVoltage.TabIndex = 239;
            this.ssVoltage.TabStop = false;
            this.ssVoltage.Value = "00000000";
            // 
            // HMP4040Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "HMP4040Channel";
            this.Size = new System.Drawing.Size(349, 404);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected DmitryBrant.CustomControls.SevenSegmentArray ssVoltage;
        private Bulb.LedBulb lbOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected DmitryBrant.CustomControls.SevenSegmentArray ssCurrent;
        private JCS.ToggleSwitch tsOutputEnable;
        private System.Windows.Forms.TextBox txtOverProtectionLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputCurrentLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputVoltageLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        protected DmitryBrant.CustomControls.SevenSegmentArray ssMeasureDCVoltage;
    }
}
