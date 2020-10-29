using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5NIT_ConsApp_Enumeraties
{
    class Program
    {
        //Een zelfgemaakt type dat een aantal vaste waarden meekrijgt.
        enum Weekdagen {Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag };

        enum fighterType {Krijger=1, Priester, Tovenaar, Jager};

        enum leeftijdsCategorie {Kind=12, Tiener=18, Volwassene=60, Gepensioneerde};

        static void Main(string[] args)
        {

            #region Voorbeeld Enumeraties: verkeerde oplossing
            /// 
            /// Oefening 1: Voorbeeld Enumeraties: verkeerde oplossing
            /// 
            Console.WriteLine("Voorbeeld Enumeraties: verkeerde oplossing");
            Console.WriteLine("------------------------------------------");

            Console.Write("Gelieve een dagnummer in te vullen:     ");
            Int16 dagKeuze = Convert.ToInt16(Console.ReadLine());

            if (dagKeuze == 1)
            {
                Console.WriteLine("werkdag");
            }
            else if (dagKeuze == 2)
            {
                Console.WriteLine("baaldag");

            }
            else if (dagKeuze == 3)
            {
                Console.WriteLine("halve dag");

            }
            else if (dagKeuze == 4)
            {
                Console.WriteLine("over halfweg");

            }
            else if (dagKeuze == 5)
            {
                Console.WriteLine("bijna weekend");

            }
            else if (dagKeuze == 6)
            {
                Console.WriteLine("voetbaldag");

            }
            else if (dagKeuze == 7)
            {
                Console.WriteLine("rustdag");

            }


            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Voorbeeld Enumeraties: verkeerde oplossing
            /// 
            /// Oefening 2: Voorbeeld Enumeraties: verkeerde oplossing
            /// 
            Console.WriteLine("Voorbeeld Enumeraties: verkeerde oplossing");
            Console.WriteLine("------------------------------------------");

            Console.Write("Gelieve een dag in te vullen:     ");
            string dagNaam = Console.ReadLine();

            if (dagNaam == "maandag")
            {
                Console.WriteLine("werkdag");
            }
            else if (dagNaam == "dinsdag")
            {
                Console.WriteLine("baaldag");

            }
            else if (dagNaam == "woensdag")
            {
                Console.WriteLine("halve dag");

            }
            else if (dagNaam == "donderdag")
            {
                Console.WriteLine("over halfweg");

            }
            else if (dagNaam == "vrijdag")
            {
                Console.WriteLine("bijna weekend");

            }
            else if (dagNaam == "zaterdag")
            {
                Console.WriteLine("voetbaldag");

            }
            else if (dagNaam == "zondag")
            {
                Console.WriteLine("rustdag");

            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Voorbeeld Eumeraties: goede oplossing
            /// 
            /// Voorbeeld Eumeraties: goede oplossing 
            /// 
            Console.WriteLine("Voorbeeld Eumeraties: goede oplossing");

            Weekdagen gekozenDag;

            gekozenDag = Weekdagen.Zaterdag;

            Console.WriteLine($"De gekozen dag is: {gekozenDag}");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 1: fighterType
            /// 
            /// Oefening 1: fighterType
            /// 
            Console.WriteLine("Oefening 1: fighterType");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Welke type ben je?");
            Console.WriteLine("1: Krijger");
            Console.WriteLine("2: Priester");
            Console.WriteLine("3: Tovenaar");
            Console.WriteLine("4: Jager");

            Int16 gekozenNummer = Convert.ToInt16(Console.ReadLine());

            fighterType gekozenFighter = (fighterType)gekozenNummer;

            Console.WriteLine(gekozenFighter);

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 2: Leeftijdscategorie
            /// 
            /// Oefening 2: Leeftijdscategorie
            /// 
            Console.WriteLine("Oefening 2: Leeftijdscategorie");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Hoe oud ben je (vul enkel jouw leeftijd in, bijv.: 24)?");
            
            Int16 gekozenLeeftijd = Convert.ToInt16(Console.ReadLine());

            if (gekozenLeeftijd < Convert.ToInt16(leeftijdsCategorie.Kind))
            {
                Console.WriteLine(leeftijdsCategorie.Kind);
            }
            else if (gekozenLeeftijd < Convert.ToInt16(leeftijdsCategorie.Tiener))
            {
                Console.WriteLine(leeftijdsCategorie.Tiener);
            }
            else if (gekozenLeeftijd < Convert.ToInt16(leeftijdsCategorie.Volwassene))
            {
                Console.WriteLine(leeftijdsCategorie.Volwassene);
            }
            else
            {
                Console.WriteLine(leeftijdsCategorie.Gepensioneerde);
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 3: de 4 seizoenen
            /// 
            /// Oefening 3: de 4 seizoenen
            /// 
            Console.WriteLine("Oefening 3: de 4 seizoenen");
            Console.WriteLine("--------------------------");


            Console.ReadKey();
            Console.Clear();
            #endregion


        }
    }
}
