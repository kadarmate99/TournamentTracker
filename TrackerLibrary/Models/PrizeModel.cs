using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
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
        public double PrizePercentage { get; set; }

        public PrizeModel() 
        {
        
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
