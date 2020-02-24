using System;
using System.ComponentModel.DataAnnotations;

namespace LO.MyAirport.EF
{
    public class Vol
    {
        [Key]
        public int VolId { get; set; }
        public int CIE { get; set; }
        public String LIG { get; set; }
        public Int16 JEX { get; set; }
        public DateTime DHC { get; set; }
        public String PKG { get; set; }
        public String IMM { get; set; }
        public Int16 PAX { get; set; }
        public String DES { get; set; }
    }
}
