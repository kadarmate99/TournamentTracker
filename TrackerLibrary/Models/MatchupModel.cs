using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The teams competing in this matchup (list).
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// The team that won this matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// The round number this matchup occurs in.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
