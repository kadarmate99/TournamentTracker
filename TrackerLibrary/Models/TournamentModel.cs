using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// The name given to this tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The entry fee charged to each team (decimal).
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// The list of teams entered in this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// The list of prizes available in this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Each round (list) contains a set of matchups.
        /// </summary>
        public List<MatchupModel> Rounds { get; set; } = new List<MatchupModel>();
    }
}
