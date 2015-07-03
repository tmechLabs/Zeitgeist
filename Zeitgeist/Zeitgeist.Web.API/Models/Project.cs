using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeitgeist.Web.API.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Customer Agent { get; set; }
        public decimal Rate { get; set; }
        public string InvoiceCurrency { get; set; }
        public int TargetHoursPerWeek { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ProjectedEndDate { get; set; }
    }
}
