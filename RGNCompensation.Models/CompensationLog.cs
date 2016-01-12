using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RGNCompensation.Models
{
    public class CompensationLog
    {
        public int reimburse_id { get; set; }
        public int reimburse_amount { get; set; }
        public double reimburse_player_id { get; set; }
        public string reimburse_justification { get; set; }
        public string reimburse_admin { get; set; }
        //public string reimburse_timestamp { get; set; }

    }
}