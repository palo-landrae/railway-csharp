using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    public class Ticket
    {
        private int Id { get; set; }
        private int Category { get; set; }
        private string Type { get; set; }
        private int RouteId { get; set; }
        private DateTime ExpirationDate { get; set; }
    }
}
