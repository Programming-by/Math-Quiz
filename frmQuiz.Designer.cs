namespace Math_Quiz
{
    partial class frmQuiz
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoBackToReturnMenue = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnFinishQuiz = new System.Windows.Forms.Button();
            this.QuizTimer = new System.Windows.Forms.Timer(this.components);
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.gbQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Math Quiz";
            // 
            // btnGoBackToReturnMenue
            // 
            this.btnGoBackToReturnMenue.Location = new System.Drawing.Point(723, 467);
            this.btnGoBackToReturnMenue.Name = "btnGoBackToReturnMenue";
            this.btnGoBackToReturnMenue.Size = new System.Drawing.Size(147, 63);
            this.btnGoBackToReturnMenue.TabIndex = 11;
            this.btnGoBackToReturnMenue.Text = "Return to Main Menue";
            this.btnGoBackToReturnMenue.UseVisualStyleBackColor = true;
            this.btnGoBackToReturnMenue.Click += new System.EventHandler(this.btnGoBackToReturnMenue_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(27, 84);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(81, 20);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnFinishQuiz
            // 
            this.btnFinishQuiz.Location = new System.Drawing.Point(304, 467);
            this.btnFinishQuiz.Name = "btnFinishQuiz";
            this.btnFinishQuiz.Size = new System.Drawing.Size(147, 63);
            this.btnFinishQuiz.TabIndex = 13;
            this.btnFinishQuiz.Text = "Finish Quiz";
            this.btnFinishQuiz.UseVisualStyleBackColor = true;
            this.btnFinishQuiz.Click += new System.EventHandler(this.btnFinishQuiz_Click);
            // 
            // QuizTimer
            // 
            this.QuizTimer.Interval = 1000;
            this.QuizTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblResultLabel
            // 
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultLabel.Location = new System.Drawing.Point(606, 84);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(113, 20);
            this.lblResultLabel.TabIndex = 14;
            this.lblResultLabel.Text = "Your Result:";
            this.lblResultLabel.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(738, 84);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 20);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "0/20";
            this.lblResult.Visible = false;
            // 
            // gbQuestion
            // 
            this.gbQuestion.Controls.Add(this.rbOption4);
            this.gbQuestion.Controls.Add(this.rbOption3);
            this.gbQuestion.Controls.Add(this.rbOption2);
            this.gbQuestion.Controls.Add(this.rbOption1);
            this.gbQuestion.Controls.Add(this.label5);
            this.gbQuestion.Controls.Add(this.lblNumber2);
            this.gbQuestion.Controls.Add(this.lblOperation);
            this.gbQuestion.Controls.Add(this.lblNumber1);
            this.gbQuestion.Location = new System.Drawing.Point(31, 122);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(310, 267);
            this.gbQuestion.TabIndex = 16;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Q01";
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(25, 230);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(17, 16);
            this.rbOption4.TabIndex = 23;
            this.rbOption4.TabStop = true;
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(25, 192);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(17, 16);
            this.rbOption3.TabIndex = 22;
            this.rbOption3.TabStop = true;
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(25, 149);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(17, 16);
            this.rbOption2.TabIndex = 21;
            this.rbOption2.TabStop = true;
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(25, 102);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(17, 16);
            this.rbOption1.TabIndex = 17;
            this.rbOption1.TabStop = true;
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "=";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(144, 42);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(24, 25);
            this.lblNumber2.TabIndex = 19;
            this.lblNumber2.Text = "1";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(113, 42);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(25, 25);
            this.lblOperation.TabIndex = 18;
            this.lblOperation.Text = "+";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(83, 42);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(24, 25);
            this.lblNumber1.TabIndex = 17;
            this.lblNumber1.Text = "1";
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 542);
            this.Controls.Add(this.gbQuestion);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.btnFinishQuiz);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnGoBackToReturnMenue);
            this.Controls.Add(this.label1);
            this.Name = "frmQuiz";
            this.Text = "frmQuiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBackToReturnMenue;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnFinishQuiz;
        private System.Windows.Forms.Timer QuizTimer;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption1;
    }
}