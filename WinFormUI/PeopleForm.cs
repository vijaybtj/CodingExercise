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

    public partial class PeopleForm : Form
    {

        

        List<PersonModel> people = new List<PersonModel>();

        public PeopleForm()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {

        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if ((firstNameText.Text.Trim()) != "")
            {
                PersonModel p = new PersonModel();

                p.UserId = firstNameText.Text;
                int count = 0;
                count = SqliteDataAccess.SearchPerson(p);

                if (count == 0)
                {
                    SecurityQuestions frmSecurityQuestions = new SecurityQuestions();
                    frmSecurityQuestions.personName = firstNameText.Text;
                    frmSecurityQuestions.ShowDialog();
                }
                else
                {
                    AnswerForm answerForm = new AnswerForm(firstNameText.Text);
                    answerForm.ShowDialog();

                }

                firstNameText.Text = "";
            }
            else { MessageBox.Show("Please enter UserName", "Missing Name"); }
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }


        private void listPeopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
