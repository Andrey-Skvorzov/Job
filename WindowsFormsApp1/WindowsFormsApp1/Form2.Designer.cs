namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.secondAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstAnswer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Итоговое значение Pult:";
            // 
            // secondAnswer
            // 
            this.secondAnswer.AutoSize = true;
            this.secondAnswer.Location = new System.Drawing.Point(386, 239);
            this.secondAnswer.Name = "secondAnswer";
            this.secondAnswer.Size = new System.Drawing.Size(35, 13);
            this.secondAnswer.TabIndex = 11;
            this.secondAnswer.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Расчет несущей способности прямоугольного железобетонного фуедамента";
            // 
            // firstAnswer
            // 
            this.firstAnswer.AutoSize = true;
            this.firstAnswer.Location = new System.Drawing.Point(386, 103);
            this.firstAnswer.Name = "firstAnswer";
            this.firstAnswer.Size = new System.Drawing.Size(35, 13);
            this.firstAnswer.TabIndex = 9;
            this.firstAnswer.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Итоговое занчение Asb:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Расчет величины армирования плитной части фундамента по ширине, соответствующей п" +
    "редельному изгибающему моменту и подавляющей силе";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secondAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Расчет формул";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label secondAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label firstAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}