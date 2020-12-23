namespace Block_5
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
            this.lbDivide2 = new System.Windows.Forms.Label();
            this.lbInterval1 = new System.Windows.Forms.Label();
            this.lbY0 = new System.Windows.Forms.Label();
            this.lbDivide1 = new System.Windows.Forms.Label();
            this.tbPoints = new System.Windows.Forms.TextBox();
            this.tbIntervalB = new System.Windows.Forms.TextBox();
            this.tbY0 = new System.Windows.Forms.TextBox();
            this.tbIntervalA = new System.Windows.Forms.TextBox();
            this.pbRungeKutt = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.pbEilerPlus = new System.Windows.Forms.Button();
            this.pbEiler = new System.Windows.Forms.Button();
            this.lbInterval2 = new System.Windows.Forms.Label();
            this.lbInterval3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDivide2
            // 
            this.lbDivide2.AutoSize = true;
            this.lbDivide2.Location = new System.Drawing.Point(112, 70);
            this.lbDivide2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDivide2.Name = "lbDivide2";
            this.lbDivide2.Size = new System.Drawing.Size(35, 13);
            this.lbDivide2.TabIndex = 11;
            this.lbDivide2.Text = "точек";
            // 
            // lbInterval1
            // 
            this.lbInterval1.AutoSize = true;
            this.lbInterval1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInterval1.Location = new System.Drawing.Point(11, 9);
            this.lbInterval1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInterval1.Name = "lbInterval1";
            this.lbInterval1.Size = new System.Drawing.Size(59, 13);
            this.lbInterval1.TabIndex = 8;
            this.lbInterval1.Text = "Интервал:";
            // 
            // lbY0
            // 
            this.lbY0.AutoSize = true;
            this.lbY0.Location = new System.Drawing.Point(11, 38);
            this.lbY0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbY0.Name = "lbY0";
            this.lbY0.Size = new System.Drawing.Size(20, 13);
            this.lbY0.TabIndex = 13;
            this.lbY0.Text = "Y0";
            // 
            // lbDivide1
            // 
            this.lbDivide1.AutoSize = true;
            this.lbDivide1.Location = new System.Drawing.Point(11, 70);
            this.lbDivide1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDivide1.Name = "lbDivide1";
            this.lbDivide1.Size = new System.Drawing.Size(65, 13);
            this.lbDivide1.TabIndex = 10;
            this.lbDivide1.Text = "Разбиение:";
            // 
            // tbPoints
            // 
            this.tbPoints.Location = new System.Drawing.Point(80, 67);
            this.tbPoints.Margin = new System.Windows.Forms.Padding(2);
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.Size = new System.Drawing.Size(28, 20);
            this.tbPoints.TabIndex = 7;
            // 
            // tbIntervalB
            // 
            this.tbIntervalB.Location = new System.Drawing.Point(151, 6);
            this.tbIntervalB.Margin = new System.Windows.Forms.Padding(2);
            this.tbIntervalB.Name = "tbIntervalB";
            this.tbIntervalB.Size = new System.Drawing.Size(28, 20);
            this.tbIntervalB.TabIndex = 1;
            // 
            // tbY0
            // 
            this.tbY0.Location = new System.Drawing.Point(35, 35);
            this.tbY0.Margin = new System.Windows.Forms.Padding(2);
            this.tbY0.Name = "tbY0";
            this.tbY0.Size = new System.Drawing.Size(28, 20);
            this.tbY0.TabIndex = 12;
            // 
            // tbIntervalA
            // 
            this.tbIntervalA.Location = new System.Drawing.Point(93, 6);
            this.tbIntervalA.Margin = new System.Windows.Forms.Padding(2);
            this.tbIntervalA.Name = "tbIntervalA";
            this.tbIntervalA.Size = new System.Drawing.Size(28, 20);
            this.tbIntervalA.TabIndex = 5;
            // 
            // pbRungeKutt
            // 
            this.pbRungeKutt.Location = new System.Drawing.Point(11, 167);
            this.pbRungeKutt.Margin = new System.Windows.Forms.Padding(2);
            this.pbRungeKutt.Name = "pbRungeKutt";
            this.pbRungeKutt.Size = new System.Drawing.Size(75, 26);
            this.pbRungeKutt.TabIndex = 17;
            this.pbRungeKutt.Text = "Рунге–Кутт";
            this.pbRungeKutt.UseVisualStyleBackColor = true;
            this.pbRungeKutt.Click += new System.EventHandler(this.pbRungeKutt_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvResult.Location = new System.Drawing.Point(183, 11);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidth = 10;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResult.Size = new System.Drawing.Size(188, 293);
            this.dgvResult.TabIndex = 18;
            this.dgvResult.TabStop = false;
            // 
            // pbEilerPlus
            // 
            this.pbEilerPlus.Location = new System.Drawing.Point(90, 137);
            this.pbEilerPlus.Margin = new System.Windows.Forms.Padding(2);
            this.pbEilerPlus.Name = "pbEilerPlus";
            this.pbEilerPlus.Size = new System.Drawing.Size(75, 26);
            this.pbEilerPlus.TabIndex = 16;
            this.pbEilerPlus.Text = "Эйлер +";
            this.pbEilerPlus.UseVisualStyleBackColor = true;
            this.pbEilerPlus.Click += new System.EventHandler(this.pbEilerPlus_Click);
            // 
            // pbEiler
            // 
            this.pbEiler.Location = new System.Drawing.Point(11, 137);
            this.pbEiler.Margin = new System.Windows.Forms.Padding(2);
            this.pbEiler.Name = "pbEiler";
            this.pbEiler.Size = new System.Drawing.Size(75, 26);
            this.pbEiler.TabIndex = 15;
            this.pbEiler.Text = "Эйлер";
            this.pbEiler.UseVisualStyleBackColor = true;
            this.pbEiler.Click += new System.EventHandler(this.pbEiler_Click);
            // 
            // lbInterval2
            // 
            this.lbInterval2.AutoSize = true;
            this.lbInterval2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInterval2.Location = new System.Drawing.Point(74, 9);
            this.lbInterval2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInterval2.Name = "lbInterval2";
            this.lbInterval2.Size = new System.Drawing.Size(15, 13);
            this.lbInterval2.TabIndex = 8;
            this.lbInterval2.Text = "A";
            // 
            // lbInterval3
            // 
            this.lbInterval3.AutoSize = true;
            this.lbInterval3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInterval3.Location = new System.Drawing.Point(132, 9);
            this.lbInterval3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInterval3.Name = "lbInterval3";
            this.lbInterval3.Size = new System.Drawing.Size(15, 13);
            this.lbInterval3.TabIndex = 8;
            this.lbInterval3.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 315);
            this.Controls.Add(this.lbDivide2);
            this.Controls.Add(this.lbInterval3);
            this.Controls.Add(this.lbInterval2);
            this.Controls.Add(this.lbInterval1);
            this.Controls.Add(this.pbRungeKutt);
            this.Controls.Add(this.lbY0);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lbDivide1);
            this.Controls.Add(this.pbEilerPlus);
            this.Controls.Add(this.tbPoints);
            this.Controls.Add(this.tbIntervalB);
            this.Controls.Add(this.pbEiler);
            this.Controls.Add(this.tbY0);
            this.Controls.Add(this.tbIntervalA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDivide2;
        private System.Windows.Forms.Label lbInterval1;
        private System.Windows.Forms.Label lbY0;
        private System.Windows.Forms.Label lbDivide1;
        private System.Windows.Forms.TextBox tbPoints;
        private System.Windows.Forms.TextBox tbIntervalB;
        private System.Windows.Forms.TextBox tbY0;
        private System.Windows.Forms.TextBox tbIntervalA;
        private System.Windows.Forms.Button pbRungeKutt;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button pbEilerPlus;
        private System.Windows.Forms.Button pbEiler;
        private System.Windows.Forms.Label lbInterval2;
        private System.Windows.Forms.Label lbInterval3;
    }
}

