
namespace TomatoTimer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tBarWorkTime = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tBarShortBreak = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tBarLongBreak = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.rBSound = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBarIntervalRounds = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tBarWorkTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarShortBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarLongBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarIntervalRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // tBarWorkTime
            // 
            this.tBarWorkTime.AutoSize = false;
            this.tBarWorkTime.LargeChange = 10;
            this.tBarWorkTime.Location = new System.Drawing.Point(15, 34);
            this.tBarWorkTime.Maximum = 60;
            this.tBarWorkTime.Minimum = 10;
            this.tBarWorkTime.Name = "tBarWorkTime";
            this.tBarWorkTime.Size = new System.Drawing.Size(295, 45);
            this.tBarWorkTime.TabIndex = 0;
            this.tBarWorkTime.TickFrequency = 5;
            this.tBarWorkTime.Value = 25;
            this.tBarWorkTime.Scroll += new System.EventHandler(this.tBarWorkTime_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рабочий тайминг";
            // 
            // tBarShortBreak
            // 
            this.tBarShortBreak.AutoSize = false;
            this.tBarShortBreak.LargeChange = 1;
            this.tBarShortBreak.Location = new System.Drawing.Point(15, 98);
            this.tBarShortBreak.Maximum = 7;
            this.tBarShortBreak.Minimum = 3;
            this.tBarShortBreak.Name = "tBarShortBreak";
            this.tBarShortBreak.Size = new System.Drawing.Size(295, 45);
            this.tBarShortBreak.TabIndex = 1;
            this.tBarShortBreak.Value = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Короткий перерыв";
            // 
            // tBarLongBreak
            // 
            this.tBarLongBreak.AutoSize = false;
            this.tBarLongBreak.Location = new System.Drawing.Point(12, 162);
            this.tBarLongBreak.Maximum = 45;
            this.tBarLongBreak.Minimum = 10;
            this.tBarLongBreak.Name = "tBarLongBreak";
            this.tBarLongBreak.Size = new System.Drawing.Size(295, 45);
            this.tBarLongBreak.TabIndex = 4;
            this.tBarLongBreak.TickFrequency = 5;
            this.tBarLongBreak.Value = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Звук";
            // 
            // rBSound
            // 
            this.rBSound.AutoSize = true;
            this.rBSound.Location = new System.Drawing.Point(49, 260);
            this.rBSound.Name = "rBSound";
            this.rBSound.Size = new System.Drawing.Size(14, 13);
            this.rBSound.TabIndex = 6;
            this.rBSound.TabStop = true;
            this.rBSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBSound.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Большой перерыв";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Интервал раундов";
            // 
            // tBarIntervalRounds
            // 
            this.tBarIntervalRounds.AutoSize = false;
            this.tBarIntervalRounds.LargeChange = 2;
            this.tBarIntervalRounds.Location = new System.Drawing.Point(12, 213);
            this.tBarIntervalRounds.Maximum = 16;
            this.tBarIntervalRounds.Minimum = 4;
            this.tBarIntervalRounds.Name = "tBarIntervalRounds";
            this.tBarIntervalRounds.Size = new System.Drawing.Size(295, 45);
            this.tBarIntervalRounds.SmallChange = 2;
            this.tBarIntervalRounds.TabIndex = 8;
            this.tBarIntervalRounds.TickFrequency = 2;
            this.tBarIntervalRounds.Value = 8;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 297);
            this.Controls.Add(this.tBarIntervalRounds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rBSound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBarLongBreak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBarShortBreak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBarWorkTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.tBarWorkTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarShortBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarLongBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarIntervalRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tBarWorkTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tBarShortBreak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tBarLongBreak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBSound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tBarIntervalRounds;
    }
}