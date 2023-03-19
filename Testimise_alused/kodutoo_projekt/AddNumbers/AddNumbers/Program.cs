using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace AddNumbers
{
    // Probleemid:
    //  1. Mis programmi kasutaja käivitas? Kuidas ta sellest aru saab?
    //  2. Programmi käest ei saa küsida abi
    //  3. Tehte vastus ei ole sisendiga samal joonel
    //  4. Programm ei kontrolli kasutaja sisendit (crashib kui kasutaja ei sisestanud täisarvu)
    //     Leitud kontrolli vajavad sisendid:
    //      ■	Kõik mitte täisarvulised väärtused
    //      ■	Kõik mitte arvulised väärtused, s.h.tühikud
    //  5. Kuidas väljuda programmist?
    //  6. Programm ei kontrolli tehteid täisarvu miinimumi juures
    //  7. Programm ei kontrolli tehteid täisarvu maksimumi juures
    //  8. Mitme järjestikuse tehte lugemine on keeruline, kirjeldused, eraldused, loendur

    internal class Program
    {
        private static BigInteger? x1 = null;
        private static BigInteger? x2 = null;
        private static int tehteLoendur = 1;
        private static bool helpOpen;


        static void Main(string[] args)
        {

            // Console.WriteLine("maksimum: " + int.MaxValue + "| miinimum: " + int.MinValue);

            Console.WriteLine("Tervist! See on lihtne liitmisprogramm, mis on võimeline teostama täisarvudega liitmistehteid.");
            Console.WriteLine(
                "KASUTUSJUHIS\n" +
                " Liitmine:\n" +
                    "   Sisesta esimene liidetav ja vajuta 'Enter' klahvi.\n" +
                    "   Sisesta teine liidetav ja vajuta 'Enter' klahvi.\n" +
                    "   Selle järgselt kuvab progamm sulle liitmistehte tulemuse.\n" +
                " Programmi sulgemine:\n" +
                    "   Programmist väljumiseks sulge programmi aken paremalt ülevalt \"X\" nupust või kasuta käsku ctrl + c.\n" +
                    "   Märkus: Programmi sulgemine, mis iganes hetkel on ohutu.\n");

            while (true)
            {
                Console.WriteLine("TEHE " + tehteLoendur);
                BigInteger testBInteger;


                if (x1 == null)
                {
                    Console.Write("Liidetav 1 =>     ");

                    if (BigInteger.TryParse(Console.ReadLine(), out testBInteger))
                    {
                        x1 = testBInteger;
                    }
                    else
                    {
                        BadInputError();
                        continue;
                    }
                        
                }
                if (x2 == null)
                {
                    Console.Write("Liidetav 2 =>     ");

                    if (BigInteger.TryParse(Console.ReadLine(), out testBInteger))
                    {
                        x2 = testBInteger;

                    }
                    else
                    {
                        BadInputError();
                        continue;
                    }
                        
                }

                Console.WriteLine("Tulemus    =>     " + (x1 + x2) + "\n");
                ValuesReset();
                tehteLoendur++;
            }
        }

        public static void ValuesReset()
        {
            x1 = null;
            x2 = null;
        }

        public static void BadInputError()
        {
            Console.WriteLine("VIGA! Viimane sisend polnud täisarv. Palun sisesta ainult täisarve.\n");
            tehteLoendur++;
            ValuesReset();
        }
    }
}