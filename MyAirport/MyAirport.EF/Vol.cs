using System;
using System.Collections.Generic;

namespace LO.MyAirport.EF
{
    /// <summary>
    /// Classe Vol, représente une instance de Vol
    /// </summary>
    public class Vol
    {
        /// <summary>
        /// Clé Primaire de ma class Vol
        /// </summary>
        public int? VolId { get; set; }
        /// <summary>
        /// Compagnie du vol
        /// </summary>
        public string Cie { get; set; }
        /// <summary>
        /// Ligne du vol
        /// </summary>
        public string Lig { get; set; }
        /// <summary>
        /// Dernier horaire connu, horaire de départ du col
        /// </summary>
        public DateTime Dhc { get; set; }
        /// <summary>
        /// Parking affecté au vol
        /// </summary>
        public string? Pkg { get; set; }
        /// <summary>
        /// N° immatriculation de l'avion
        /// </summary>
        public string? Imm { get; set; }
        /// <summary>
        /// Nombre de passager du vol
        /// </summary>
        public int? Pax { get; set; }
        /// <summary>
        /// Destination finale du vol
        /// </summary>
        public string? Des { get; set; }
        /// <summary>
        /// Propriété de naviguation
        /// </summary>
        public IEnumerable<Bagage>? Bagages { get; set; }


        /// <summary>
        /// Constructeur d'une instance de vol
        /// </summary>
        /// <param name="compagnie"></param>
        /// <param name="ligne"></param>
        /// <param name="dhc"></param>
        public Vol(string compagnie, string ligne, DateTime dhc)
        {
            Cie = compagnie;
            Lig = ligne;
            Dhc = dhc;
            // Bagages = null;//new List<Bagage>();
        }

        public Vol()
        {
        }


    }
}
