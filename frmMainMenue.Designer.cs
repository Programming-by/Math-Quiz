﻿namespace Math_Quiz
{
    partial class frmMainMenue
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.cbTimer = new System.Windows.Forms.ComboBox();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Questions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timer:";
            // 
            // nNumberOfQuestions
            // 
            this.nNumberOfQuestions.Location = new System.Drawing.Point(306, 141);
            this.nNumberOfQuestions.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nNumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumberOfQuestions.Name = "nNumberOfQuestions";
            this.nNumberOfQuestions.Size = new System.Drawing.Size(120, 22);
            this.nNumberOfQuestions.TabIndex = 5;
            this.nNumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Mixed"});
            this.cbLevel.Location = new System.Drawing.Point(306, 207);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(120, 24);
            this.cbLevel.TabIndex = 6;
            // 
            // cbOperation
            // 
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division",
            "Mixed"});
            this.cbOperation.Location = new System.Drawing.Point(306, 263);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(120, 24);
            this.cbOperation.TabIndex = 7;
            // 
            // cbTimer
            // 
            this.cbTimer.FormattingEnabled = true;
            this.cbTimer.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "5:00",
            "10:00",
            "15:00",
            "30:00"});
            this.cbTimer.Location = new System.Drawing.Point(306, 314);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(120, 24);
            this.cbTimer.TabIndex = 8;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Location = new System.Drawing.Point(306, 375);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(120, 63);
            this.btnStartQuiz.TabIndex = 9;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // frmMainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.cbTimer);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.nNumberOfQuestions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMainMenue";
            this.Text = "Main Menue";
            this.Load += new System.EventHandler(this.frmMainMenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nNumberOfQuestions;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.ComboBox cbTimer;
        private System.Windows.Forms.Button btnStartQuiz;
    }
}

