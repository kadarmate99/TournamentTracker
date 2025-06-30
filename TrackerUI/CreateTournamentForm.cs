using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        private readonly IEnumerable<IDataConnection> _dataConnections;

        List<TeamModel> availableTeams = new List<TeamModel>();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm(IEnumerable<IDataConnection> dataConnections)
        {
            InitializeComponent();
            _dataConnections = dataConnections;

            LoadListData();
            UpdateLists();
        }

        private void LoadListData()
        {
            if (_dataConnections.Any())
            {
                availableTeams = _dataConnections.First().GetTeam_All();
            }
            else
            {
                availableTeams = new List<TeamModel>();
            }
        }

        private void UpdateLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel selectedTeam = (TeamModel)selectTeamDropDown.SelectedItem;

            if (selectedTeam != null)
            {
                availableTeams.Remove(selectedTeam);
                selectedTeams.Add(selectedTeam);

                UpdateLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
