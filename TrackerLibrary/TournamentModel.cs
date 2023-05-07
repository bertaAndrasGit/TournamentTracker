using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// The name of the Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The entry fee of the Tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The list of teams that are entered in the Tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The List of the prices
        /// </summary>
        public List<PriceModel> Prices { get; set; } = new List<PriceModel>();

        /// <summary>
        /// Represents a List of MatchupModels in a List
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }


    
}
