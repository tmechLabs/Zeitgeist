using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeitgeist.Web.API.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
    }
 }
