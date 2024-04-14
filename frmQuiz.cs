using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
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
            if (shuffled.Count > 0)
            {
                int item = shuffled[0];
                rbOption.Text = item.ToString();
                shuffled.RemoveAt(0);
                if (item == _QuestionInfo.CorrectAnswer)
                {
                    rbOption.Tag = "C";
                }
                return rbOption.Text;
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
                } else if (item.Checked)
                {
                    item.BackColor = Color.Red;
                }
            }

        }
      
        private GroupBox CreateGroupBox(int i)
        {
            GroupBox groupBox = new GroupBox
            {
                Name = "gbQuestionInfo" + i,
                Text = "Q0" + i,
                Height = 220,
                Width = 250
            };
        return groupBox;
        }
        private void AddLabelsAndRadioButtons(GroupBox groupBox,List<int> shuffled)
        {
            Label Number1 = new Label
            {
             Name = "lblNumber1",
             Width = 20,
             Text = _QuestionInfo.Number1,
             Location = new Point(120, 50)
           };

            Label Operation = new Label
            {
              Name = "lblOperation",
              Text = _QuestionInfo.OpType,
              Width = 10,
              Location = new Point(140, 50)
            };

            Label Number2 = new Label
            {
                Name = "lblNumber2",
                Width = 20,
                Text = _QuestionInfo.Number2,
                Location = new Point(160, 50)
            };

            Label Equality = new Label
            {
                Name = "lblEquality",
                Text = "=",
                Width = 10,
                Location = new Point(180, 50)
            };

            var labels = new[] { Number1,Operation,Number2,Equality };

            groupBox.Controls.AddRange(labels);

            for (int i = 1;i <= 4; i++)
            {
                RadioButton Option = new RadioButton
                {
                    Name = "rbOption" + i,
                    Height = 20,
                    Width = 50,
                    Location = new Point(10, 70 + i * 30)

                };
                Text = GetOption(shuffled, Option);
                groupBox.Controls.Add(Option);
                PossibleAnswers.Add(Option);
            }
        }
        private void AddControlsToFlowLayoutPanel(int i)
        {
            GroupBox groupBox = CreateGroupBox(i);
        
            GenerateQuestion();

            var options = GenerateQuestionOptions();
            var shuffled = ShuffleList(options);
            AddLabelsAndRadioButtons(groupBox, shuffled);
            flowLayoutPanel1.Controls.Add(groupBox);
        }
        private void GenerateDynamicQuestions()
        {
            for (int i = 1; i <= _QuestionInfo.NumberOfQuestions; i++)
            {
                Thread.Sleep(100);
                this.Invoke((MethodInvoker)delegate
                {
                    AddControlsToFlowLayoutPanel(i);
                });
            }
        }
        private async void frmQuiz_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                GenerateDynamicQuestions();
            });


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

            int TotalQuestions = _QuestionInfo.NumberOfQuestions;
            int CorrectAnswers = _QuestionInfo.QuizMark;

            lblResult.Text = $"{CorrectAnswers}/{TotalQuestions}";
            MessageBox.Show($"you got {CorrectAnswers}/{TotalQuestions},Well done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
