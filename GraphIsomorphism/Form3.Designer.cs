namespace GraphIsomorphism
{
    partial class ExtendedInfoForm
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
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.matrixTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstVectorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.secondVectorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.determinantLabel = new System.Windows.Forms.Label();
            this.nodesLabel = new System.Windows.Forms.Label();
            this.edgesLabel = new System.Windows.Forms.Label();
            this.wienerLabel = new System.Windows.Forms.Label();
            this.randicLabel = new System.Windows.Forms.Label();
            this.DensityLabel = new System.Windows.Forms.Label();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.ComponentsLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CycleNuberLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.Location = new System.Drawing.Point(372, 11);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 29);
            this.FileNameLabel.TabIndex = 0;
            // 
            // matrixTextBox
            // 
            this.matrixTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.matrixTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrixTextBox.Location = new System.Drawing.Point(13, 79);
            this.matrixTextBox.Name = "matrixTextBox";
            this.matrixTextBox.ReadOnly = true;
            this.matrixTextBox.Size = new System.Drawing.Size(355, 321);
            this.matrixTextBox.TabIndex = 1;
            this.matrixTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Матрица смежности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вектор степеней вершин первого порядка";
            // 
            // firstVectorTextBox
            // 
            this.firstVectorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstVectorTextBox.Location = new System.Drawing.Point(377, 378);
            this.firstVectorTextBox.Name = "firstVectorTextBox";
            this.firstVectorTextBox.ReadOnly = true;
            this.firstVectorTextBox.Size = new System.Drawing.Size(398, 22);
            this.firstVectorTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вектор степеней вершин второго порядка";
            // 
            // secondVectorTextBox
            // 
            this.secondVectorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.secondVectorTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondVectorTextBox.Location = new System.Drawing.Point(832, 82);
            this.secondVectorTextBox.Multiline = true;
            this.secondVectorTextBox.Name = "secondVectorTextBox";
            this.secondVectorTextBox.ReadOnly = true;
            this.secondVectorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.secondVectorTextBox.Size = new System.Drawing.Size(327, 318);
            this.secondVectorTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Число вершин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Число ребер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Индекс Винера";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Индекс Рандича";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Определитель матрицы смежности";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Плотность графа";
            // 
            // determinantLabel
            // 
            this.determinantLabel.AutoSize = true;
            this.determinantLabel.Location = new System.Drawing.Point(634, 215);
            this.determinantLabel.Name = "determinantLabel";
            this.determinantLabel.Size = new System.Drawing.Size(0, 17);
            this.determinantLabel.TabIndex = 13;
            // 
            // nodesLabel
            // 
            this.nodesLabel.AutoSize = true;
            this.nodesLabel.Location = new System.Drawing.Point(634, 82);
            this.nodesLabel.Name = "nodesLabel";
            this.nodesLabel.Size = new System.Drawing.Size(0, 17);
            this.nodesLabel.TabIndex = 15;
            // 
            // edgesLabel
            // 
            this.edgesLabel.AutoSize = true;
            this.edgesLabel.Location = new System.Drawing.Point(634, 117);
            this.edgesLabel.Name = "edgesLabel";
            this.edgesLabel.Size = new System.Drawing.Size(0, 17);
            this.edgesLabel.TabIndex = 16;
            // 
            // wienerLabel
            // 
            this.wienerLabel.AutoSize = true;
            this.wienerLabel.Location = new System.Drawing.Point(634, 149);
            this.wienerLabel.Name = "wienerLabel";
            this.wienerLabel.Size = new System.Drawing.Size(0, 17);
            this.wienerLabel.TabIndex = 17;
            // 
            // randicLabel
            // 
            this.randicLabel.AutoSize = true;
            this.randicLabel.Location = new System.Drawing.Point(634, 185);
            this.randicLabel.Name = "randicLabel";
            this.randicLabel.Size = new System.Drawing.Size(0, 17);
            this.randicLabel.TabIndex = 18;
            // 
            // DensityLabel
            // 
            this.DensityLabel.AutoSize = true;
            this.DensityLabel.Location = new System.Drawing.Point(634, 248);
            this.DensityLabel.Name = "DensityLabel";
            this.DensityLabel.Size = new System.Drawing.Size(0, 17);
            this.DensityLabel.TabIndex = 19;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(17, 11);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(161, 33);
            this.OpenFileBtn.TabIndex = 20;
            this.OpenFileBtn.Text = "Выбрать файл";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Число компонент связности";
            // 
            // ComponentsLabel
            // 
            this.ComponentsLabel.AutoSize = true;
            this.ComponentsLabel.Location = new System.Drawing.Point(634, 278);
            this.ComponentsLabel.Name = "ComponentsLabel";
            this.ComponentsLabel.Size = new System.Drawing.Size(0, 17);
            this.ComponentsLabel.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Цикломатическое число";
            // 
            // CycleNuberLabel
            // 
            this.CycleNuberLabel.AutoSize = true;
            this.CycleNuberLabel.Location = new System.Drawing.Point(634, 312);
            this.CycleNuberLabel.Name = "CycleNuberLabel";
            this.CycleNuberLabel.Size = new System.Drawing.Size(0, 17);
            this.CycleNuberLabel.TabIndex = 24;
            // 
            // ExtendedInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 411);
            this.Controls.Add(this.CycleNuberLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ComponentsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.DensityLabel);
            this.Controls.Add(this.randicLabel);
            this.Controls.Add(this.wienerLabel);
            this.Controls.Add(this.edgesLabel);
            this.Controls.Add(this.nodesLabel);
            this.Controls.Add(this.determinantLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secondVectorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstVectorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrixTextBox);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "ExtendedInfoForm";
            this.Text = "Подробная информация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.RichTextBox matrixTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstVectorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secondVectorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label determinantLabel;
        private System.Windows.Forms.Label nodesLabel;
        private System.Windows.Forms.Label edgesLabel;
        private System.Windows.Forms.Label wienerLabel;
        private System.Windows.Forms.Label randicLabel;
        private System.Windows.Forms.Label DensityLabel;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ComponentsLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CycleNuberLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}