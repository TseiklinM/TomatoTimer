
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
            this.NameInter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_NamInter = new System.Windows.Forms.TextBox();
            this.numUD_TimInter = new System.Windows.Forms.NumericUpDown();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ClearGrid = new System.Windows.Forms.Button();
            this.btn_CrTim = new System.Windows.Forms.Button();
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
            this.dataGV_ListInterval.Location = new System.Drawing.Point(9, 64);
            this.dataGV_ListInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGV_ListInterval.Name = "dataGV_ListInterval";
            this.dataGV_ListInterval.RowHeadersWidth = 51;
            this.dataGV_ListInterval.RowTemplate.Height = 24;
            this.dataGV_ListInterval.Size = new System.Drawing.Size(243, 194);
            this.dataGV_ListInterval.TabIndex = 0;
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
            // tb_NamInter
            // 
            this.tb_NamInter.Location = new System.Drawing.Point(10, 24);
            this.tb_NamInter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_NamInter.Name = "tb_NamInter";
            this.tb_NamInter.Size = new System.Drawing.Size(128, 20);
            this.tb_NamInter.TabIndex = 1;
            this.tb_NamInter.TextChanged += new System.EventHandler(this.tb_NamInter_TextChanged);
            // 
            // numUD_TimInter
            // 
            this.numUD_TimInter.Location = new System.Drawing.Point(142, 24);
            this.numUD_TimInter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.numUD_TimInter.Size = new System.Drawing.Size(48, 20);
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
            this.btn_Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Add.Enabled = false;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Add.Location = new System.Drawing.Point(256, 11);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(55, 50);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время";
            // 
            // btn_ClearGrid
            // 
            this.btn_ClearGrid.BackColor = System.Drawing.Color.Red;
            this.btn_ClearGrid.Enabled = false;
            this.btn_ClearGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ClearGrid.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ClearGrid.Location = new System.Drawing.Point(256, 64);
            this.btn_ClearGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ClearGrid.Name = "btn_ClearGrid";
            this.btn_ClearGrid.Size = new System.Drawing.Size(55, 50);
            this.btn_ClearGrid.TabIndex = 6;
            this.btn_ClearGrid.Text = "Clear";
            this.btn_ClearGrid.UseVisualStyleBackColor = false;
            this.btn_ClearGrid.Click += new System.EventHandler(this.btn_ClearGrid_Click);
            // 
            // btn_CrTim
            // 
            this.btn_CrTim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_CrTim.Enabled = false;
            this.btn_CrTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CrTim.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_CrTim.Location = new System.Drawing.Point(9, 262);
            this.btn_CrTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CrTim.Name = "btn_CrTim";
            this.btn_CrTim.Size = new System.Drawing.Size(302, 33);
            this.btn_CrTim.TabIndex = 7;
            this.btn_CrTim.Text = "Create Timer";
            this.btn_CrTim.UseVisualStyleBackColor = false;
            this.btn_CrTim.Click += new System.EventHandler(this.btn_CrTim_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(322, 306);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 349);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(342, 349);
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