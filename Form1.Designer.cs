namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn10 = new System.Windows.Forms.Button();
            this.Btn11 = new System.Windows.Forms.Button();
            this.Btn12 = new System.Windows.Forms.Button();
            this.Btn13 = new System.Windows.Forms.Button();
            this.Btn14 = new System.Windows.Forms.Button();
            this.Btn15 = new System.Windows.Forms.Button();
            this.Btn16 = new System.Windows.Forms.Button();
            this.Btn17 = new System.Windows.Forms.Button();
            this.Btn18 = new System.Windows.Forms.Button();
            this.Btn19 = new System.Windows.Forms.Button();
            this.Btn20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 38);
            this.textBox1.TabIndex = 0;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(48, 140);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(572, 38);
            this.textResult.TabIndex = 1;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(48, 211);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(113, 77);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "CE";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(204, 211);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(113, 77);
            this.Btn2.TabIndex = 3;
            this.Btn2.Text = "C";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(358, 211);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(113, 77);
            this.Btn3.TabIndex = 4;
            this.Btn3.Text = "<--";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(507, 211);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(113, 77);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "/";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.POperator);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(48, 339);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(113, 77);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "7";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(204, 339);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(113, 77);
            this.Btn6.TabIndex = 7;
            this.Btn6.Text = "8";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(358, 339);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(113, 77);
            this.Btn7.TabIndex = 8;
            this.Btn7.Text = "9";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(507, 339);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(113, 77);
            this.Btn8.TabIndex = 9;
            this.Btn8.Text = "*";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.POperator);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(48, 477);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(113, 77);
            this.Btn9.TabIndex = 10;
            this.Btn9.Text = "4";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn10
            // 
            this.Btn10.Location = new System.Drawing.Point(204, 477);
            this.Btn10.Name = "Btn10";
            this.Btn10.Size = new System.Drawing.Size(113, 77);
            this.Btn10.TabIndex = 11;
            this.Btn10.Text = "5";
            this.Btn10.UseVisualStyleBackColor = true;
            this.Btn10.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn11
            // 
            this.Btn11.Location = new System.Drawing.Point(358, 477);
            this.Btn11.Name = "Btn11";
            this.Btn11.Size = new System.Drawing.Size(113, 77);
            this.Btn11.TabIndex = 12;
            this.Btn11.Text = "6";
            this.Btn11.UseVisualStyleBackColor = true;
            this.Btn11.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn12
            // 
            this.Btn12.Location = new System.Drawing.Point(507, 477);
            this.Btn12.Name = "Btn12";
            this.Btn12.Size = new System.Drawing.Size(113, 77);
            this.Btn12.TabIndex = 13;
            this.Btn12.Text = "-";
            this.Btn12.UseVisualStyleBackColor = true;
            this.Btn12.Click += new System.EventHandler(this.POperator);
            // 
            // Btn13
            // 
            this.Btn13.Location = new System.Drawing.Point(48, 607);
            this.Btn13.Name = "Btn13";
            this.Btn13.Size = new System.Drawing.Size(113, 77);
            this.Btn13.TabIndex = 14;
            this.Btn13.Text = "1";
            this.Btn13.UseVisualStyleBackColor = true;
            this.Btn13.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn14
            // 
            this.Btn14.Location = new System.Drawing.Point(204, 607);
            this.Btn14.Name = "Btn14";
            this.Btn14.Size = new System.Drawing.Size(113, 77);
            this.Btn14.TabIndex = 15;
            this.Btn14.Text = "2";
            this.Btn14.UseVisualStyleBackColor = true;
            this.Btn14.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn15
            // 
            this.Btn15.Location = new System.Drawing.Point(358, 607);
            this.Btn15.Name = "Btn15";
            this.Btn15.Size = new System.Drawing.Size(113, 77);
            this.Btn15.TabIndex = 16;
            this.Btn15.Text = "3";
            this.Btn15.UseVisualStyleBackColor = true;
            this.Btn15.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn16
            // 
            this.Btn16.Location = new System.Drawing.Point(507, 607);
            this.Btn16.Name = "Btn16";
            this.Btn16.Size = new System.Drawing.Size(113, 77);
            this.Btn16.TabIndex = 17;
            this.Btn16.Text = "+";
            this.Btn16.UseVisualStyleBackColor = true;
            this.Btn16.Click += new System.EventHandler(this.POperator);
            // 
            // Btn17
            // 
            this.Btn17.Location = new System.Drawing.Point(48, 724);
            this.Btn17.Name = "Btn17";
            this.Btn17.Size = new System.Drawing.Size(113, 77);
            this.Btn17.TabIndex = 18;
            this.Btn17.Text = "+-";
            this.Btn17.UseVisualStyleBackColor = true;
            this.Btn17.Click += new System.EventHandler(this.Btn17_Click);
            // 
            // Btn18
            // 
            this.Btn18.Location = new System.Drawing.Point(204, 724);
            this.Btn18.Name = "Btn18";
            this.Btn18.Size = new System.Drawing.Size(113, 77);
            this.Btn18.TabIndex = 19;
            this.Btn18.Text = "0";
            this.Btn18.UseVisualStyleBackColor = true;
            this.Btn18.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn19
            // 
            this.Btn19.Location = new System.Drawing.Point(358, 724);
            this.Btn19.Name = "Btn19";
            this.Btn19.Size = new System.Drawing.Size(113, 77);
            this.Btn19.TabIndex = 20;
            this.Btn19.Text = ",";
            this.Btn19.UseVisualStyleBackColor = true;
            this.Btn19.Click += new System.EventHandler(this.PNumber);
            // 
            // Btn20
            // 
            this.Btn20.Location = new System.Drawing.Point(507, 724);
            this.Btn20.Name = "Btn20";
            this.Btn20.Size = new System.Drawing.Size(113, 77);
            this.Btn20.TabIndex = 21;
            this.Btn20.Text = "=";
            this.Btn20.UseVisualStyleBackColor = true;
            this.Btn20.Click += new System.EventHandler(this.Btn20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 830);
            this.Controls.Add(this.Btn20);
            this.Controls.Add(this.Btn19);
            this.Controls.Add(this.Btn18);
            this.Controls.Add(this.Btn17);
            this.Controls.Add(this.Btn16);
            this.Controls.Add(this.Btn15);
            this.Controls.Add(this.Btn14);
            this.Controls.Add(this.Btn13);
            this.Controls.Add(this.Btn12);
            this.Controls.Add(this.Btn11);
            this.Controls.Add(this.Btn10);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "hello world";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn10;
        private System.Windows.Forms.Button Btn11;
        private System.Windows.Forms.Button Btn12;
        private System.Windows.Forms.Button Btn13;
        private System.Windows.Forms.Button Btn14;
        private System.Windows.Forms.Button Btn15;
        private System.Windows.Forms.Button Btn16;
        private System.Windows.Forms.Button Btn17;
        private System.Windows.Forms.Button Btn18;
        private System.Windows.Forms.Button Btn19;
        private System.Windows.Forms.Button Btn20;
    }
}

