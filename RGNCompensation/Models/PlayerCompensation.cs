using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RGNCompensation.Models
{
    public class PlayerCompensation
    {
        public Player Player { get; set; }
        public CompensationLog CompensationLog { get; set; }

    }
}