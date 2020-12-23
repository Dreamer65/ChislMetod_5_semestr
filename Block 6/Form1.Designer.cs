namespace Block_6
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
            this.pbRectangle = new System.Windows.Forms.Button();
            this.lbSegmentsCount = new System.Windows.Forms.Label();
            this.tbSegmentsCount = new System.Windows.Forms.TextBox();
            this.tbIntervalA = new System.Windows.Forms.TextBox();
            this.lbInterval = new System.Windows.Forms.Label();
            this.lbIntervalA = new System.Windows.Forms.Label();
            this.lbIntervalB = new System.Windows.Forms.Label();
            this.tbIntervalB = new System.Windows.Forms.TextBox();
            this.pbTrapezoid = new System.Windows.Forms.Button();
            this.pbSimpson = new System.Windows.Forms.Button();
            this.lbRectangleResult = new System.Windows.Forms.Label();
            this.lbTrapezoidResult = new System.Windows.Forms.Label();
            this.lbSimpsonResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbRectangle
            // 
            this.pbRectangle.Location = new System.Drawing.Point(12, 134);
            this.pbRectangle.Name = "pbRectangle";
            this.pbRectangle.Size = new System.Drawing.Size(116, 23);
            this.pbRectangle.TabIndex = 0;
            this.pbRectangle.Text = "Прямоугольники";
            this.pbRectangle.UseVisualStyleBackColor = true;
            this.pbRectangle.Click += new System.EventHandler(this.pbRectangle_Click);
            // 
            // lbSegmentsCount
            // 
            this.lbSegmentsCount.AutoSize = true;
            this.lbSegmentsCount.Location = new System.Drawing.Point(12, 9);
            this.lbSegmentsCount.Name = "lbSegmentsCount";
            this.lbSegmentsCount.Size = new System.Drawing.Size(116, 13);
            this.lbSegmentsCount.TabIndex = 1;
            this.lbSegmentsCount.Text = "Количество отрезков";
            // 
            // tbSegmentsCount
            // 
            this.tbSegmentsCount.Location = new System.Drawing.Point(12, 25);
            this.tbSegmentsCount.Name = "tbSegmentsCount";
            this.tbSegmentsCount.Size = new System.Drawing.Size(68, 20);
            this.tbSegmentsCount.TabIndex = 2;
            // 
            // tbIntervalA
            // 
            this.tbIntervalA.Location = new System.Drawing.Point(32, 64);
            this.tbIntervalA.Name = "tbIntervalA";
            this.tbIntervalA.Size = new System.Drawing.Size(48, 20);
            this.tbIntervalA.TabIndex = 4;
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(12, 48);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(56, 13);
            this.lbInterval.TabIndex = 3;
            this.lbInterval.Text = "Интервал";
            // 
            // lbIntervalA
            // 
            this.lbIntervalA.AutoSize = true;
            this.lbIntervalA.Location = new System.Drawing.Point(12, 67);
            this.lbIntervalA.Name = "lbIntervalA";
            this.lbIntervalA.Size = new System.Drawing.Size(14, 13);
            this.lbIntervalA.TabIndex = 3;
            this.lbIntervalA.Text = "A";
            // 
            // lbIntervalB
            // 
            this.lbIntervalB.AutoSize = true;
            this.lbIntervalB.Location = new System.Drawing.Point(12, 93);
            this.lbIntervalB.Name = "lbIntervalB";
            this.lbIntervalB.Size = new System.Drawing.Size(14, 13);
            this.lbIntervalB.TabIndex = 3;
            this.lbIntervalB.Text = "B";
            // 
            // tbIntervalB
            // 
            this.tbIntervalB.Location = new System.Drawing.Point(32, 90);
            this.tbIntervalB.Name = "tbIntervalB";
            this.tbIntervalB.Size = new System.Drawing.Size(48, 20);
            this.tbIntervalB.TabIndex = 4;
            // 
            // pbTrapezoid
            // 
            this.pbTrapezoid.Location = new System.Drawing.Point(12, 226);
            this.pbTrapezoid.Name = "pbTrapezoid";
            this.pbTrapezoid.Size = new System.Drawing.Size(116, 23);
            this.pbTrapezoid.TabIndex = 0;
            this.pbTrapezoid.Text = "Трапеции";
            this.pbTrapezoid.UseVisualStyleBackColor = true;
            this.pbTrapezoid.Click += new System.EventHandler(this.pbTrapezoid_Click);
            // 
            // pbSimpson
            // 
            this.pbSimpson.Location = new System.Drawing.Point(12, 333);
            this.pbSimpson.Name = "pbSimpson";
            this.pbSimpson.Size = new System.Drawing.Size(116, 23);
            this.pbSimpson.TabIndex = 0;
            this.pbSimpson.Text = "Симпсон";
            this.pbSimpson.UseVisualStyleBackColor = true;
            this.pbSimpson.Click += new System.EventHandler(this.pbSimpson_Click);
            // 
            // lbRectangleResult
            // 
            this.lbRectangleResult.AutoSize = true;
            this.lbRectangleResult.Location = new System.Drawing.Point(148, 139);
            this.lbRectangleResult.Name = "lbRectangleResult";
            this.lbRectangleResult.Size = new System.Drawing.Size(35, 13);
            this.lbRectangleResult.TabIndex = 5;
            this.lbRectangleResult.Text = "label1";
            // 
            // lbTrapezoidResult
            // 
            this.lbTrapezoidResult.AutoSize = true;
            this.lbTrapezoidResult.Location = new System.Drawing.Point(148, 231);
            this.lbTrapezoidResult.Name = "lbTrapezoidResult";
            this.lbTrapezoidResult.Size = new System.Drawing.Size(35, 13);
            this.lbTrapezoidResult.TabIndex = 5;
            this.lbTrapezoidResult.Text = "label1";
            // 
            // lbSimpsonResult
            // 
            this.lbSimpsonResult.AutoSize = true;
            this.lbSimpsonResult.Location = new System.Drawing.Point(148, 338);
            this.lbSimpsonResult.Name = "lbSimpsonResult";
            this.lbSimpsonResult.Size = new System.Drawing.Size(35, 13);
            this.lbSimpsonResult.TabIndex = 5;
            this.lbSimpsonResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 450);
            this.Controls.Add(this.lbSimpsonResult);
            this.Controls.Add(this.lbTrapezoidResult);
            this.Controls.Add(this.lbRectangleResult);
            this.Controls.Add(this.tbIntervalB);
            this.Controls.Add(this.lbIntervalB);
            this.Controls.Add(this.tbIntervalA);
            this.Controls.Add(this.lbIntervalA);
            this.Controls.Add(this.lbInterval);
            this.Controls.Add(this.tbSegmentsCount);
            this.Controls.Add(this.lbSegmentsCount);
            this.Controls.Add(this.pbSimpson);
            this.Controls.Add(this.pbTrapezoid);
            this.Controls.Add(this.pbRectangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pbRectangle;
        private System.Windows.Forms.Label lbSegmentsCount;
        private System.Windows.Forms.TextBox tbSegmentsCount;
        private System.Windows.Forms.TextBox tbIntervalA;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.Label lbIntervalA;
        private System.Windows.Forms.Label lbIntervalB;
        private System.Windows.Forms.TextBox tbIntervalB;
        private System.Windows.Forms.Button pbTrapezoid;
        private System.Windows.Forms.Button pbSimpson;
        private System.Windows.Forms.Label lbRectangleResult;
        private System.Windows.Forms.Label lbTrapezoidResult;
        private System.Windows.Forms.Label lbSimpsonResult;
    }
}

