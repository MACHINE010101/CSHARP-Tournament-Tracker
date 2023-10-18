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
        /// Represents the person first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the person last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the person email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the person cellphone Number
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
