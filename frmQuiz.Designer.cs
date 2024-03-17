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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.btnGoBackToReturnMenue.Location = new System.Drawing.Point(917, 745);
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
            this.btnFinishQuiz.Location = new System.Drawing.Point(31, 745);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 296);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 820);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.btnFinishQuiz);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnGoBackToReturnMenue);
            this.Controls.Add(this.label1);
            this.Name = "frmQuiz";
            this.Text = "frmQuiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}