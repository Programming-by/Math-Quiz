using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Math_Quiz.frmQuiz;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Math_Quiz
{
    /*
     Wrap group box on each 6 group boxes
     Compare Answers
     */
    public partial class frmQuiz : Form
    {
        private Form _frmMainMenu;

        public static Random random = new Random();
        public struct stQuestionInfo
        {
            public int NumberOfQuestions;
            public string QuestionLevel;
            public string Number1;
            public string Number2;
            public string Operation;
            public string OperationSymbol;
            public string Timer;
            public double CorrectAnswer;
            public double UserAnswer;
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

        private List<double> ShuffleList(List<double> options)
        {
           //var shuffledList = options.OrderBy(x => Guid.NewGuid()).ToList();
            var shuffledList = options.OrderBy(x => random.Next()).ToList();
            return shuffledList;
        }
        private List<double> GenerateQuestionOptions()
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

            return options;

         }

        private string GetOption(List<double> shuffled, RadioButton rbOption)
        {
            foreach (var item in shuffled)
            {
                if (rbOption.Text == "")
                {
                    rbOption.Text = item.ToString();
                    shuffled.Remove(item);
                    return rbOption.Text;
                }
            }
            return "";
        }

        private void GenerateQuestion()
        {
            switch(_QuestionInfo.QuestionLevel)
            {
                case "Easy":
                    _QuestionInfo.Number1 = random.Next(1, 10).ToString();
                    _QuestionInfo.Number2 = random.Next(1, 10).ToString();
                    _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToDouble(_QuestionInfo.Number1), Convert.ToDouble(_QuestionInfo.Number2));
                    break;

                case "Medium":
                    _QuestionInfo.Number1 = random.Next(10, 50).ToString();
                    _QuestionInfo.Number2 = random.Next(10, 50).ToString();
                    _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToDouble(_QuestionInfo.Number1), Convert.ToDouble(_QuestionInfo.Number2));
                    break;
                case "Hard":
                    _QuestionInfo.Number1 = random.Next(50, 100).ToString();
                    _QuestionInfo.Number2 = random.Next(50, 100).ToString();
                    _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToDouble(_QuestionInfo.Number1), Convert.ToDouble(_QuestionInfo.Number2));
                    break;
                case "Mixed":
                    _QuestionInfo.Number1 = random.Next(1, 100).ToString();
                    _QuestionInfo.Number2 = random.Next(1, 100).ToString();
                    _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToDouble(_QuestionInfo.Number1), Convert.ToDouble(_QuestionInfo.Number2));
                    break;

            }
            _QuestionInfo.OperationSymbol = GenerateOperation();

            
        }
        private string GetRandomOperation()
        {
          int n =  random.Next(1, 5);

            if (n == 1)
                return "+";
            if (n == 2)
                return "-";
            if (n == 3)
                return "*";
            if (n == 4)
                return "/";

            return "+";

        }
        private string GenerateOperation()
        {
            switch (_QuestionInfo.Operation)
            {
                case "Addition":
                    return  "+";

                case "Subtraction":
                    return "-";

                case "Multiplication":
                    return "*";

                case "Division":
                    return "/";
                case "Mixed":
                   return GetRandomOperation();
                default:
                    return "+";
            }

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
  
        private void AddControlsToFlowLayoutPanel(int i)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Name = "gbQuestionInfo" + i;
            groupBox.Text = "Q0" + i;
            groupBox.Height = 200;
            groupBox.Width = 250;


            Label Number1 = new Label();
            Number1.Name = "lblNumber1";
            Number1.Width = 10;
            Number1.Text = "";
            Number1.Location = new Point(120, 50);


            Label Operation = new Label();
            Operation.Name = "lblOperation";
            Operation.Text = "";
            Operation.Width = 10;
            Operation.Location = new Point(140, 50);

            Label Number2 = new Label();
            Number2.Name = "lblNumber2";
            Number2.Width = 10;
            Number2.Text = "";
            Number2.Location = new Point(160, 50);

            Label Equality = new Label();
            Equality.Name = "lblEquality";
            Equality.Text = "=";
            Equality.Width = 10;
            Equality.Location = new Point(180, 50);


            GenerateQuestion();
            var options = GenerateQuestionOptions();
            var shuffled = ShuffleList(options);


            Number1.Text = _QuestionInfo.Number1;
            Number2.Text = _QuestionInfo.Number2;
            Operation.Text = _QuestionInfo.OperationSymbol;


            RadioButton Option1 = new RadioButton();
            Option1.Name = "rb1";
            Option1.Height = 20;
            Option1.Width = 50;
            Option1.Location = new Point(10, 70);
            Option1.Text = GetOption(shuffled, Option1);



            RadioButton Option2 = new RadioButton();
            Option2.Name = "rb2";
            Option2.Text = "";
            Option2.Height = 20;
            Option2.Width = 50;
            Option2.Location = new Point(10, 100);
            Option2.Text = GetOption(shuffled, Option2);



            RadioButton Option3 = new RadioButton();
            Option3.Name = "rb3";
            Option3.Text = "";
            Option3.Height = 20;
            Option3.Width = 50;
            Option3.Location = new Point(10, 130);
            Option3.Text = GetOption(shuffled, Option3);

            RadioButton Option4 = new RadioButton();
            Option4.Name = "rb4";
            Option4.Text = "";
            Option4.Height = 20;
            Option4.Width = 50;
            Option4.Location = new Point(10, 160);
            Option4.Text = GetOption(shuffled, Option4);


            groupBox.Controls.Add(Number1);
            groupBox.Controls.Add(Operation);
            groupBox.Controls.Add(Number2);
            groupBox.Controls.Add(Equality);

            groupBox.Controls.Add(Option1);
            groupBox.Controls.Add(Option2);
            groupBox.Controls.Add(Option3);
            groupBox.Controls.Add(Option4);

            flowLayoutPanel1.Controls.Add(groupBox);
        }
        private void GenerateDynamicQuestions()
        {
            for (int i = 1; i <= _QuestionInfo.NumberOfQuestions; i++)
            {
                AddControlsToFlowLayoutPanel(i);
            }
        }
        private void frmQuiz_Load(object sender, EventArgs e)
        {
            GenerateDynamicQuestions();

            GetQuizTime();

            QuizTimer.Start();
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

    }
}
