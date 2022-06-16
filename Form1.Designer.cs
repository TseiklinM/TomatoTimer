
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
            this.bStart = new System.Windows.Forms.Button();
            this.tb_TimeRound = new System.Windows.Forms.TextBox();
            this.tBRound = new System.Windows.Forms.TextBox();
            this.btn_NewTim = new System.Windows.Forms.Button();
            this.btn_RestartTimer = new System.Windows.Forms.Button();
            this.btn_RestartInter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bStart
            // 
            resources.ApplyResources(this.bStart, "bStart");
            this.bStart.ForeColor = System.Drawing.SystemColors.Window;
            this.bStart.Name = "bStart";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tb_TimeRound
            // 
            this.tb_TimeRound.BackColor = System.Drawing.Color.LightCoral;
            this.tb_TimeRound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tb_TimeRound, "tb_TimeRound");
            this.tb_TimeRound.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_TimeRound.Name = "tb_TimeRound";
            // 
            // tBRound
            // 
            this.tBRound.BackColor = System.Drawing.Color.LightCoral;
            this.tBRound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tBRound, "tBRound");
            this.tBRound.ForeColor = System.Drawing.SystemColors.Window;
            this.tBRound.Name = "tBRound";
            // 
            // btn_NewTim
            // 
            resources.ApplyResources(this.btn_NewTim, "btn_NewTim");
            this.btn_NewTim.Name = "btn_NewTim";
            this.btn_NewTim.UseVisualStyleBackColor = true;
            this.btn_NewTim.Click += new System.EventHandler(this.btn_NewTim_Click);
            // 
            // btn_RestartTimer
            // 
            resources.ApplyResources(this.btn_RestartTimer, "btn_RestartTimer");
            this.btn_RestartTimer.Name = "btn_RestartTimer";
            this.btn_RestartTimer.UseVisualStyleBackColor = true;
            // 
            // btn_RestartInter
            // 
            resources.ApplyResources(this.btn_RestartInter, "btn_RestartInter");
            this.btn_RestartInter.Name = "btn_RestartInter";
            this.btn_RestartInter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btn_RestartInter);
            this.Controls.Add(this.btn_RestartTimer);
            this.Controls.Add(this.btn_NewTim);
            this.Controls.Add(this.tBRound);
            this.Controls.Add(this.tb_TimeRound);
            this.Controls.Add(this.bStart);
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
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tb_TimeRound;
        private System.Windows.Forms.TextBox tBRound;
        private System.Windows.Forms.Button btn_NewTim;
        private System.Windows.Forms.Button btn_RestartTimer;
        private System.Windows.Forms.Button btn_RestartInter;
    }
}

