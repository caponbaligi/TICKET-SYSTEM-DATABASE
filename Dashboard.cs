using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();


        }

          private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }
    
        
        private void insertRecordButon_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text, phoneNumberInsText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailAddressInsText.Text = "";
            phoneNumberInsText.Text = "";
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(lastNameTextbox.Text);

            UpdateBinding();
        }
    }
}
