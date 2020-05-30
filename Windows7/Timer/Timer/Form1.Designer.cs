namespace Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.txtTime3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnPlay3 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(22, 23);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.ReadOnly = true;
            this.txtTime1.Size = new System.Drawing.Size(178, 20);
            this.txtTime1.TabIndex = 6;
            this.txtTime1.Text = "00:00:00";
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(22, 88);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.ReadOnly = true;
            this.txtTime2.Size = new System.Drawing.Size(178, 20);
            this.txtTime2.TabIndex = 7;
            this.txtTime2.Text = "00:00:00";
            // 
            // txtTime3
            // 
            this.txtTime3.Location = new System.Drawing.Point(22, 153);
            this.txtTime3.Name = "txtTime3";
            this.txtTime3.ReadOnly = true;
            this.txtTime3.Size = new System.Drawing.Size(178, 20);
            this.txtTime3.TabIndex = 8;
            this.txtTime3.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnStop3
            // 
            this.btnStop3.BackgroundImage = global::Timer.Properties.Resources.Stop_48x48;
            this.btnStop3.Location = new System.Drawing.Point(287, 147);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(49, 50);
            this.btnStop3.TabIndex = 5;
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // btnPlay3
            // 
            this.btnPlay3.BackgroundImage = global::Timer.Properties.Resources.Play_48x48;
            this.btnPlay3.Location = new System.Drawing.Point(223, 147);
            this.btnPlay3.Name = "btnPlay3";
            this.btnPlay3.Size = new System.Drawing.Size(49, 50);
            this.btnPlay3.TabIndex = 4;
            this.btnPlay3.UseVisualStyleBackColor = true;
            this.btnPlay3.Click += new System.EventHandler(this.btnPlay3_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.BackgroundImage = global::Timer.Properties.Resources.Stop_48x48;
            this.btnStop2.Location = new System.Drawing.Point(287, 83);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(49, 50);
            this.btnStop2.TabIndex = 3;
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnPlay2
            // 
            this.btnPlay2.BackgroundImage = global::Timer.Properties.Resources.Play_48x48;
            this.btnPlay2.Location = new System.Drawing.Point(223, 83);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(49, 50);
            this.btnPlay2.TabIndex = 2;
            this.btnPlay2.UseVisualStyleBackColor = true;
            this.btnPlay2.Click += new System.EventHandler(this.btnPlay2_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.BackgroundImage = global::Timer.Properties.Resources.Stop_48x48;
            this.btnStop1.Location = new System.Drawing.Point(287, 20);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(49, 49);
            this.btnStop1.TabIndex = 1;
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.BackgroundImage = global::Timer.Properties.Resources.Play_48x48;
            this.btnPlay1.Location = new System.Drawing.Point(223, 19);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(49, 50);
            this.btnPlay1.TabIndex = 0;
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 216);
            this.Controls.Add(this.txtTime3);
            this.Controls.Add(this.txtTime2);
            this.Controls.Add(this.txtTime1);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnPlay3);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.btnPlay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 255);
            this.MinimumSize = new System.Drawing.Size(371, 255);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnPlay3;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.TextBox txtTime3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

