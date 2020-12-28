namespace Block_4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pbRowPlus = new System.Windows.Forms.Button();
            this.pbRowMinus = new System.Windows.Forms.Button();
            this.rbNewton = new System.Windows.Forms.RadioButton();
            this.rbLagrange = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbInterpolation = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.pbExtrapolation = new System.Windows.Forms.Button();
            this.pbReverseInterpolation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Location = new System.Drawing.Point(12, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvData.Size = new System.Drawing.Size(141, 380);
            this.dgvData.TabIndex = 0;
            // 
            // pbRowPlus
            // 
            this.pbRowPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pbRowPlus.Location = new System.Drawing.Point(12, 398);
            this.pbRowPlus.Name = "pbRowPlus";
            this.pbRowPlus.Size = new System.Drawing.Size(68, 40);
            this.pbRowPlus.TabIndex = 1;
            this.pbRowPlus.Text = "+";
            this.pbRowPlus.UseVisualStyleBackColor = true;
            this.pbRowPlus.Click += new System.EventHandler(this.pbRowPlus_Click);
            // 
            // pbRowMinus
            // 
            this.pbRowMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pbRowMinus.Location = new System.Drawing.Point(85, 398);
            this.pbRowMinus.Name = "pbRowMinus";
            this.pbRowMinus.Size = new System.Drawing.Size(68, 40);
            this.pbRowMinus.TabIndex = 1;
            this.pbRowMinus.Text = "-";
            this.pbRowMinus.UseVisualStyleBackColor = true;
            this.pbRowMinus.Click += new System.EventHandler(this.pbRowMinus_Click);
            // 
            // rbNewton
            // 
            this.rbNewton.AutoSize = true;
            this.rbNewton.Checked = true;
            this.rbNewton.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbNewton.Location = new System.Drawing.Point(0, 0);
            this.rbNewton.Name = "rbNewton";
            this.rbNewton.Size = new System.Drawing.Size(120, 17);
            this.rbNewton.TabIndex = 2;
            this.rbNewton.TabStop = true;
            this.rbNewton.Text = "Ньютон";
            this.rbNewton.UseVisualStyleBackColor = true;
            // 
            // rbLagrange
            // 
            this.rbLagrange.AutoSize = true;
            this.rbLagrange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rbLagrange.Location = new System.Drawing.Point(0, 19);
            this.rbLagrange.Name = "rbLagrange";
            this.rbLagrange.Size = new System.Drawing.Size(120, 17);
            this.rbLagrange.TabIndex = 2;
            this.rbLagrange.Text = "Лагранж";
            this.rbLagrange.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbNewton);
            this.panel1.Controls.Add(this.rbLagrange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 36);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbInterpolation);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(179, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 36);
            this.panel2.TabIndex = 3;
            // 
            // pbInterpolation
            // 
            this.pbInterpolation.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbInterpolation.Location = new System.Drawing.Point(93, 0);
            this.pbInterpolation.Name = "pbInterpolation";
            this.pbInterpolation.Size = new System.Drawing.Size(123, 36);
            this.pbInterpolation.TabIndex = 4;
            this.pbInterpolation.Text = "Интерполирование";
            this.pbInterpolation.UseVisualStyleBackColor = true;
            this.pbInterpolation.Click += new System.EventHandler(this.pbInterpolation_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.Location = new System.Drawing.Point(477, 29);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(81, 20);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "Решение:";
            // 
            // pbExtrapolation
            // 
            this.pbExtrapolation.Location = new System.Drawing.Point(272, 92);
            this.pbExtrapolation.Name = "pbExtrapolation";
            this.pbExtrapolation.Size = new System.Drawing.Size(123, 36);
            this.pbExtrapolation.TabIndex = 5;
            this.pbExtrapolation.Text = "Экстраполирование";
            this.pbExtrapolation.UseVisualStyleBackColor = true;
            this.pbExtrapolation.Click += new System.EventHandler(this.pbExtrapolation_Click);
            // 
            // pbReverseInterpolation
            // 
            this.pbReverseInterpolation.Location = new System.Drawing.Point(272, 171);
            this.pbReverseInterpolation.Name = "pbReverseInterpolation";
            this.pbReverseInterpolation.Size = new System.Drawing.Size(123, 36);
            this.pbReverseInterpolation.TabIndex = 5;
            this.pbReverseInterpolation.Text = "Обратное интерполирование";
            this.pbReverseInterpolation.UseVisualStyleBackColor = true;
            this.pbReverseInterpolation.Click += new System.EventHandler(this.pbReverseInterpolation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbReverseInterpolation);
            this.Controls.Add(this.pbExtrapolation);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbRowMinus);
            this.Controls.Add(this.pbRowPlus);
            this.Controls.Add(this.dgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button pbRowPlus;
        private System.Windows.Forms.Button pbRowMinus;
        private System.Windows.Forms.RadioButton rbNewton;
        private System.Windows.Forms.RadioButton rbLagrange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pbInterpolation;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button pbExtrapolation;
        private System.Windows.Forms.Button pbReverseInterpolation;
    }
}

