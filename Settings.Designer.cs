
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
            this.dataGV_ListInterval = new System.Windows.Forms.DataGridView();
            this.tb_NamInter = new System.Windows.Forms.TextBox();
            this.numUD_TimInter = new System.Windows.Forms.NumericUpDown();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ClearGrid = new System.Windows.Forms.Button();
            this.btn_CrTim = new System.Windows.Forms.Button();
            this.NameInter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ListInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_TimInter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_ListInterval
            // 
            this.dataGV_ListInterval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ListInterval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameInter,
            this.TimeNum});
            this.dataGV_ListInterval.Location = new System.Drawing.Point(12, 79);
            this.dataGV_ListInterval.Name = "dataGV_ListInterval";
            this.dataGV_ListInterval.RowHeadersWidth = 51;
            this.dataGV_ListInterval.RowTemplate.Height = 24;
            this.dataGV_ListInterval.Size = new System.Drawing.Size(324, 239);
            this.dataGV_ListInterval.TabIndex = 0;
            // 
            // tb_NamInter
            // 
            this.tb_NamInter.Location = new System.Drawing.Point(13, 30);
            this.tb_NamInter.Name = "tb_NamInter";
            this.tb_NamInter.Size = new System.Drawing.Size(170, 22);
            this.tb_NamInter.TabIndex = 1;
            this.tb_NamInter.TextChanged += new System.EventHandler(this.tb_NamInter_TextChanged);
            // 
            // numUD_TimInter
            // 
            this.numUD_TimInter.Location = new System.Drawing.Point(190, 29);
            this.numUD_TimInter.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUD_TimInter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUD_TimInter.Name = "numUD_TimInter";
            this.numUD_TimInter.Size = new System.Drawing.Size(64, 22);
            this.numUD_TimInter.TabIndex = 2;
            this.numUD_TimInter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUD_TimInter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(341, 28);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время";
            // 
            // btn_ClearGrid
            // 
            this.btn_ClearGrid.Enabled = false;
            this.btn_ClearGrid.Location = new System.Drawing.Point(342, 79);
            this.btn_ClearGrid.Name = "btn_ClearGrid";
            this.btn_ClearGrid.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearGrid.TabIndex = 6;
            this.btn_ClearGrid.Text = "Clear";
            this.btn_ClearGrid.UseVisualStyleBackColor = true;
            this.btn_ClearGrid.Click += new System.EventHandler(this.btn_ClearGrid_Click);
            // 
            // btn_CrTim
            // 
            this.btn_CrTim.Enabled = false;
            this.btn_CrTim.Location = new System.Drawing.Point(13, 334);
            this.btn_CrTim.Name = "btn_CrTim";
            this.btn_CrTim.Size = new System.Drawing.Size(323, 23);
            this.btn_CrTim.TabIndex = 7;
            this.btn_CrTim.Text = "Create Timer";
            this.btn_CrTim.UseVisualStyleBackColor = true;
            this.btn_CrTim.Click += new System.EventHandler(this.btn_CrTim_Click);
            // 
            // NameInter
            // 
            this.NameInter.HeaderText = "Название";
            this.NameInter.MinimumWidth = 6;
            this.NameInter.Name = "NameInter";
            this.NameInter.ReadOnly = true;
            this.NameInter.Width = 125;
            // 
            // TimeNum
            // 
            this.TimeNum.HeaderText = "Время(мин.)";
            this.TimeNum.MinimumWidth = 6;
            this.TimeNum.Name = "TimeNum";
            this.TimeNum.ReadOnly = true;
            this.TimeNum.Width = 125;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 369);
            this.Controls.Add(this.btn_CrTim);
            this.Controls.Add(this.btn_ClearGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.numUD_TimInter);
            this.Controls.Add(this.tb_NamInter);
            this.Controls.Add(this.dataGV_ListInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 420);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ListInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_TimInter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_ListInterval;
        private System.Windows.Forms.TextBox tb_NamInter;
        private System.Windows.Forms.NumericUpDown numUD_TimInter;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ClearGrid;
        private System.Windows.Forms.Button btn_CrTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameInter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeNum;
    }
}