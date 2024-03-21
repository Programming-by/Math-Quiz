using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class frmQuiz : Form
    {
        List<RadioButton> PossibleAnswers = new List<RadioButton>();

        private Form _frmMainMenu;

        public static Random random = new Random();
        public struct stQuestionInfo
        {
            public int NumberOfQuestions;
            public string QuestionLevel;
            public string Number1;
            public string Number2;
            public string Operation;
            public string OpType;
            public string Timer;
            public int CorrectAnswer;
            public int QuizMark;
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
        private int GetCorrectAnswer(int Number1, int Number2,string OpType)
        {
            switch (OpType)
            {
                case "+":
                    return Number1 + Number2;
                case "-":
                    return Number1 - Number2;
                case "*":
                    return Number1 * Number2;

                case "/":
                    return Number1 / Number2;

                default:
                    return Number1 + Number2;
            }
        }
        private List<int> ShuffleList(List<int> options)
        {
            //var shuffledList = options.OrderBy(x => Guid.NewGuid()).ToList();
            var shuffledList = options.OrderBy(x => random.Next()).ToList();
            return shuffledList;
        }
        private List<int> GenerateQuestionOptions()
        {
            List<int> options = new List<int> 
            {
             _QuestionInfo.CorrectAnswer
            };
         
            while (options.Count < 4)
            {
                int NumberGenerated = 0;

                if (_QuestionInfo.CorrectAnswer <= 0)
                    NumberGenerated = random.Next(-30, (int)_QuestionInfo.CorrectAnswer);
                else
                    NumberGenerated = random.Next(1, (int)_QuestionInfo.CorrectAnswer);


                if (!options.Contains(NumberGenerated))
                {
                    options.Add(NumberGenerated);
                }
            }
            
            return options;
        }
        private string GetOption(List<int> shuffled, RadioButton rbOption)
        {
            foreach (var item in shuffled)
            {
                if (rbOption.Text == "")
                {
                    rbOption.Text = item.ToString();
                    shuffled.Remove(item);
                   
                    if (item == _QuestionInfo.CorrectAnswer)
                    {
                        rbOption.Tag = "C";
                    }
                    return rbOption.Text;
                }
            }
            return "";
        }
        private void GenerateQuestion()
        {
            switch (_QuestionInfo.QuestionLevel)
            {
                case "Easy":
                    GenerateQuestion(1, 10);
                    break;

                case "Medium":
                    GenerateQuestion(10, 50);

                    break;
                case "Hard":
                    GenerateQuestion(50, 100);

                    break;
                case "Mixed":
                    GenerateQuestion(1,100);
                    break;
            }
        }
        private void GenerateQuestion(int min , int max)
        {
         _QuestionInfo.Number1 = random.Next(min, max).ToString();
         _QuestionInfo.Number2 = random.Next(min, max).ToString();
         _QuestionInfo.OpType = GenerateOperation();
         _QuestionInfo.CorrectAnswer = GetCorrectAnswer(Convert.ToInt32(_QuestionInfo.Number1), Convert.ToInt32(_QuestionInfo.Number2), _QuestionInfo.OpType);
        }
        private string GetRandomOperation()
        {
            string[] operations = { "+","-","*","/"};

            int n = random.Next(operations.Length);

            return operations[n];   
        }
        private string GenerateOperation()
        {
            switch (_QuestionInfo.Operation)
            {
                case "Addition":
                    return "+";
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
            if (_Seconds <= 0)
            {
                QuizTimer.Stop();
                MessageBox.Show("Times Up", "Times Up", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }else
            --_Seconds;
   
               lblTimer.ForeColor = (_Seconds <= 10) ? Color.Red : SystemColors.ControlText;  

                TimeSpan time = TimeSpan.FromSeconds(_Seconds);
                lblTimer.Text = time.ToString(@"hh\:mm\:ss");
                lblTimer.Refresh();
        }
        private void CalculateMarkAndChangeBackground(List<RadioButton> PossibleAnswers)
        {
            foreach (var item in PossibleAnswers)
            {
                if (item.Tag?.ToString() == "C")
                {
                    item.BackColor = Color.Green;
                    if (item.Checked)
                    {
                        _QuestionInfo.QuizMark++;
                    }
                }

                if (item.Tag?.ToString() != "C" && item.Checked)
                {
                    item.BackColor = Color.Red;
                }
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
            Number1.Width = 20;
            Number1.Text = "";
            Number1.Location = new Point(120, 50);

            Label Operation = new Label();
            Operation.Name = "lblOperation";
            Operation.Text = "";
            Operation.Width = 10;
            Operation.Location = new Point(140, 50);

            Label Number2 = new Label();
            Number2.Name = "lblNumber2";
            Number2.Width = 20;
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
            Operation.Text = _QuestionInfo.OpType;
          
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

            PossibleAnswers.Add(Option1);
            PossibleAnswers.Add(Option2);
            PossibleAnswers.Add(Option3);
            PossibleAnswers.Add(Option4);


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
                AddControlsToFlowLayoutPanel(4);
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
            QuizTimer.Stop();
            _frmMainMenu.Show();
            this.Close();
        }
        private void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to finish the quiz?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            lblResultLabel.Visible = true;
            lblResult.Visible = true;
            QuizTimer.Stop();
            CalculateMarkAndChangeBackground(PossibleAnswers);
            lblResult.Text = $"{_QuestionInfo.QuizMark}/{_QuestionInfo.NumberOfQuestions}";
            MessageBox.Show($"you got {_QuestionInfo.QuizMark}/{_QuestionInfo.NumberOfQuestions},Well done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
