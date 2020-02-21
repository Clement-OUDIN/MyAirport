using System;

namespace LO.MyAirport.EF
{
    public class Bagage
    {
        public int BagageId { get; set; }
        //virtual Vol vol { get; set; }
        public int VolId { get; set; }
        public String CODE_IATA { get; set; }
        public int DATE_CREATION { get; set; }
        public String CLASSE { get; set; }
        public String PKG { get; set; }
        public String IMM { get; set; }
        public int PAX { get; set; }
        public String DES { get; set; }
    }
}
