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

        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm(IEnumerable<IDataConnection> dataConnections)
        {
            InitializeComponent();
            _dataConnections = dataConnections;

            // CreateSampleData();

            LoadListData();
            UpdateMemberLists();
        }

        private void LoadListData()
        {
            if (_dataConnections.Any())
            {
                availableTeamMembers = _dataConnections.First().GetPerson_All();
            }
            else
            {
                availableTeamMembers = new List<PersonModel>();
            }
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Coerey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }

        private void UpdateMemberLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

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

                selectedTeamMembers.Add(newPerson);
                UpdateMemberLists();

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

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel selectedPerson = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (selectedPerson != null)
            {
                availableTeamMembers.Remove(selectedPerson);
                selectedTeamMembers.Add(selectedPerson);

                UpdateMemberLists();
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel selectedPerson = (PersonModel)teamMembersListBox.SelectedItem;

            if (selectedPerson != null)
            {
                selectedTeamMembers.Remove(selectedPerson);
                availableTeamMembers.Add(selectedPerson);

                UpdateMemberLists();
            }

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = new TeamModel();

            team.TeamName = teamNameValue.Text;
            team.TeamMembers = selectedTeamMembers;

            foreach (IDataConnection dataConnection in _dataConnections)
            {
                dataConnection.CreateTeam(team);
            }

            // TODO - If we aren't closing this form after creation, reset the form.
        }
    }
}
