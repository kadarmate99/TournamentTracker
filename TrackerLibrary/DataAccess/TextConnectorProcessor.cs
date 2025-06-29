using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //PrizeModel.csv
        {
            // D:\Programing projects\02_Tutorial_Projects\TimCorey_TournamentTracker\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> prizeModels = new List<PrizeModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                prizeModels.Add(p);
            }
            return prizeModels;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> personModels = new List<PersonModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                personModels.Add(p);
            }
            return personModels;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            //id,team name, list of ids separeted by |
            //3,Máté's team,1|3|5

            List<TeamModel> teamModels = new List<TeamModel>();
            List<PersonModel> personModels = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();


            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel team = new TeamModel();
                team.Id = int.Parse(cols[0]);
                team.TeamName = cols[1];

                string[] personIDs = cols[2].Split('|');

                foreach (string personID in personIDs)
                {
                    // Find the person in the list of person models whose Id matches the current personID,
                    // then add that person to the team's TeamMembers list.
                    // `personModels.Where(...)` filters the list to match the ID,
                    // and `.First()` retrieves the first (and only) matching person.
                    team.TeamMembers.Add(personModels.Where(x => x.Id == int.Parse(personID)).First());
                }

                teamModels.Add(team);
            }
            return teamModels;
        }

        public static void SaveToPrizeModelsFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel prize in models)
            {
                lines.Add($"{prize.Id},{prize.PlaceNumber},{prize.PlaceName},{prize.PrizeAmount},{prize.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPersonModelsFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel person in models)
            {
                lines.Add($"{person.Id},{person.FirstName},{person.LastName},{person.EmailAddress},{person.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamModelsFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel team in models)
            {
                lines.Add($"{team.Id},{team.TeamName},{ConvertPersonModelsToString(team.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPersonModelsToString(List<PersonModel> personModels)
        {
            string personModelsString = "";

            // If there are no person models, return an empty string
            if (personModels.Count == 0)
            {
                return "";
            }

            foreach (PersonModel person in personModels)
            {
                personModelsString += $"{person.Id}|";
            }
            personModelsString =  personModelsString.Substring(0, personModelsString.Length - 1); // remove the last '|'
            
            return personModelsString;
        }
    }
}
