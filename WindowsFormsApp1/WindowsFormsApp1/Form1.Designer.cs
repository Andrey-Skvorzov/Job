namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.secondAnswer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расчет величины армирования плитной части фундамента по ширине, соответствующей п" +
    "редельному изгибающему моменту и подавляющей силе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Итоговое занчение Asb:";
            // 
            // firstAnswer
            // 
            this.firstAnswer.AutoSize = true;
            this.firstAnswer.Location = new System.Drawing.Point(386, 96);
            this.firstAnswer.Name = "firstAnswer";
            this.firstAnswer.Size = new System.Drawing.Size(35, 13);
            this.firstAnswer.TabIndex = 2;
            this.firstAnswer.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Расчет несущей способности прямоугольного железобетонного фуедамента";
            // 
            // secondAnswer
            // 
            this.secondAnswer.AutoSize = true;
            this.secondAnswer.Location = new System.Drawing.Point(386, 232);
            this.secondAnswer.Name = "secondAnswer";
            this.secondAnswer.Size = new System.Drawing.Size(35, 13);
            this.secondAnswer.TabIndex = 5;
            this.secondAnswer.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Итоговое значение Pult:";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(365, 329);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(35, 13);
            this.test.TabIndex = 7;
            this.test.Text = "label5";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secondAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firstAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label secondAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label test;
    }
}

