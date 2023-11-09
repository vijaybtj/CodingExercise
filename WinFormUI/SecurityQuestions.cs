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
using System.Windows.Forms.VisualStyles;

namespace WinFormUI
{
    public partial class SecurityQuestions : Form
    {
        List<QuestionsModel> questions = new List<QuestionsModel>();
        public string personName;
        public int personId;

        public SecurityQuestions()
        {
            InitializeComponent();

            LoadSecurityQuestionsList();
        }

        private void LoadSecurityQuestionsList()
        {

            WireUpQuestionList1();
            WireUpQuestionList2();
            WireUpQuestionList3();
        }

        private void WireUpQuestionList1()
        {
            questions = SqliteDataAccess.LoadSecurityQuestions();

            cmbQuestion1.DataSource = null;
            cmbQuestion1.DataSource = questions;
            cmbQuestion1.DisplayMember = "Questionnaire";

        }

        private void WireUpQuestionList2()
        {
            questions = SqliteDataAccess.LoadSecurityQuestions();

            cmbQuestion2.DataSource = null;
            cmbQuestion2.DataSource = questions;
            cmbQuestion2.DisplayMember = "Questionnaire";

        }

        private void WireUpQuestionList3()
        {
            questions = SqliteDataAccess.LoadSecurityQuestions();

            cmbQuestion3.DataSource = null;
            cmbQuestion3.DataSource = questions;
            cmbQuestion3.DisplayMember = "Questionnaire";
        }

        private void SecurityQuestions_Load(object sender, EventArgs e)
        {

        }

        private void cmbQuestion1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAnswer1.Text.Trim() != "" && txtAnswer2.Text.Trim() != "" && txtAnswer3.Text.Trim() != "")
            {
                String msg;
                List<SecAnswersModel> lstSam = new List<SecAnswersModel>();
                SecAnswersModel sam1 = new SecAnswersModel();
                sam1.QuestionId = cmbQuestion1.SelectedIndex;
                sam1.Answer = txtAnswer1.Text;

                SecAnswersModel sam2 = new SecAnswersModel();
                sam2.QuestionId = cmbQuestion2.SelectedIndex;
                sam2.Answer = txtAnswer2.Text;

                SecAnswersModel sam3 = new SecAnswersModel();
                sam3.QuestionId = cmbQuestion3.SelectedIndex;
                sam3.Answer = txtAnswer3.Text;

                lstSam.Add(sam1);
                lstSam.Add(sam2);
                lstSam.Add(sam3);


                msg = SqliteDataAccess.SaveSecurityAnswers(lstSam, personName);

               

                if (msg != "Success")
                {
                    DialogResult intResponse;
                    intResponse = MessageBox.Show(msg + "  Do you want to try again?", "Save Status", MessageBoxButtons.YesNo);
                    if (intResponse == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("All changes Saved successfully", "Save Status");
                    this.Close();
                }
            }
            else
            { MessageBox.Show("Please enter answer for all 3 questions", "Missing Answer"); }

        }

        private void cmbQuestion2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbQuestion3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
