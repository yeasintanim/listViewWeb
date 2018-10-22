using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListViewWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            //string firstName = firstNameTextBox.Text;
            //string midlleName = middleNameTextBox.Text;
            //string lastName = lastNameTextBox.Text;

            if (ViewState["personListVS"] == null)
            {

                Person aPerson = new Person();
                aPerson.firstName = firstNameTextBox.Text;
                aPerson.middleName = middleNameTextBox.Text;
                aPerson.lastName = lastNameTextBox.Text;

                List<Person> personList = new List<Person>();
                personList.Add(aPerson);

                ViewState["personListVS"] = personList;
            }
            else
            {

                Person aPerson = new Person();
                aPerson.firstName = firstNameTextBox.Text;
                aPerson.middleName = middleNameTextBox.Text;
                aPerson.lastName = lastNameTextBox.Text;

                List<Person> personList = (List<Person>)ViewState["personListVS"];
                personList.Add(aPerson);

                ViewState["personListVS"] = personList;

            }  
      
            firstNameTextBox.Text = String.Empty;
            middleNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;            
        }

        protected void showFullNameButton_Click(object sender, EventArgs e)
        {
            fullNameListBox.Items.Clear();

            List<Person> personList = (List<Person>)ViewState["personListVS"];

            foreach (Person person in personList)
            {
                string fullName = person.GetFullName();

                fullNameListBox.Items.Add(fullName);
            }
        }
    }
}