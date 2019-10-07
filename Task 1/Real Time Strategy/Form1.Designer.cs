namespace Real_Time_Strategy
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
            this.components = new System.ComponentModel.Container();
            this.MapDisp = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UnitInfo = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MapDisp
            // 
            this.MapDisp.Location = new System.Drawing.Point(9, 12);
            this.MapDisp.Name = "MapDisp";
            this.MapDisp.Size = new System.Drawing.Size(406, 295);
            this.MapDisp.TabIndex = 0;
            this.MapDisp.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // UnitInfo
            // 
            this.UnitInfo.Location = new System.Drawing.Point(587, 86);
            this.UnitInfo.Margin = new System.Windows.Forms.Padding(4);
            this.UnitInfo.Multiline = true;
            this.UnitInfo.Name = "UnitInfo";
            this.UnitInfo.Size = new System.Drawing.Size(200, 351);
            this.UnitInfo.TabIndex = 3;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(648, 56);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(648, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(342, 324);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(54, 17);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "Round:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.UnitInfo);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.MapDisp);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "GameArea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MapDisp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox UnitInfo;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRound;
    }
}

