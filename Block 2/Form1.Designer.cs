namespace ChislMethod_5_Semestr
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chPolindrome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbRootAccuracy = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRootB = new System.Windows.Forms.TextBox();
            this.tbRootA = new System.Windows.Forms.TextBox();
            this.lbChartInterval = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbDihotomy = new System.Windows.Forms.Button();
            this.lbDihotomyRoot = new System.Windows.Forms.Label();
            this.pbHords = new System.Windows.Forms.Button();
            this.lbHordsRoot = new System.Windows.Forms.Label();
            this.pbTangent = new System.Windows.Forms.Button();
            this.lbTangentRoot = new System.Windows.Forms.Label();
            this.pbIter = new System.Windows.Forms.Button();
            this.lbIterRoot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chPolindrome)).BeginInit();
            this.SuspendLayout();
            // 
            // chPolindrome
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chPolindrome.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chPolindrome.Legends.Add(legend1);
            this.chPolindrome.Location = new System.Drawing.Point(12, 12);
            this.chPolindrome.Name = "chPolindrome";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Polindrome";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chPolindrome.Series.Add(series1);
            this.chPolindrome.Size = new System.Drawing.Size(426, 426);
            this.chPolindrome.TabIndex = 0;
            this.chPolindrome.Text = "chart1";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(502, 41);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 1;
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(664, 41);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 2;
            this.tbB.TextChanged += new System.EventHandler(this.tbB_TextChanged);
            // 
            // tbRootAccuracy
            // 
            this.tbRootAccuracy.Location = new System.Drawing.Point(502, 134);
            this.tbRootAccuracy.Name = "tbRootAccuracy";
            this.tbRootAccuracy.Size = new System.Drawing.Size(100, 20);
            this.tbRootAccuracy.TabIndex = 3;
            this.tbRootAccuracy.TextChanged += new System.EventHandler(this.tbRootAccuracy_TextChanged);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(482, 44);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(14, 13);
            this.lbA.TabIndex = 4;
            this.lbA.Text = "A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(644, 44);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(14, 13);
            this.lbB.TabIndex = 5;
            this.lbB.Text = "B";
            // 
            // lbAccuracy
            // 
            this.lbAccuracy.AutoSize = true;
            this.lbAccuracy.Location = new System.Drawing.Point(444, 137);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(52, 13);
            this.lbAccuracy.TabIndex = 6;
            this.lbAccuracy.Text = "Accuracy";
            // 
            // tbResult
            // 
            this.tbResult.AutoSize = true;
            this.tbResult.Location = new System.Drawing.Point(644, 107);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(14, 13);
            this.tbResult.TabIndex = 10;
            this.tbResult.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "A";
            // 
            // tbRootB
            // 
            this.tbRootB.Location = new System.Drawing.Point(664, 104);
            this.tbRootB.Name = "tbRootB";
            this.tbRootB.Size = new System.Drawing.Size(100, 20);
            this.tbRootB.TabIndex = 8;
            this.tbRootB.TextChanged += new System.EventHandler(this.tbRootB_TextChanged);
            // 
            // tbRootA
            // 
            this.tbRootA.Location = new System.Drawing.Point(502, 104);
            this.tbRootA.Name = "tbRootA";
            this.tbRootA.Size = new System.Drawing.Size(100, 20);
            this.tbRootA.TabIndex = 7;
            this.tbRootA.TextChanged += new System.EventHandler(this.tbRootA_TextChanged);
            // 
            // lbChartInterval
            // 
            this.lbChartInterval.AutoSize = true;
            this.lbChartInterval.Location = new System.Drawing.Point(444, 12);
            this.lbChartInterval.Name = "lbChartInterval";
            this.lbChartInterval.Size = new System.Drawing.Size(45, 13);
            this.lbChartInterval.TabIndex = 11;
            this.lbChartInterval.Text = "График";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Поиск корня";
            // 
            // pbDihotomy
            // 
            this.pbDihotomy.Location = new System.Drawing.Point(447, 186);
            this.pbDihotomy.Name = "pbDihotomy";
            this.pbDihotomy.Size = new System.Drawing.Size(91, 23);
            this.pbDihotomy.TabIndex = 13;
            this.pbDihotomy.Text = "Дихотомия";
            this.pbDihotomy.UseVisualStyleBackColor = true;
            this.pbDihotomy.Click += new System.EventHandler(this.pbDihotomy_Click);
            // 
            // lbDihotomyRoot
            // 
            this.lbDihotomyRoot.AutoSize = true;
            this.lbDihotomyRoot.Location = new System.Drawing.Point(544, 191);
            this.lbDihotomyRoot.Name = "lbDihotomyRoot";
            this.lbDihotomyRoot.Size = new System.Drawing.Size(49, 13);
            this.lbDihotomyRoot.TabIndex = 11;
            this.lbDihotomyRoot.Text = "Dih Root";
            // 
            // pbHords
            // 
            this.pbHords.Location = new System.Drawing.Point(447, 224);
            this.pbHords.Name = "pbHords";
            this.pbHords.Size = new System.Drawing.Size(91, 23);
            this.pbHords.TabIndex = 15;
            this.pbHords.Text = "Хорды";
            this.pbHords.UseVisualStyleBackColor = true;
            this.pbHords.Click += new System.EventHandler(this.pbHords_Click);
            // 
            // lbHordsRoot
            // 
            this.lbHordsRoot.AutoSize = true;
            this.lbHordsRoot.Location = new System.Drawing.Point(544, 229);
            this.lbHordsRoot.Name = "lbHordsRoot";
            this.lbHordsRoot.Size = new System.Drawing.Size(56, 13);
            this.lbHordsRoot.TabIndex = 14;
            this.lbHordsRoot.Text = "Hord Root";
            // 
            // pbTangent
            // 
            this.pbTangent.Location = new System.Drawing.Point(447, 265);
            this.pbTangent.Name = "pbTangent";
            this.pbTangent.Size = new System.Drawing.Size(91, 23);
            this.pbTangent.TabIndex = 17;
            this.pbTangent.Text = "Касательные";
            this.pbTangent.UseVisualStyleBackColor = true;
            this.pbTangent.Click += new System.EventHandler(this.pbTangent_Click);
            // 
            // lbTangentRoot
            // 
            this.lbTangentRoot.AutoSize = true;
            this.lbTangentRoot.Location = new System.Drawing.Point(544, 270);
            this.lbTangentRoot.Name = "lbTangentRoot";
            this.lbTangentRoot.Size = new System.Drawing.Size(73, 13);
            this.lbTangentRoot.TabIndex = 16;
            this.lbTangentRoot.Text = "Tangent Root";
            // 
            // pbIter
            // 
            this.pbIter.Location = new System.Drawing.Point(447, 303);
            this.pbIter.Name = "pbIter";
            this.pbIter.Size = new System.Drawing.Size(91, 23);
            this.pbIter.TabIndex = 19;
            this.pbIter.Text = "Итерации";
            this.pbIter.UseVisualStyleBackColor = true;
            this.pbIter.Click += new System.EventHandler(this.pbIter_Click);
            // 
            // lbIterRoot
            // 
            this.lbIterRoot.AutoSize = true;
            this.lbIterRoot.Location = new System.Drawing.Point(544, 308);
            this.lbIterRoot.Name = "lbIterRoot";
            this.lbIterRoot.Size = new System.Drawing.Size(48, 13);
            this.lbIterRoot.TabIndex = 18;
            this.lbIterRoot.Text = "Iter Root";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbIter);
            this.Controls.Add(this.lbIterRoot);
            this.Controls.Add(this.pbTangent);
            this.Controls.Add(this.lbTangentRoot);
            this.Controls.Add(this.pbHords);
            this.Controls.Add(this.lbHordsRoot);
            this.Controls.Add(this.pbDihotomy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDihotomyRoot);
            this.Controls.Add(this.lbChartInterval);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRootB);
            this.Controls.Add(this.tbRootA);
            this.Controls.Add(this.lbAccuracy);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.tbRootAccuracy);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.chPolindrome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chPolindrome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chPolindrome;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbRootAccuracy;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.Label tbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRootB;
        private System.Windows.Forms.TextBox tbRootA;
        private System.Windows.Forms.Label lbChartInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pbDihotomy;
        private System.Windows.Forms.Label lbDihotomyRoot;
        private System.Windows.Forms.Button pbHords;
        private System.Windows.Forms.Label lbHordsRoot;
        private System.Windows.Forms.Button pbTangent;
        private System.Windows.Forms.Label lbTangentRoot;
        private System.Windows.Forms.Button pbIter;
        private System.Windows.Forms.Label lbIterRoot;
    }
}

