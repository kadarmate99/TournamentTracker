using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The person’s first name.
        /// </summary>
        public string  FirstName { get; set; }
        /// <summary>
        /// The person’s last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The person’s email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The person’s cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
