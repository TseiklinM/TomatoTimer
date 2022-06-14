
namespace TomatoTimer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bSettings = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tBRound = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bResetInterval = new System.Windows.Forms.Button();
            this.bResetTimer = new System.Windows.Forms.Button();
            this.bNewTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSettings
            // 
            resources.ApplyResources(this.bSettings, "bSettings");
            this.bSettings.Name = "bSettings";
            this.bSettings.UseVisualStyleBackColor = true;
            // 
            // bStart
            // 
            resources.ApplyResources(this.bStart, "bStart");
            this.bStart.ForeColor = System.Drawing.SystemColors.Window;
            this.bStart.Name = "bStart";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // bPause
            // 
            resources.ApplyResources(this.bPause, "bPause");
            this.bPause.ForeColor = System.Drawing.SystemColors.Window;
            this.bPause.Name = "bPause";
            this.bPause.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCoral;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Name = "textBox1";
            // 
            // tBRound
            // 
            this.tBRound.BackColor = System.Drawing.Color.LightCoral;
            this.tBRound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tBRound, "tBRound");
            this.tBRound.ForeColor = System.Drawing.SystemColors.Window;
            this.tBRound.Name = "tBRound";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // bResetInterval
            // 
            resources.ApplyResources(this.bResetInterval, "bResetInterval");
            this.bResetInterval.ForeColor = System.Drawing.SystemColors.Window;
            this.bResetInterval.Name = "bResetInterval";
            this.bResetInterval.UseVisualStyleBackColor = true;
            // 
            // bResetTimer
            // 
            resources.ApplyResources(this.bResetTimer, "bResetTimer");
            this.bResetTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.bResetTimer.Name = "bResetTimer";
            this.bResetTimer.UseVisualStyleBackColor = true;
            // 
            // bNewTimer
            // 
            resources.ApplyResources(this.bNewTimer, "bNewTimer");
            this.bNewTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.bNewTimer.Name = "bNewTimer";
            this.bNewTimer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bNewTimer);
            this.Controls.Add(this.bResetTimer);
            this.Controls.Add(this.bResetInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBRound);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bPause);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tBRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bResetInterval;
        private System.Windows.Forms.Button bResetTimer;
        private System.Windows.Forms.Button bNewTimer;
    }
}

