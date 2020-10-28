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
            this.lbEquals1 = new System.Windows.Forms.Label();
            this.lbExClassic = new System.Windows.Forms.Label();
            this.lbExReq = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbExAccuracy = new System.Windows.Forms.TextBox();
            this.lbAccuracy1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbExControl = new System.Windows.Forms.Label();
            this.lbSinControl = new System.Windows.Forms.Label();
            this.lbSpacer1 = new System.Windows.Forms.Label();
            this.lbAccuracy2 = new System.Windows.Forms.Label();
            this.tbSinAccuracy = new System.Windows.Forms.TextBox();
            this.pbSinCulc = new System.Windows.Forms.Button();
            this.lbSinRes = new System.Windows.Forms.Label();
            this.lbEquals2 = new System.Windows.Forms.Label();
            this.tbSinX = new System.Windows.Forms.TextBox();
            this.lbSin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLnControl = new System.Windows.Forms.Label();
            this.lbAccuracy3 = new System.Windows.Forms.Label();
            this.tbLnAccuracy = new System.Windows.Forms.TextBox();
            this.pbLnCalc = new System.Windows.Forms.Button();
            this.lbLnRes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLnX = new System.Windows.Forms.TextBox();
            this.lbLnXp1 = new System.Windows.Forms.Label();
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
            // lbEquals1
            // 
            this.lbEquals1.AutoSize = true;
            this.lbEquals1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEquals1.Location = new System.Drawing.Point(75, 17);
            this.lbEquals1.Name = "lbEquals1";
            this.lbEquals1.Size = new System.Drawing.Size(30, 31);
            this.lbEquals1.TabIndex = 2;
            this.lbEquals1.Text = "=";
            // 
            // lbExClassic
            // 
            this.lbExClassic.AutoSize = true;
            this.lbExClassic.Location = new System.Drawing.Point(169, 16);
            this.lbExClassic.Name = "lbExClassic";
            this.lbExClassic.Size = new System.Drawing.Size(10, 13);
            this.lbExClassic.TabIndex = 3;
            this.lbExClassic.Text = "-";
            // 
            // lbExReq
            // 
            this.lbExReq.AutoSize = true;
            this.lbExReq.Location = new System.Drawing.Point(169, 35);
            this.lbExReq.Name = "lbExReq";
            this.lbExReq.Size = new System.Drawing.Size(10, 13);
            this.lbExReq.TabIndex = 4;
            this.lbExReq.Text = "-";
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
            // tbExAccuracy
            // 
            this.tbExAccuracy.Location = new System.Drawing.Point(67, 51);
            this.tbExAccuracy.Name = "tbExAccuracy";
            this.tbExAccuracy.Size = new System.Drawing.Size(43, 20);
            this.tbExAccuracy.TabIndex = 6;
            this.tbExAccuracy.Text = "0,01";
            // 
            // lbAccuracy1
            // 
            this.lbAccuracy1.AutoSize = true;
            this.lbAccuracy1.Location = new System.Drawing.Point(9, 54);
            this.lbAccuracy1.Name = "lbAccuracy1";
            this.lbAccuracy1.Size = new System.Drawing.Size(54, 13);
            this.lbAccuracy1.TabIndex = 7;
            this.lbAccuracy1.Text = "Точность";
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
            // lbSinControl
            // 
            this.lbSinControl.AutoSize = true;
            this.lbSinControl.Location = new System.Drawing.Point(123, 148);
            this.lbSinControl.Name = "lbSinControl";
            this.lbSinControl.Size = new System.Drawing.Size(35, 13);
            this.lbSinControl.TabIndex = 21;
            this.lbSinControl.Text = "label1";
            // 
            // lbSpacer1
            // 
            this.lbSpacer1.AutoSize = true;
            this.lbSpacer1.Location = new System.Drawing.Point(9, 83);
            this.lbSpacer1.Name = "lbSpacer1";
            this.lbSpacer1.Size = new System.Drawing.Size(406, 13);
            this.lbSpacer1.TabIndex = 20;
            this.lbSpacer1.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------\r\n";
            // 
            // lbAccuracy2
            // 
            this.lbAccuracy2.AutoSize = true;
            this.lbAccuracy2.Location = new System.Drawing.Point(11, 144);
            this.lbAccuracy2.Name = "lbAccuracy2";
            this.lbAccuracy2.Size = new System.Drawing.Size(54, 13);
            this.lbAccuracy2.TabIndex = 18;
            this.lbAccuracy2.Text = "Точность";
            // 
            // tbSinAccuracy
            // 
            this.tbSinAccuracy.Location = new System.Drawing.Point(69, 141);
            this.tbSinAccuracy.Name = "tbSinAccuracy";
            this.tbSinAccuracy.Size = new System.Drawing.Size(43, 20);
            this.tbSinAccuracy.TabIndex = 17;
            this.tbSinAccuracy.Text = "0,01";
            // 
            // pbSinCulc
            // 
            this.pbSinCulc.Location = new System.Drawing.Point(335, 99);
            this.pbSinCulc.Name = "pbSinCulc";
            this.pbSinCulc.Size = new System.Drawing.Size(75, 23);
            this.pbSinCulc.TabIndex = 16;
            this.pbSinCulc.Text = "Calc";
            this.pbSinCulc.UseVisualStyleBackColor = true;
            this.pbSinCulc.Click += new System.EventHandler(this.pbSinCulc_Click);
            // 
            // lbSinRes
            // 
            this.lbSinRes.AutoSize = true;
            this.lbSinRes.Location = new System.Drawing.Point(170, 119);
            this.lbSinRes.Name = "lbSinRes";
            this.lbSinRes.Size = new System.Drawing.Size(10, 13);
            this.lbSinRes.TabIndex = 14;
            this.lbSinRes.Text = "-";
            // 
            // lbEquals2
            // 
            this.lbEquals2.AutoSize = true;
            this.lbEquals2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEquals2.Location = new System.Drawing.Point(140, 107);
            this.lbEquals2.Name = "lbEquals2";
            this.lbEquals2.Size = new System.Drawing.Size(30, 31);
            this.lbEquals2.TabIndex = 13;
            this.lbEquals2.Text = "=";
            // 
            // tbSinX
            // 
            this.tbSinX.Location = new System.Drawing.Point(88, 112);
            this.tbSinX.Name = "tbSinX";
            this.tbSinX.Size = new System.Drawing.Size(28, 20);
            this.tbSinX.TabIndex = 12;
            this.tbSinX.Text = "1";
            // 
            // lbSin
            // 
            this.lbSin.AutoSize = true;
            this.lbSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSin.Location = new System.Drawing.Point(14, 99);
            this.lbSin.Name = "lbSin";
            this.lbSin.Size = new System.Drawing.Size(128, 39);
            this.lbSin.TabIndex = 11;
            this.lbSin.Text = "sin (    )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------\r\n";
            // 
            // lbLnControl
            // 
            this.lbLnControl.AutoSize = true;
            this.lbLnControl.Location = new System.Drawing.Point(123, 239);
            this.lbLnControl.Name = "lbLnControl";
            this.lbLnControl.Size = new System.Drawing.Size(35, 13);
            this.lbLnControl.TabIndex = 30;
            this.lbLnControl.Text = "label1";
            // 
            // lbAccuracy3
            // 
            this.lbAccuracy3.AutoSize = true;
            this.lbAccuracy3.Location = new System.Drawing.Point(11, 235);
            this.lbAccuracy3.Name = "lbAccuracy3";
            this.lbAccuracy3.Size = new System.Drawing.Size(54, 13);
            this.lbAccuracy3.TabIndex = 29;
            this.lbAccuracy3.Text = "Точность";
            // 
            // tbLnAccuracy
            // 
            this.tbLnAccuracy.Location = new System.Drawing.Point(69, 232);
            this.tbLnAccuracy.Name = "tbLnAccuracy";
            this.tbLnAccuracy.Size = new System.Drawing.Size(43, 20);
            this.tbLnAccuracy.TabIndex = 28;
            this.tbLnAccuracy.Text = "0,01";
            // 
            // pbLnCalc
            // 
            this.pbLnCalc.Location = new System.Drawing.Point(335, 190);
            this.pbLnCalc.Name = "pbLnCalc";
            this.pbLnCalc.Size = new System.Drawing.Size(75, 23);
            this.pbLnCalc.TabIndex = 27;
            this.pbLnCalc.Text = "Calc";
            this.pbLnCalc.UseVisualStyleBackColor = true;
            this.pbLnCalc.Click += new System.EventHandler(this.pbLnCalc_Click);
            // 
            // lbLnRes
            // 
            this.lbLnRes.AutoSize = true;
            this.lbLnRes.Location = new System.Drawing.Point(191, 210);
            this.lbLnRes.Name = "lbLnRes";
            this.lbLnRes.Size = new System.Drawing.Size(10, 13);
            this.lbLnRes.TabIndex = 26;
            this.lbLnRes.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(159, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "=";
            // 
            // tbLnX
            // 
            this.tbLnX.Location = new System.Drawing.Point(114, 203);
            this.tbLnX.Name = "tbLnX";
            this.tbLnX.Size = new System.Drawing.Size(28, 20);
            this.tbLnX.TabIndex = 24;
            this.tbLnX.Text = "1";
            // 
            // lbLnXp1
            // 
            this.lbLnXp1.AutoSize = true;
            this.lbLnXp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLnXp1.Location = new System.Drawing.Point(14, 190);
            this.lbLnXp1.Name = "lbLnXp1";
            this.lbLnXp1.Size = new System.Drawing.Size(150, 39);
            this.lbLnXp1.TabIndex = 23;
            this.lbLnXp1.Text = "ln(1 +    )";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 326);
            this.Controls.Add(this.lbLnControl);
            this.Controls.Add(this.lbAccuracy3);
            this.Controls.Add(this.tbLnAccuracy);
            this.Controls.Add(this.pbLnCalc);
            this.Controls.Add(this.lbLnRes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLnX);
            this.Controls.Add(this.lbLnXp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSinControl);
            this.Controls.Add(this.lbSpacer1);
            this.Controls.Add(this.lbAccuracy2);
            this.Controls.Add(this.tbSinAccuracy);
            this.Controls.Add(this.pbSinCulc);
            this.Controls.Add(this.lbSinRes);
            this.Controls.Add(this.lbEquals2);
            this.Controls.Add(this.tbSinX);
            this.Controls.Add(this.lbSin);
            this.Controls.Add(this.lbExControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAccuracy1);
            this.Controls.Add(this.tbExAccuracy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbExReq);
            this.Controls.Add(this.lbExClassic);
            this.Controls.Add(this.lbEquals1);
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
        private System.Windows.Forms.Label lbEquals1;
        private System.Windows.Forms.Label lbExClassic;
        private System.Windows.Forms.Label lbExReq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbExAccuracy;
        private System.Windows.Forms.Label lbAccuracy1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbExControl;
        private System.Windows.Forms.Label lbSinControl;
        private System.Windows.Forms.Label lbSpacer1;
        private System.Windows.Forms.Label lbAccuracy2;
        private System.Windows.Forms.TextBox tbSinAccuracy;
        private System.Windows.Forms.Button pbSinCulc;
        private System.Windows.Forms.Label lbSinRes;
        private System.Windows.Forms.Label lbEquals2;
        private System.Windows.Forms.TextBox tbSinX;
        private System.Windows.Forms.Label lbSin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLnControl;
        private System.Windows.Forms.Label lbAccuracy3;
        private System.Windows.Forms.TextBox tbLnAccuracy;
        private System.Windows.Forms.Button pbLnCalc;
        private System.Windows.Forms.Label lbLnRes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLnX;
        private System.Windows.Forms.Label lbLnXp1;
    }
}

