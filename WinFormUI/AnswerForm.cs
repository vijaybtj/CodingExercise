using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class AnswerForm : Form
    {
        public String user;
        public int quesCount=0;
        List<SecAnswersModel> lstSecAns = new List<SecAnswersModel>();

        public AnswerForm(String userId)
        {
            InitializeComponent();
            LoadQuestion(userId);
            user = userId;
        }

        private void LoadQuestion(String userId)
        {
            lstSecAns = SqliteDataAccess.GetSecurityQuestionAnswers(userId);

            if (lstSecAns.Count > 0)
            {
                SecAnswersModel secAnswer = lstSecAns[quesCount];

                label1.Text = secAnswer.Question;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quesCount < 3 && textBox1.Text == lstSecAns[quesCount].Answer)
            {
                DialogResult intResponse;
                //MessageBox.Show("Congratulations " + user + " !! You will be routed to main page", "Title");
                intResponse = MessageBox.Show("Congratulations " + user + " !! Do you want to update the answers?", "Correct Answer", MessageBoxButtons.YesNo);
                //PeopleForm pf = new PeopleForm();
                //pf.ShowDialog();
                //MessageBox.Show("Response " + intResponse, "Title");
                if (intResponse == DialogResult.Yes)
                {
                    UpdateSecurityQuestions frmupdSecurityQuestions = new UpdateSecurityQuestions(lstSecAns);
                   // frmupdSecurityQuestions.personName = firstNameText.Text;
                    frmupdSecurityQuestions.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
                
            } 
            else
            {
                label2.Text = "Incorrect answer, please try another security question";
                if (quesCount < 3)
                {
                    quesCount++;
                } 
                else
                {
                    quesCount = 2;
                }
                LoadNextQuestion();
            }

        }

        private void LoadNextQuestion()
        {

            if (lstSecAns.Count > 0 && quesCount<3)
            {
                SecAnswersModel secAnswer = lstSecAns[quesCount];

                label1.Text = secAnswer.Question;

                textBox1.Text = "";
            } 
            else
            {
                MessageBox.Show("All your security questions answers are wrong, please try again later !!","Title");
                this.Close();
            }


        }

        private void AnswerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
