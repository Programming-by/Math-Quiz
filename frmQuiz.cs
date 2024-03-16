using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    /*
     questions 
     add questions dynamically based on user choice
     make distinct answer 
     */
    public partial class frmQuiz : Form
    {
        Form _frmMainMenue;

        struct stQuestionInfo
        {
            public int NumberOfQuestions;
            public string QuestionLevel;
            public string Operation;
            public string Timer;
        }
        stQuestionInfo QuestionInfo;

        private float _Seconds = 0;
        public frmQuiz(Form frmMainMenue , int NumberOfQuestions,string QuestionLevel, string Operation, string Timer)
        {
            InitializeComponent();
            _frmMainMenue = frmMainMenue;

            QuestionInfo.NumberOfQuestions = NumberOfQuestions;
            QuestionInfo.QuestionLevel = QuestionLevel;
            QuestionInfo.Operation = Operation;
            QuestionInfo.Timer = Timer;

        }

        private void btnGoBackToReturnMenue_Click(object sender, EventArgs e)
        {
            _frmMainMenue.Show();
            this.Close();
        }

        private void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to finish the quiz?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            MessageBox.Show("Great! you got 16/20,Well done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {
            switch (QuestionInfo.Timer)
            {
                case "1:00":
                    _Seconds = 60;
                    break;
                case "2:00":
                    _Seconds = 120;
                    break;
                case "5:00":
                    _Seconds = 300;

                    break;
                case "10:00":
                    _Seconds = 600;

                    break;
                case "15:00":
                    _Seconds = 900;

                    break;
                case "30:00":
                    _Seconds = 1800;

                    break;
            }
            QuizTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --_Seconds;

            if (_Seconds <= 10)
            {
                lblTimer.ForeColor = Color.Red;
            }

            if (_Seconds >= 0)
            {
            TimeSpan time = TimeSpan.FromSeconds(_Seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            lblTimer.Text = str;
            lblTimer.Refresh();
            } else
            {
                QuizTimer.Stop();
                MessageBox.Show("Times Up", "Times Up", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
