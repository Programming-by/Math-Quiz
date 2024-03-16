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
     add Questions dynamically based on user choice
     

     background green for correct answer
     background red for wrong answer
     background white for the unanswered correct answer

     */
    public partial class frmQuiz : Form
    {
        private Form _frmMainMenu;

        public static Random random = new Random();
        public struct stQuestionInfo
        {
            public int NumberOfQuestions;
            public string QuestionLevel;
            public string Operation;
            public string Timer;
            public double CorrectAnswer;
            public double PlayerAnswer;
        }
        stQuestionInfo _QuestionInfo;

        private float _Seconds = 0;


        public frmQuiz(Form frmMainMenu, frmMainMenue.stQuestionData QuestionData)
        {
            InitializeComponent();
            _frmMainMenu = frmMainMenu;

            _QuestionInfo.NumberOfQuestions = QuestionData.NumberOfQuestions;
            _QuestionInfo.QuestionLevel = QuestionData.QuestionLevel;
            _QuestionInfo.Operation = QuestionData.Operation;
            _QuestionInfo.Timer = QuestionData.Timer;
        }
       
        private double GetCorrectAnswer(double Number1 , double Number2) 
        {
            switch (_QuestionInfo.Operation)
            {
                case "Addition":
                    return Number1 + Number2;
                case "Subtraction":
                    return Number1 - Number2;
                case "Multiplication":
                    return Number1 * Number2;

                case "Division":
                    return Number1 / Number2;
                case "Mixed":
                    return Number1 + Number2;

                default:
                    return Number1 + Number2;
            }


        }

        private void ShuffleList(List<double> options)
        {
            var shuffledList = options.OrderBy(x => Guid.NewGuid()).ToList();
            foreach (var item in shuffledList)
            {
                if (rbOption1.Text == "")
                {
                    rbOption1.Text = item.ToString();
                }
                else if (rbOption2.Text == "")
                {
                    rbOption2.Text = item.ToString();
                }
                else if (rbOption3.Text == "")
                {
                    rbOption3.Text = item.ToString();
                }
                else if (rbOption4.Text == "")
                {
                    rbOption4.Text = item.ToString();
                }
            }
        }
        private void GenerateQuestionOptions()
        {
            List<double> options = new List<double>();
            double NumberGenerated = 0;

            options.Add(_QuestionInfo.CorrectAnswer);
            while (true)
            {
                NumberGenerated = random.Next(1, (int)_QuestionInfo.CorrectAnswer);

                if (options.Contains(NumberGenerated))
                {
                    NumberGenerated = random.Next(1, (int)_QuestionInfo.CorrectAnswer);
                   
                } else
                {
                    options.Add(NumberGenerated);

                }

                if (options.Count == 4)
                {
                    break;
                }
            }
            ShuffleList(options);
       
            }

        private void GenerateQuestion()
        {
            switch(_QuestionInfo.QuestionLevel)
            {
                case "Easy":
                    lblNumber1.Text = random.Next(1, 10).ToString();
                    lblNumber2.Text = random.Next(1, 10).ToString();
                   _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToDouble(lblNumber1.Text), Convert.ToDouble(lblNumber2.Text));
                    GenerateQuestionOptions();
                    
                    break;

                case "Medium":
                    lblNumber1.Text = random.Next(10, 50).ToString();
                    lblNumber2.Text = random.Next(10, 50).ToString();
                    _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToDouble(lblNumber1.Text), Convert.ToDouble(lblNumber2.Text));
                    GenerateQuestionOptions();
                    break;
                case "Hard":
                    lblNumber1.Text = random.Next(50, 100).ToString();
                    lblNumber2.Text = random.Next(50, 100).ToString();
                    _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToDouble(lblNumber1.Text), Convert.ToDouble(lblNumber2.Text));
                    GenerateQuestionOptions();
                    break;
                case "Mixed":
                    lblNumber1.Text = random.Next(1, 100).ToString();
                    lblNumber2.Text = random.Next(1, 100).ToString();
                    _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToDouble(lblNumber1.Text), Convert.ToDouble(lblNumber2.Text));
                    GenerateQuestionOptions();
                    break;

            }

            GenerateOperation();
        }

        private void GetRandomOperation()
        {
          int n =  random.Next(1, 5);

            if (n == 1)
                lblOperation.Text = "+";
            if (n == 2)
                lblOperation.Text = "-";
            if (n == 3)
                lblOperation.Text = "*";
            if (n == 4)
                lblOperation.Text = "/";

        }
        private void GenerateOperation()
        {
            switch (_QuestionInfo.Operation)
            {
                case "Addition":
                    lblOperation.Text =  "+";
                    break;

                case "Subtraction":
                    lblOperation.Text = "-";
                    break;
                case "Multiplication":
                    lblOperation.Text = "*";
                    break;
                case "Division":
                    lblOperation.Text = "/";
                    break;
                case "Mixed":
                    GetRandomOperation();
                    break;

            }

        }
        private void btnGoBackToReturnMenue_Click(object sender, EventArgs e)
        {
            _frmMainMenu.Show();
            this.Close();
        }
        private void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to finish the quiz?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            lblResultLabel.Visible = true;
            lblResult.Visible = true;
            lblResult.Text = "0/" + _QuestionInfo.NumberOfQuestions;
            QuizTimer.Stop();
            MessageBox.Show("Great! you got 16/20,Well done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
         
        
        }

        private void GetQuizTime()
        {
            switch (_QuestionInfo.Timer)
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
        private void frmQuiz_Load(object sender, EventArgs e)
        {
            GenerateQuestion();

            GetQuizTime();

            QuizTimer.Start();
        }

    }
}
