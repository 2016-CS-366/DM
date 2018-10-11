using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniPhoneBook.Models
{
    public class contactViewModel
    {
        public int contactId { get; set; }
        public string ContactNumber { get; set; }
        public string Type { get; set; }
        public int PersonId { get; set; }
    }
}