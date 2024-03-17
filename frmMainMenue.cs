using Microsoft.Win32;
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
    public partial class frmMainMenue : Form
    {
        public frmMainMenue()
        {
            InitializeComponent();
        }

        public struct stQuestionData
        {
            public int NumberOfQuestions;
            public string QuestionLevel;
            public string Operation;
            public string Timer;
        }

        stQuestionData QuestionData;
        private stQuestionData ReadQuestionInfo()
        {
            stQuestionData QuestionData;
            QuestionData.NumberOfQuestions = (int)NumberOfQuestions.Value;
            QuestionData.QuestionLevel = cbLevel.Text;
            QuestionData.Operation = cbOperation.Text;
            QuestionData.Timer = cbTimer.Text;
            return QuestionData;
        }
        private void frmMainMenue_Load(object sender, EventArgs e)
        {
            NumberOfQuestions.Value = 1;
            cbLevel.SelectedIndex = 0;
            cbOperation.SelectedIndex = 0;
            cbTimer.SelectedIndex = 0;

        }
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            QuestionData = ReadQuestionInfo();




            this.Hide();
            frmQuiz frmQuiz = new frmQuiz(this , QuestionData);

            frmQuiz.ShowDialog();
        }

    }
}
