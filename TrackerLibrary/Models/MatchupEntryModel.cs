﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score of this team in the matchup.
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team  came from as a winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
