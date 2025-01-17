﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// A list of MatchupEntryModels
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner team
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the number of rounds
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
