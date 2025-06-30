using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizeModelsFile = "PrizeModels.csv";
        private const string PersonModelsFile = "PersonModels.csv";
        private const string TeamModelsFile = "TeamModels.csv";


        /// <summary>
        /// Saves a new prize to the text file.
        /// </summary>
        /// <param name="prizeModel">The Prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel prizeModel)
        {
            // Load text file (as a list<string>)
            // Convert the text to List>PrizeModel>
            List<PrizeModel> prizes = PrizeModelsFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find max ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;

            }
            prizeModel.Id = currentId;

            // Add the new record with the new ID (max +1)
            prizes.Add(prizeModel);

            // Convert the prizes to list<string>
            // Save the list<string> to the text file
            prizes.SaveToPrizeModelsFile(PrizeModelsFile);

            return prizeModel;
        }

        public PersonModel CreatePerson(PersonModel personModel)
        {
            List<PersonModel> PersonModels = PersonModelsFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (PersonModels.Count > 0)
            {
                currentId = PersonModels.OrderByDescending(x => x.Id).First().Id + 1;
            }

            personModel.Id = currentId;

            PersonModels.Add(personModel);

            PersonModels.SaveToPersonModelsFile(PersonModelsFile);

            return personModel;

        }

        public List<PersonModel> GetPerson_All()
        {
            return PersonModelsFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public TeamModel CreateTeam(TeamModel teamModel)
        {
            List<TeamModel> teamModels = TeamModelsFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonModelsFile);

            int currentId = 1;
            if (teamModels.Count > 0)
            {
                currentId = teamModels.OrderByDescending(x => x.Id).First().Id + 1;
            }

            teamModel.Id = currentId;

            teamModels.Add(teamModel);

            teamModels.SaveToTeamModelsFile(TeamModelsFile);

            return teamModel;
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamModelsFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonModelsFile);
        }
    }
}
