namespace Block_1
{
    partial class FMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbE = new System.Windows.Forms.Label();
            this.tbEPower = new System.Windows.Forms.TextBox();
            this.lbEquals = new System.Windows.Forms.Label();
            this.lbClassic = new System.Windows.Forms.Label();
            this.lbReq = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAccuracy = new System.Windows.Forms.TextBox();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbExControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbE.Location = new System.Drawing.Point(12, 9);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(36, 39);
            this.lbE.TabIndex = 0;
            this.lbE.Text = "e";
            // 
            // tbEPower
            // 
            this.tbEPower.Location = new System.Drawing.Point(41, 9);
            this.tbEPower.Name = "tbEPower";
            this.tbEPower.Size = new System.Drawing.Size(28, 20);
            this.tbEPower.TabIndex = 1;
            this.tbEPower.Text = "1";
            // 
            // lbEquals
            // 
            this.lbEquals.AutoSize = true;
            this.lbEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEquals.Location = new System.Drawing.Point(75, 17);
            this.lbEquals.Name = "lbEquals";
            this.lbEquals.Size = new System.Drawing.Size(30, 31);
            this.lbEquals.TabIndex = 2;
            this.lbEquals.Text = "=";
            // 
            // lbClassic
            // 
            this.lbClassic.AutoSize = true;
            this.lbClassic.Location = new System.Drawing.Point(169, 16);
            this.lbClassic.Name = "lbClassic";
            this.lbClassic.Size = new System.Drawing.Size(10, 13);
            this.lbClassic.TabIndex = 3;
            this.lbClassic.Text = "-";
            // 
            // lbReq
            // 
            this.lbReq.AutoSize = true;
            this.lbReq.Location = new System.Drawing.Point(169, 35);
            this.lbReq.Name = "lbReq";
            this.lbReq.Size = new System.Drawing.Size(10, 13);
            this.lbReq.TabIndex = 4;
            this.lbReq.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAccuracy
            // 
            this.tbAccuracy.Location = new System.Drawing.Point(67, 51);
            this.tbAccuracy.Name = "tbAccuracy";
            this.tbAccuracy.Size = new System.Drawing.Size(43, 20);
            this.tbAccuracy.TabIndex = 6;
            this.tbAccuracy.Text = "0,01";
            // 
            // lbAccuracy
            // 
            this.lbAccuracy.AutoSize = true;
            this.lbAccuracy.Location = new System.Drawing.Point(9, 54);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(54, 13);
            this.lbAccuracy.TabIndex = 7;
            this.lbAccuracy.Text = "Точность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Рекурент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Класик";
            // 
            // lbExControl
            // 
            this.lbExControl.AutoSize = true;
            this.lbExControl.Location = new System.Drawing.Point(121, 58);
            this.lbExControl.Name = "lbExControl";
            this.lbExControl.Size = new System.Drawing.Size(35, 13);
            this.lbExControl.TabIndex = 10;
            this.lbExControl.Text = "label1";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 326);
            this.Controls.Add(this.lbExControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAccuracy);
            this.Controls.Add(this.tbAccuracy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbReq);
            this.Controls.Add(this.lbClassic);
            this.Controls.Add(this.lbEquals);
            this.Controls.Add(this.tbEPower);
            this.Controls.Add(this.lbE);
            this.Name = "FMain";
            this.Text = "Ряды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbE;
        private System.Windows.Forms.TextBox tbEPower;
        private System.Windows.Forms.Label lbEquals;
        private System.Windows.Forms.Label lbClassic;
        private System.Windows.Forms.Label lbReq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAccuracy;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbExControl;
    }
}

