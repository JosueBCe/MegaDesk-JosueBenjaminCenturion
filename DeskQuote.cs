using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_JosueBenjaminCenturion
{
    public enum RushDays
    {
     ThreeDays = 3,
     FiveDays = 5,
     SevenDays = 7,
     NormalDays = 14,

    }
    public class DeskQuote
    {

        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public string CustomerName { get; set; }
        public string Date { get; set; }

        public DeskQuote(Desk desk, int rushDays, string customerName, string date)
        {
            this.Desk = desk;
            this.RushDays = rushDays;
            this.CustomerName = customerName;
            this.Date = date;
        }

    }
}
