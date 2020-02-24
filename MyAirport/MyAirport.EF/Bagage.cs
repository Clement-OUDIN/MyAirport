using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LO.MyAirport.EF
{
    public class Bagage
    {
        [Key]
        public int BagageId { get; set; }
        public Vol Vol { get; set; }
        [ForeignKey("VolId")]
        public int VolId { get; set; }
        public String CODEIATA { get; set; }
        public DateTime DATECREATION { get; set; }
        public char CLASSE { get; set; }
        public String SSUR { get; set; }
        public String Destination { get; set; }
        public int Escale{ get; set; }
    }
}
