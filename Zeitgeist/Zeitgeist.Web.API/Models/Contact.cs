using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeitgeist.Web.API.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string SkypeName { get; set; }
        public bool IsPrimaryContact { get; set; }
        public bool IsBillingContact { get; set; }
        public bool IsTimeSheetContact { get; set; }
    }
}
