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
        private void frmMainMenue_Load(object sender, EventArgs e)
        {
            nNumberOfQuestions.Value = 1;
            cbLevel.SelectedIndex = 0;
            cbOperation.SelectedIndex = 0;
            cbTimer.SelectedIndex = 0;


        }
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuiz frmQuiz = new frmQuiz(this , (int) nNumberOfQuestions.Value,cbLevel.Text,cbOperation.Text, cbTimer.Text);

            frmQuiz.ShowDialog();
        }

    }
}
