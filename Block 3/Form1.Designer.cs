namespace Block_3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dgvLeft = new System.Windows.Forms.DataGridView();
            this.dgvX = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.Button();
            this.pbDel = new System.Windows.Forms.Button();
            this.pbGause = new System.Windows.Forms.Button();
            this.pbZeidel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvX)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvMain.Location = new System.Drawing.Point(12, 30);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0";
            this.dgvMain.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(450, 407);
            this.dgvMain.TabIndex = 0;
            // 
            // dgvLeft
            // 
            this.dgvLeft.AllowUserToAddRows = false;
            this.dgvLeft.AllowUserToDeleteRows = false;
            this.dgvLeft.AllowUserToResizeColumns = false;
            this.dgvLeft.AllowUserToResizeRows = false;
            this.dgvLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeft.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeft.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeft.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvLeft.Location = new System.Drawing.Point(468, 30);
            this.dgvLeft.MultiSelect = false;
            this.dgvLeft.Name = "dgvLeft";
            this.dgvLeft.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "0";
            this.dgvLeft.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLeft.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeft.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLeft.Size = new System.Drawing.Size(108, 407);
            this.dgvLeft.TabIndex = 0;
            // 
            // dgvX
            // 
            this.dgvX.AllowUserToAddRows = false;
            this.dgvX.AllowUserToDeleteRows = false;
            this.dgvX.AllowUserToResizeColumns = false;
            this.dgvX.AllowUserToResizeRows = false;
            this.dgvX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvX.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvX.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvX.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvX.Location = new System.Drawing.Point(612, 30);
            this.dgvX.MultiSelect = false;
            this.dgvX.Name = "dgvX";
            this.dgvX.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "0";
            this.dgvX.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvX.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvX.Size = new System.Drawing.Size(93, 407);
            this.dgvX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(582, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            // 
            // pbAdd
            // 
            this.pbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pbAdd.Location = new System.Drawing.Point(711, 29);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(89, 31);
            this.pbAdd.TabIndex = 2;
            this.pbAdd.Text = "+";
            this.pbAdd.UseVisualStyleBackColor = true;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbDel
            // 
            this.pbDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pbDel.Location = new System.Drawing.Point(711, 66);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(89, 31);
            this.pbDel.TabIndex = 2;
            this.pbDel.Text = "-";
            this.pbDel.UseVisualStyleBackColor = true;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbGause
            // 
            this.pbGause.Location = new System.Drawing.Point(711, 131);
            this.pbGause.Name = "pbGause";
            this.pbGause.Size = new System.Drawing.Size(89, 23);
            this.pbGause.TabIndex = 3;
            this.pbGause.Text = "Гаус";
            this.pbGause.UseVisualStyleBackColor = true;
            this.pbGause.Click += new System.EventHandler(this.pbGause_Click);
            // 
            // pbZeidel
            // 
            this.pbZeidel.Location = new System.Drawing.Point(711, 160);
            this.pbZeidel.Name = "pbZeidel";
            this.pbZeidel.Size = new System.Drawing.Size(89, 23);
            this.pbZeidel.TabIndex = 3;
            this.pbZeidel.Text = "Зейдель";
            this.pbZeidel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.pbZeidel);
            this.Controls.Add(this.pbGause);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvX);
            this.Controls.Add(this.dgvLeft);
            this.Controls.Add(this.dgvMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridView dgvLeft;
        private System.Windows.Forms.DataGridView dgvX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pbAdd;
        private System.Windows.Forms.Button pbDel;
        private System.Windows.Forms.Button pbGause;
        private System.Windows.Forms.Button pbZeidel;
    }
}

