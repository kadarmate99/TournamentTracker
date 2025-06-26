using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private readonly IEnumerable<IDataConnection> _dataConnections;

        public CreateTeamForm(IEnumerable<IDataConnection> dataConnections)
        {
            InitializeComponent();
            _dataConnections = dataConnections;
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                PersonModel newPerson = new PersonModel();

                newPerson.FirstName = firstNameValue.Text;
                newPerson.LastName = lastNameValue.Text;
                newPerson.EmailAddress = emailValue.Text;
                newPerson.CellphoneNumber = cellphoneValue.Text;

                foreach (IDataConnection dataConnection in _dataConnections)
                {
                    dataConnection.CreatePerson(newPerson);
                }

                // restore default values on from if validation was successfull
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields!");
            }
        }

        private bool IsFormValid()
        {
            // TODO - Add validation to the form
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }       
            
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
