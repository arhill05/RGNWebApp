using System;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace RGNCompensation.Models
{
    

    public class Player
    {
        public int uid { get; set; }
        public string name { get; set; }
        public string playerid { get; set; }
        public int cash { get; set; }
        public int bankacc { get; set; }
        public string coplevel { get; set; }
        public string cop_licenses { get; set; }
        public string civ_licenses { get; set; }
        public string med_licenses { get; set; }
        public string cop_gear { get; set; }
        public string med_gear { get; set; }
        public string mediclevel { get; set; }
        public int arrested { get; set; }
        public string aliases { get; set; }
        public string adminlevel { get; set; }
        public string donatorlvl { get; set; }
        public string civ_gear { get; set; }
        public int blacklist { get; set; }
       
        //public Byte[] last_connected { get; set; }
    }
}