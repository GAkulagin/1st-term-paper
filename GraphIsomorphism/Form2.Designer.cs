namespace GraphIsomorphism
{
    partial class ResearchForm
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
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BeginBtn = new System.Windows.Forms.Button();
            this.MatrixTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.StatsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveStatsBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.WienerIndexCheckBox = new System.Windows.Forms.CheckBox();
            this.RandicIndexCheckBox = new System.Windows.Forms.CheckBox();
            this.ComponentsCheckBox = new System.Windows.Forms.CheckBox();
            this.DensityCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstVectorCheckBox = new System.Windows.Forms.CheckBox();
            this.SecondVectorCheckBox = new System.Windows.Forms.CheckBox();
            this.DeterminantCheckBox = new System.Windows.Forms.CheckBox();
            this.CyclomaticNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.UncheckAllBtn = new System.Windows.Forms.Button();
            this.CheckAllBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(12, 51);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(133, 28);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "Открыть файл";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.UseWaitCursor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрать граф для сравнения";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбрать инвариант";
            this.label2.UseWaitCursor = true;
            // 
            // BeginBtn
            // 
            this.BeginBtn.Enabled = false;
            this.BeginBtn.Location = new System.Drawing.Point(1086, 115);
            this.BeginBtn.Name = "BeginBtn";
            this.BeginBtn.Size = new System.Drawing.Size(133, 38);
            this.BeginBtn.TabIndex = 11;
            this.BeginBtn.Text = "Начать";
            this.BeginBtn.UseVisualStyleBackColor = true;
            this.BeginBtn.UseWaitCursor = true;
            this.BeginBtn.Click += new System.EventHandler(this.BeginBtn_Click);
            // 
            // MatrixTextBox
            // 
            this.MatrixTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MatrixTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixTextBox.Location = new System.Drawing.Point(12, 181);
            this.MatrixTextBox.Multiline = true;
            this.MatrixTextBox.Name = "MatrixTextBox";
            this.MatrixTextBox.ReadOnly = true;
            this.MatrixTextBox.Size = new System.Drawing.Size(339, 294);
            this.MatrixTextBox.TabIndex = 14;
            this.MatrixTextBox.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Матрица смежности:";
            this.label3.UseWaitCursor = true;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 100);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 17);
            this.FileNameLabel.TabIndex = 16;
            this.FileNameLabel.UseWaitCursor = true;
            // 
            // StatsTextBox
            // 
            this.StatsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.StatsTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatsTextBox.Location = new System.Drawing.Point(378, 232);
            this.StatsTextBox.Multiline = true;
            this.StatsTextBox.Name = "StatsTextBox";
            this.StatsTextBox.ReadOnly = true;
            this.StatsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatsTextBox.Size = new System.Drawing.Size(840, 243);
            this.StatsTextBox.TabIndex = 17;
            this.StatsTextBox.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Окно статистики";
            this.label4.UseWaitCursor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // SaveStatsBtn
            // 
            this.SaveStatsBtn.Location = new System.Drawing.Point(1006, 484);
            this.SaveStatsBtn.Name = "SaveStatsBtn";
            this.SaveStatsBtn.Size = new System.Drawing.Size(184, 26);
            this.SaveStatsBtn.TabIndex = 20;
            this.SaveStatsBtn.Text = "Сохранить результаты";
            this.SaveStatsBtn.UseVisualStyleBackColor = true;
            this.SaveStatsBtn.UseWaitCursor = true;
            this.SaveStatsBtn.Click += new System.EventHandler(this.SaveStatsBtn_Click);
            // 
            // WienerIndexCheckBox
            // 
            this.WienerIndexCheckBox.AutoSize = true;
            this.WienerIndexCheckBox.Location = new System.Drawing.Point(365, 51);
            this.WienerIndexCheckBox.Name = "WienerIndexCheckBox";
            this.WienerIndexCheckBox.Size = new System.Drawing.Size(131, 21);
            this.WienerIndexCheckBox.TabIndex = 21;
            this.WienerIndexCheckBox.Text = "Индекс Винера";
            this.WienerIndexCheckBox.UseVisualStyleBackColor = true;
            this.WienerIndexCheckBox.UseWaitCursor = true;
            // 
            // RandicIndexCheckBox
            // 
            this.RandicIndexCheckBox.AutoSize = true;
            this.RandicIndexCheckBox.Location = new System.Drawing.Point(365, 78);
            this.RandicIndexCheckBox.Name = "RandicIndexCheckBox";
            this.RandicIndexCheckBox.Size = new System.Drawing.Size(139, 21);
            this.RandicIndexCheckBox.TabIndex = 22;
            this.RandicIndexCheckBox.Text = "Индекс Рандича";
            this.RandicIndexCheckBox.UseVisualStyleBackColor = true;
            this.RandicIndexCheckBox.UseWaitCursor = true;
            // 
            // ComponentsCheckBox
            // 
            this.ComponentsCheckBox.AutoSize = true;
            this.ComponentsCheckBox.Location = new System.Drawing.Point(365, 106);
            this.ComponentsCheckBox.Name = "ComponentsCheckBox";
            this.ComponentsCheckBox.Size = new System.Drawing.Size(217, 21);
            this.ComponentsCheckBox.TabIndex = 23;
            this.ComponentsCheckBox.Text = "Число компонент связности";
            this.ComponentsCheckBox.UseVisualStyleBackColor = true;
            this.ComponentsCheckBox.UseWaitCursor = true;
            // 
            // DensityCheckBox
            // 
            this.DensityCheckBox.AutoSize = true;
            this.DensityCheckBox.Location = new System.Drawing.Point(365, 133);
            this.DensityCheckBox.Name = "DensityCheckBox";
            this.DensityCheckBox.Size = new System.Drawing.Size(144, 21);
            this.DensityCheckBox.TabIndex = 24;
            this.DensityCheckBox.Text = "Плотность графа";
            this.DensityCheckBox.UseVisualStyleBackColor = true;
            this.DensityCheckBox.UseWaitCursor = true;
            // 
            // FirstVectorCheckBox
            // 
            this.FirstVectorCheckBox.AutoSize = true;
            this.FirstVectorCheckBox.Location = new System.Drawing.Point(597, 51);
            this.FirstVectorCheckBox.Name = "FirstVectorCheckBox";
            this.FirstVectorCheckBox.Size = new System.Drawing.Size(367, 21);
            this.FirstVectorCheckBox.TabIndex = 25;
            this.FirstVectorCheckBox.Text = "Упорядоченный вектор степеней первого порядка";
            this.FirstVectorCheckBox.UseVisualStyleBackColor = true;
            this.FirstVectorCheckBox.UseWaitCursor = true;
            // 
            // SecondVectorCheckBox
            // 
            this.SecondVectorCheckBox.AutoSize = true;
            this.SecondVectorCheckBox.Location = new System.Drawing.Point(597, 78);
            this.SecondVectorCheckBox.Name = "SecondVectorCheckBox";
            this.SecondVectorCheckBox.Size = new System.Drawing.Size(366, 21);
            this.SecondVectorCheckBox.TabIndex = 26;
            this.SecondVectorCheckBox.Text = "Упорядоченный вектор степеней второго порядка";
            this.SecondVectorCheckBox.UseVisualStyleBackColor = true;
            this.SecondVectorCheckBox.UseWaitCursor = true;
            // 
            // DeterminantCheckBox
            // 
            this.DeterminantCheckBox.AutoSize = true;
            this.DeterminantCheckBox.Location = new System.Drawing.Point(597, 105);
            this.DeterminantCheckBox.Name = "DeterminantCheckBox";
            this.DeterminantCheckBox.Size = new System.Drawing.Size(264, 21);
            this.DeterminantCheckBox.TabIndex = 27;
            this.DeterminantCheckBox.Text = "Определитель матрицы смежности";
            this.DeterminantCheckBox.UseVisualStyleBackColor = true;
            this.DeterminantCheckBox.UseWaitCursor = true;
            // 
            // CyclomaticNumberCheckBox
            // 
            this.CyclomaticNumberCheckBox.AutoSize = true;
            this.CyclomaticNumberCheckBox.Location = new System.Drawing.Point(597, 133);
            this.CyclomaticNumberCheckBox.Name = "CyclomaticNumberCheckBox";
            this.CyclomaticNumberCheckBox.Size = new System.Drawing.Size(193, 21);
            this.CyclomaticNumberCheckBox.TabIndex = 28;
            this.CyclomaticNumberCheckBox.Text = "Цикломатическое число";
            this.CyclomaticNumberCheckBox.UseVisualStyleBackColor = true;
            this.CyclomaticNumberCheckBox.UseWaitCursor = true;
            // 
            // UncheckAllBtn
            // 
            this.UncheckAllBtn.Location = new System.Drawing.Point(1086, 54);
            this.UncheckAllBtn.Name = "UncheckAllBtn";
            this.UncheckAllBtn.Size = new System.Drawing.Size(133, 28);
            this.UncheckAllBtn.TabIndex = 29;
            this.UncheckAllBtn.Text = "Снять все";
            this.UncheckAllBtn.UseVisualStyleBackColor = true;
            this.UncheckAllBtn.UseWaitCursor = true;
            this.UncheckAllBtn.Click += new System.EventHandler(this.UncheckAllBtn_Click);
            // 
            // CheckAllBtn
            // 
            this.CheckAllBtn.Location = new System.Drawing.Point(1086, 20);
            this.CheckAllBtn.Name = "CheckAllBtn";
            this.CheckAllBtn.Size = new System.Drawing.Size(133, 28);
            this.CheckAllBtn.TabIndex = 30;
            this.CheckAllBtn.Text = "Выделить все";
            this.CheckAllBtn.UseVisualStyleBackColor = true;
            this.CheckAllBtn.UseWaitCursor = true;
            this.CheckAllBtn.Click += new System.EventHandler(this.CheckAllBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(836, 484);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(164, 26);
            this.ClearBtn.TabIndex = 31;
            this.ClearBtn.Text = "Очистить статистику";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.UseWaitCursor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ResearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 522);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CheckAllBtn);
            this.Controls.Add(this.UncheckAllBtn);
            this.Controls.Add(this.CyclomaticNumberCheckBox);
            this.Controls.Add(this.DeterminantCheckBox);
            this.Controls.Add(this.SecondVectorCheckBox);
            this.Controls.Add(this.FirstVectorCheckBox);
            this.Controls.Add(this.DensityCheckBox);
            this.Controls.Add(this.ComponentsCheckBox);
            this.Controls.Add(this.RandicIndexCheckBox);
            this.Controls.Add(this.WienerIndexCheckBox);
            this.Controls.Add(this.SaveStatsBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StatsTextBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MatrixTextBox);
            this.Controls.Add(this.BeginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFileBtn);
            this.MaximizeBox = false;
            this.Name = "ResearchForm";
            this.Text = "Меню исследованя";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BeginBtn;
        private System.Windows.Forms.TextBox MatrixTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox StatsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button SaveStatsBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox WienerIndexCheckBox;
        private System.Windows.Forms.CheckBox RandicIndexCheckBox;
        private System.Windows.Forms.CheckBox ComponentsCheckBox;
        private System.Windows.Forms.CheckBox DensityCheckBox;
        private System.Windows.Forms.CheckBox FirstVectorCheckBox;
        private System.Windows.Forms.CheckBox SecondVectorCheckBox;
        private System.Windows.Forms.CheckBox DeterminantCheckBox;
        private System.Windows.Forms.CheckBox CyclomaticNumberCheckBox;
        private System.Windows.Forms.Button UncheckAllBtn;
        private System.Windows.Forms.Button CheckAllBtn;
        private System.Windows.Forms.Button ClearBtn;
    }
}