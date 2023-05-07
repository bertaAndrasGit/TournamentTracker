using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PriceModel
    {
        /// <summary>
        /// Represents the number of the price
        /// </summary>
        /// <example 1,2,3,4,5,etc.></example>
        public int PriceNumber { get; set; }

        /// <summary>
        /// Represents the name of the price
        /// </summary>
        public string PriceName { get; set; }

        /// <summary>
        /// The amount of the price
        /// </summary>
        public decimal PriceAmount { get; set; }


        /// <summary>
        /// Represents the Precentage of the price from the Total Tournament income
        /// </summary>
        public double PricePrecentage { get; set; }
    }
}
