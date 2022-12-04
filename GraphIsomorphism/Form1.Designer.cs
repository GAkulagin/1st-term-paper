namespace GraphIsomorphism
{
    partial class mainForm
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
            this.createGraphBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.graphsNUD = new System.Windows.Forms.NumericUpDown();
            this.moreInfoBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenResearchFormBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edgesInputNUD = new System.Windows.Forms.NumericUpDown();
            this.nodesInputNUD = new System.Windows.Forms.NumericUpDown();
            this.edgesLimitLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.GraphsCreatedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgesInputNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesInputNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // createGraphBtn
            // 
            this.createGraphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createGraphBtn.Location = new System.Drawing.Point(35, 59);
            this.createGraphBtn.Name = "createGraphBtn";
            this.createGraphBtn.Size = new System.Drawing.Size(147, 30);
            this.createGraphBtn.TabIndex = 0;
            this.createGraphBtn.Text = "Создать";
            this.createGraphBtn.UseVisualStyleBackColor = true;
            this.createGraphBtn.Click += new System.EventHandler(this.createGraphBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создание графа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество графов:";
            // 
            // graphsNUD
            // 
            this.graphsNUD.Location = new System.Drawing.Point(159, 112);
            this.graphsNUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.graphsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graphsNUD.Name = "graphsNUD";
            this.graphsNUD.Size = new System.Drawing.Size(72, 22);
            this.graphsNUD.TabIndex = 3;
            this.graphsNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // moreInfoBtn
            // 
            this.moreInfoBtn.Location = new System.Drawing.Point(283, 59);
            this.moreInfoBtn.Name = "moreInfoBtn";
            this.moreInfoBtn.Size = new System.Drawing.Size(138, 30);
            this.moreInfoBtn.TabIndex = 8;
            this.moreInfoBtn.Text = "Меню просмотра";
            this.moreInfoBtn.UseVisualStyleBackColor = true;
            this.moreInfoBtn.Click += new System.EventHandler(this.moreInfoBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(488, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Исследование";
            // 
            // OpenResearchFormBtn
            // 
            this.OpenResearchFormBtn.Location = new System.Drawing.Point(493, 59);
            this.OpenResearchFormBtn.Name = "OpenResearchFormBtn";
            this.OpenResearchFormBtn.Size = new System.Drawing.Size(177, 30);
            this.OpenResearchFormBtn.TabIndex = 10;
            this.OpenResearchFormBtn.Text = "Меню исследования";
            this.OpenResearchFormBtn.UseVisualStyleBackColor = true;
            this.OpenResearchFormBtn.Click += new System.EventHandler(this.OpenResearchFormBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(254, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Просмотр графа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дополнительные параметры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Число ребер:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Число вершин:";
            // 
            // edgesInputNUD
            // 
            this.edgesInputNUD.Location = new System.Drawing.Point(159, 216);
            this.edgesInputNUD.Maximum = new decimal(new int[] {
            190,
            0,
            0,
            0});
            this.edgesInputNUD.Name = "edgesInputNUD";
            this.edgesInputNUD.Size = new System.Drawing.Size(72, 22);
            this.edgesInputNUD.TabIndex = 17;
            // 
            // nodesInputNUD
            // 
            this.nodesInputNUD.BackColor = System.Drawing.SystemColors.Window;
            this.nodesInputNUD.Location = new System.Drawing.Point(159, 178);
            this.nodesInputNUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nodesInputNUD.Name = "nodesInputNUD";
            this.nodesInputNUD.Size = new System.Drawing.Size(72, 22);
            this.nodesInputNUD.TabIndex = 18;
            this.nodesInputNUD.ValueChanged += new System.EventHandler(this.nodesInputNUD_ValueChanged);
            // 
            // edgesLimitLabel
            // 
            this.edgesLimitLabel.AutoSize = true;
            this.edgesLimitLabel.Location = new System.Drawing.Point(256, 216);
            this.edgesLimitLabel.Name = "edgesLimitLabel";
            this.edgesLimitLabel.Size = new System.Drawing.Size(0, 17);
            this.edgesLimitLabel.TabIndex = 19;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(28, 256);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(203, 23);
            this.ProgressBar.TabIndex = 20;
            this.ProgressBar.Visible = false;
            // 
            // GraphsCreatedLabel
            // 
            this.GraphsCreatedLabel.AutoSize = true;
            this.GraphsCreatedLabel.Location = new System.Drawing.Point(14, 256);
            this.GraphsCreatedLabel.Name = "GraphsCreatedLabel";
            this.GraphsCreatedLabel.Size = new System.Drawing.Size(0, 17);
            this.GraphsCreatedLabel.TabIndex = 21;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 302);
            this.Controls.Add(this.GraphsCreatedLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.edgesLimitLabel);
            this.Controls.Add(this.nodesInputNUD);
            this.Controls.Add(this.edgesInputNUD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenResearchFormBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.moreInfoBtn);
            this.Controls.Add(this.graphsNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createGraphBtn);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.graphsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgesInputNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesInputNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createGraphBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown graphsNUD;
        private System.Windows.Forms.Button moreInfoBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OpenResearchFormBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown edgesInputNUD;
        private System.Windows.Forms.NumericUpDown nodesInputNUD;
        private System.Windows.Forms.Label edgesLimitLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label GraphsCreatedLabel;
    }
}

