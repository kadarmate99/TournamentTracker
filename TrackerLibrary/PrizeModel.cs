using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The place number (e.g. 1 for first place).
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The name for this place (e.g. Champion).
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The fixed monetary amount awarded.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The prize as a percentage of the entry fees.
        /// </summary>
        public string PrizePercentage { get; set; }
    }
}
