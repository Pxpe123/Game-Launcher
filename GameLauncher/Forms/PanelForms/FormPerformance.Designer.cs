namespace GameLauncher.Forms
{
    partial class FormPerformance
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBack = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneCircleProgressBar2 = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneCircleProgressBar1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelBack.Controls.Add(this.label6);
            this.panelBack.Controls.Add(this.siticoneCircleProgressBar2);
            this.panelBack.Controls.Add(this.label5);
            this.panelBack.Controls.Add(this.siticoneCircleProgressBar1);
            this.panelBack.Controls.Add(this.label2);
            this.panelBack.Controls.Add(this.label3);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1184, 818);
            this.panelBack.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(577, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "GPU Usage (%) =";
            // 
            // siticoneCircleProgressBar2
            // 
            this.siticoneCircleProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCircleProgressBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneCircleProgressBar2.FillThickness = 35;
            this.siticoneCircleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneCircleProgressBar2.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleProgressBar2.Location = new System.Drawing.Point(551, 206);
            this.siticoneCircleProgressBar2.Minimum = 0;
            this.siticoneCircleProgressBar2.Name = "siticoneCircleProgressBar2";
            this.siticoneCircleProgressBar2.ProgressColor = System.Drawing.Color.Empty;
            this.siticoneCircleProgressBar2.ProgressColor2 = System.Drawing.Color.Red;
            this.siticoneCircleProgressBar2.ProgressThickness = 35;
            this.siticoneCircleProgressBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.siticoneCircleProgressBar2.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleProgressBar2.ShowText = true;
            this.siticoneCircleProgressBar2.Size = new System.Drawing.Size(248, 248);
            this.siticoneCircleProgressBar2.TabIndex = 11;
            this.siticoneCircleProgressBar2.TextMode = Siticone.Desktop.UI.WinForms.Enums.ProgressBarTextMode.Custom;
            this.siticoneCircleProgressBar2.UseTransparentBackground = true;
            this.siticoneCircleProgressBar2.Value = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(91, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPU Usage (%) =";
            // 
            // siticoneCircleProgressBar1
            // 
            this.siticoneCircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneCircleProgressBar1.FillThickness = 35;
            this.siticoneCircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneCircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleProgressBar1.Location = new System.Drawing.Point(64, 206);
            this.siticoneCircleProgressBar1.Minimum = 0;
            this.siticoneCircleProgressBar1.Name = "siticoneCircleProgressBar1";
            this.siticoneCircleProgressBar1.ProgressColor = System.Drawing.Color.Empty;
            this.siticoneCircleProgressBar1.ProgressColor2 = System.Drawing.Color.Red;
            this.siticoneCircleProgressBar1.ProgressThickness = 35;
            this.siticoneCircleProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.siticoneCircleProgressBar1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleProgressBar1.ShowText = true;
            this.siticoneCircleProgressBar1.Size = new System.Drawing.Size(248, 248);
            this.siticoneCircleProgressBar1.TabIndex = 9;
            this.siticoneCircleProgressBar1.TextMode = Siticone.Desktop.UI.WinForms.Enums.ProgressBarTextMode.Custom;
            this.siticoneCircleProgressBar1.UseTransparentBackground = true;
            this.siticoneCircleProgressBar1.Value = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "RAM Usage (MB) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "System Uptime =";
            // 
            // FormPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1184, 818);
            this.Controls.Add(this.panelBack);
            this.Name = "FormPerformance";
            this.Text = "Performance";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel panelBack;
        private Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar siticoneCircleProgressBar2;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar siticoneCircleProgressBar1;
        private Label label2;
        private Label label3;
    }
}