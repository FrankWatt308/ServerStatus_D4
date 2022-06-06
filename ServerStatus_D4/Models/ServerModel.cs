using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerStatus_D4.Models
{
    public class ServerModel
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set;  }

        public DateTime Startdate { get; set; }

        public DateTime EndDate { get; set; }
        public int RefineType { get; set; }
        public int Handled { get; set; }
        public DateTime  ScheduledTime { get; set; }

        public int Level { get; set; }
       


    }
}
