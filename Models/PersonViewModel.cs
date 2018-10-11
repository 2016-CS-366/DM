using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniPhoneBook.Models
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public int MiddleName { get; set; }
        public int LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AddedOn { get; set; }
        public string  AddedBy{ get; set; }
        public string FaceBookId { get; set; }
        public string HomeAddress { get; set; }
        public string HomeCity { get; set; }
        public string LinkedInId { get; set; }

        public DateTime UpdateOn { get; set; }

        public string TwitterId { get; set; }
        public string EmailId { get; set; }







    }
}