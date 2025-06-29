using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {


        // TODO - Make the CreatePrize method actually save to the SQL database.
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The Prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
           throw new NotImplementedException();
        }

        // TODO - Make the CreatePerson method actually save to the SQL database.
        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Make the GetPerson_All method actually retrieve all persons from the SQL database.
        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException();
        }

        // TODO - Make the CreateTeam method actually save to the SQL database.
        public TeamModel CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }
    }
}
