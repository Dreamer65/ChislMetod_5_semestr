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
            this.StepField = new System.Windows.Forms.TextBox();
            this.bField = new System.Windows.Forms.TextBox();
            this.yZeroField = new System.Windows.Forms.TextBox();
            this.aField = new System.Windows.Forms.TextBox();
            this.pbRungeKutt = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.pbEilerPlus = new System.Windows.Forms.Button();
            this.pbEiler = new System.Windows.Forms.Button();
            this.lbInterval2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDivide2
            // 
            this.lbDivide2.AutoSize = true;
            this.lbDivide2.Location = new System.Drawing.Point(112, 70);
            this.lbDivide2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDivide2.Name = "lbDivide2";
            this.lbDivide2.Size = new System.Drawing.Size(41, 13);
            this.lbDivide2.TabIndex = 11;
            this.lbDivide2.Text = "частей";
            // 
            // lbInterval1
            // 
            this.lbInterval1.AutoSize = true;
            this.lbInterval1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInterval1.Location = new System.Drawing.Point(11, 9);
            this.lbInterval1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInterval1.Name = "lbInterval1";
            this.lbInterval1.Size = new System.Drawing.Size(73, 13);
            this.lbInterval1.TabIndex = 8;
            this.lbInterval1.Text = "Интервал: от";
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
            // StepField
            // 
            this.StepField.Location = new System.Drawing.Point(80, 67);
            this.StepField.Margin = new System.Windows.Forms.Padding(2);
            this.StepField.Name = "StepField";
            this.StepField.Size = new System.Drawing.Size(28, 20);
            this.StepField.TabIndex = 7;
            // 
            // bField
            // 
            this.bField.Location = new System.Drawing.Point(144, 6);
            this.bField.Margin = new System.Windows.Forms.Padding(2);
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(28, 20);
            this.bField.TabIndex = 1;
            // 
            // yZeroField
            // 
            this.yZeroField.Location = new System.Drawing.Point(35, 35);
            this.yZeroField.Margin = new System.Windows.Forms.Padding(2);
            this.yZeroField.Name = "yZeroField";
            this.yZeroField.Size = new System.Drawing.Size(28, 20);
            this.yZeroField.TabIndex = 12;
            // 
            // aField
            // 
            this.aField.Location = new System.Drawing.Point(88, 6);
            this.aField.Margin = new System.Windows.Forms.Padding(2);
            this.aField.Name = "aField";
            this.aField.Size = new System.Drawing.Size(28, 20);
            this.aField.TabIndex = 5;
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
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvResult.Location = new System.Drawing.Point(187, 11);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidth = 10;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResult.Size = new System.Drawing.Size(137, 293);
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
            // 
            // lbInterval2
            // 
            this.lbInterval2.AutoSize = true;
            this.lbInterval2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInterval2.Location = new System.Drawing.Point(121, 9);
            this.lbInterval2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInterval2.Name = "lbInterval2";
            this.lbInterval2.Size = new System.Drawing.Size(19, 13);
            this.lbInterval2.TabIndex = 8;
            this.lbInterval2.Text = "до";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 315);
            this.Controls.Add(this.lbDivide2);
            this.Controls.Add(this.lbInterval2);
            this.Controls.Add(this.lbInterval1);
            this.Controls.Add(this.pbRungeKutt);
            this.Controls.Add(this.lbY0);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lbDivide1);
            this.Controls.Add(this.pbEilerPlus);
            this.Controls.Add(this.StepField);
            this.Controls.Add(this.bField);
            this.Controls.Add(this.pbEiler);
            this.Controls.Add(this.yZeroField);
            this.Controls.Add(this.aField);
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
        private System.Windows.Forms.TextBox StepField;
        private System.Windows.Forms.TextBox bField;
        private System.Windows.Forms.TextBox yZeroField;
        private System.Windows.Forms.TextBox aField;
        private System.Windows.Forms.Button pbRungeKutt;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button pbEilerPlus;
        private System.Windows.Forms.Button pbEiler;
        private System.Windows.Forms.Label lbInterval2;
    }
}

