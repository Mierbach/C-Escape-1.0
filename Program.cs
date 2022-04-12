using System;

namespace C_SharpEscape1
{
    class Program
    {
        static void Main()
        {
            Console.Title = "C# Escape 1.0";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            int eingabe = 0;
            do
            {
                MenuAnzeigen();
                eingabe = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Menu(eingabe);
            } while (eingabe != 4);
                        
        }

        static void Methode2()
        {
            Console.WriteLine();
            Console.WriteLine("Du bist entkommen!!!");
            Console.WriteLine();
            Console.WriteLine("_______@@___@@_________");
            Console.WriteLine("_______@@___@@_________");
            Console.WriteLine("_______@@___@@_________");
            Console.WriteLine("_@____ @@___@@______@__");
            Console.WriteLine("_@____ @@___@@______@__");
            Console.WriteLine("__@_________________@___");
            Console.WriteLine("___@_______________@____");
            Console.WriteLine("_____@___________@______");
            Console.WriteLine("_______@@@@@@________");


        }

        static void MenuAnzeigen()                                                  // Menu Inhalt Text
        {
            Console.Clear();
            Console.WriteLine("  ___               ___");
            Console.WriteLine(" |   |             |   |  ");
            Console.WriteLine("(_____)           (_____)  ");
            Console.WriteLine(" |   |  _   _   _  |   |   ");
            Console.WriteLine(" | O |_| |_| |_| |_| O |   ");
            Console.WriteLine(" | - | _           | - |   ");
            Console.WriteLine(" | O | -_ ^ _ |    | O |   ");
            Console.WriteLine(" | _ |    //|\\  -  |   |   ");
            Console.WriteLine(" |   |   ///|\\|    |  -|   ");
            Console.WriteLine(" | - | _ |||||||   |   |   ");
            Console.WriteLine(" |   |   |||||||   | - |   ");
            Console.WriteLine(" |___|___|||||||___|___|   ");
            Console.WriteLine("         (      (   ");
            Console.WriteLine("          \\     \\   ");
            Console.WriteLine("");
            Console.WriteLine("Willkommen bei C# Escape 1.0");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Spiel starten");
            Console.WriteLine("2. Spiel Info");
            Console.WriteLine("3. Beenden");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("Warte auf Eingabe: ...");
            


        }


        static void Menu(int eingabe)                                               //Menu Inhalt Funktion
        {
            switch(eingabe)
            {
                case 1: Escape();
                    break;
                case 2: Info();
                    break;
                case 3: break;
                default: Console.WriteLine("Kein korrekte Auswahl!");
                    break;

            }
            if(eingabe != 4)
            {
                Console.Write("Drücken Sie eine beliebige Taste ...");
                Console.ReadKey();
            }
        }

        static void Info()
        {
            Console.WriteLine("");
            Console.WriteLine("Du bist in dem Schloss gefangen. Es gibt nur einen Weg nach draußen.");
            Console.WriteLine("Du brauchst beide Codes für die Tür um zu entkommen");
            Console.WriteLine("");
            Console.WriteLine("Alles was du bei dir hast ist ein Stück Papier mit kryptischen Zeichen.");
            Console.WriteLine("Papier: ");
            Console.WriteLine("Viel Erfolg!");
            Console.WriteLine("");
        }


        static void Escape()
        {
            int ergebnisRueckgabe = Methode13();
            var a = ergebnisRueckgabe;
            if (a == 10000)
            {
                Methode2();
            }
            else
            {
                Console.WriteLine("Die Tür bleibt verschlossen!");
                Console.WriteLine();
                Console.WriteLine("Bitte drücken Sie Enter zum zurückkehren");
                Console.ReadKey();
                Main();
            }
            Console.ReadKey();

        }

        
        static int Methode13()
        {
            int zahl1, zahl2, summe;
            Console.Write("Bitte geben Sie den 1. Tür Code ein: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie den 2. Tür Code ein: ");
            zahl2 = Convert.ToInt32(Console.ReadLine());
            summe = zahl1 + zahl2;
            
            return summe;
        }
    }



}
