using System;
using System.Linq;
using LO.MyAirport.EF;
using MyAirport.EF;

namespace LO.MyAirport.console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            MyAirportDB Roissy = new MyAirportDB();
            System.Console.WriteLine("MyAirport project bonjour!!");
            using (var db = new MyAirportDB())
            {
                // Create
                Console.WriteLine("Création du vol LH1232");
                Vol v1 = new Vol
                {
                    CIE = "LH",
                    DES = "BKK",
                    DHC = Convert.ToDateTime("14/01/2020 16:45"),
                    IMM = "RZ62",
                    LIG = "1232",
                    PKG = "R52",
                    PAX = 238
                };
                db.Add(v1);

                Console.WriteLine("Creation vol SQ333");
                Vol v2 = new Vol
                {
                    CIE = "SK",
                    DES = "CDG",
                    DHC = Convert.ToDateTime("14/01/2020 18:20"),
                    IMM = "TG43",
                    LIG = "333",
                    PKG = "R51",
                    PAX = 423
                };
                db.Add(v2);

                Console.WriteLine("creation du bagage 012387364501");
                Bagage b1 = new Bagage
                {
                    CLASSE = 'Y',
                    CODEIATA = "012387364501",
                    DATECREATION = Convert.ToDateTime("14/01/2020 12:52"),
                    Destination = "BEG"
                };
                db.Add(b1);

                db.SaveChanges();
                Console.ReadLine();

                // Read
                Console.WriteLine("Voici la liste des vols disponibles");
                var vol = db.Vols
                    .OrderBy(v => v.CIE);
                foreach (var v in vol)
                {
                    Console.WriteLine($"Le vol {v.CIE}{v.LIG} N° {v.VolId} a destination de {v.DES} part à {v.DHC} heure");
                }
                Console.ReadLine();

                // Update
                //Console.WriteLine($"Le bagage {b1.BagageID} est modifié pour être rattaché au

            }
        }
    }
}
