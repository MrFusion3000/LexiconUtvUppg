using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace LexiconUtvUppg
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Exercize = new Exercize("Amazing OldSkool");
            Exercize.Menu1();
        }
    }

    class Exercize
    {
        private string name;

        public Exercize(string _name)
        {
            name = _name;
        }

        public void Menu1()
        { // * Huvudmenyn listar alla grundalternativ för programmet
            Console.SetWindowSize(100, 40);             // Sätt fönsterstorleken till 100 b, 40 h

            int antalMenyval = 9;                      // initiera antal menyval på huvudmenyn
            int menyVal;                            // initiera heltalsvariabel menyVal för användarinput

            for (int i = 1; i <= name.Length; i += 1)
            {
                name = name.Insert(i, " ");
                i++;
            }

            // *** Switch och case med do-while-loop så länge menyVal är annat än 0
            do
            {
                Console.Clear();                        // Rensa skärmen
                Console.WriteLine("* ** *** H U V U D M E N Y (1/2) *** ** *\n");
                Console.WriteLine("Välj ett alternativ (och tryck Enter):\n");
                Console.WriteLine("1. Uppg  1 - Hello World!");
                Console.WriteLine("2. Uppg  2 - Input/Output");
                Console.WriteLine("3. Uppg  3 - Ändra textfärg");
                Console.WriteLine("4. Uppg  4 - Dagens datum");
                Console.WriteLine("5. Uppg  5 - Störst tal av två");
                Console.WriteLine("6. Uppg  6 - Gissa talet");
                Console.WriteLine("7. Uppg  7 - Skriv textsträng till fil");
                Console.WriteLine("8. Uppg  8 - Läs textsträng från fil\n");
                Console.WriteLine("9. Övning 9-16 \n\n");
                Console.WriteLine("0. Avsluta \n");

                menyVal = Check_Valid(antalMenyval);   // Kontroll av godkända tecken och blockering av annat än siffror

                switch (menyVal)
                {
                    case 1:
                        Uppg1();
                        break;
                    case 2:
                        Uppg2();
                        break;
                    case 3:
                        Uppg3();
                        break;
                    case 4:
                        Uppg4();
                        break;
                    case 5:
                        Uppg5();
                        break;
                    case 6:
                        Uppg6();
                        break;
                    case 7:
                        Uppg7();
                        break;
                    case 8:
                        Uppg8();
                        break;
                    case 9:
                        Menu2();
                        break;
                    case 0:                             // Val 0, ger meddelande till användaren och avslutar programmet.
                        Console.WriteLine("Du har avslutat programmet.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Felaktigt val. Endast menyval mellan 0 - " + (antalMenyval--) + " är giltiga.");
                        break;
                }

            } while (menyVal != 0);
        } // **** End Run() ****

        public void Menu2()
        { // * Huvudmenyn listar alla grundalternativ för programmet
            Console.SetWindowSize(100, 40);         // Sätt fönsterstorleken till 100 b, 40 h

            int antalMenyval = 9;                   // initiera antal menyval på huvudmenyn
            int menyVal;                            // initiera heltalsvariabel menyVal för användarinput

            // *** Switch och case med do-while-loop så länge menyVal är annat än 0
            do
            {
                Console.Clear();                    // Rensa skärmen
                Console.WriteLine("* ** *** H U V U D M E N Y (2/2) *** ** *\n");

                Console.WriteLine("Välj ett alternativ (och tryck Enter):\n");
                Console.WriteLine("1. Uppg  9 - Roten ur det onda");
                Console.WriteLine("2. Uppg 10 - Multiplikationstabella', ella', ella'");
                Console.WriteLine("3. Uppg 11 - 2 Arrayer; 1 slumpad, 1 sorterad");
                Console.WriteLine("4. Uppg 12 - Michael Palin-drome");
                Console.WriteLine("5. Uppg 13 - Mellanliggande tal");
                Console.WriteLine("6. Uppg 14 - Sortera Udda/Jämna");
                Console.WriteLine("7. Uppg 15 - Addera tal");
                Console.WriteLine("8. Uppg 16 - En fråga om Klass eller en Klassfråga?\n");
                Console.WriteLine("9. Övning 1-9 \n\n");
                Console.WriteLine("0. Avsluta \n");

                menyVal = Check_Valid(antalMenyval);   // Kontroll av godkända tecken och blockering av annat än siffror

                switch (menyVal)
                {
                    case 1:
                        Uppg9();
                        break;
                    case 2:
                        Uppg10();
                        break;
                    case 3:
                        Uppg11();
                        break;
                    case 4:
                        Uppg12();
                        break;
                    case 5:
                        Uppg13();
                        break;
                    case 6:
                        Uppg14();
                        break;
                    case 7:
                        Uppg15();
                        break;
                    case 8:
                        Uppg16();
                        break;
                    case 9:
                        Menu1();
                        break;
                    case 0:                             // Val 0, ger meddelande till användaren och avslutar programmet.
                        Console.WriteLine("Du har avslutat programmet.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Felaktigt val. Endast menyval mellan 0 - " + (antalMenyval--) + " är giltiga.");
                        break;
                }

            } while (menyVal != 0);
        } // **** End Run() ****

        // **** Kontroll av godkända tecken och blockering av annat än siffror ****
        public int Check_Valid(int _antalMenyval)       // Metoden tar med sig argumentet _antalMenyval
        {
            int antalMenyval = _antalMenyval;
            int _menyVal;
            while (!int.TryParse(Console.ReadLine(), out _menyVal))
            {
                Console.WriteLine("Endast något av menyvalen 0 - " + (antalMenyval--) + " är giltiga.");

            }
            return _menyVal;        // Metoden returnerar ett korrekt valalternativ

        }   // **** End Check_Valid() ****

        public int Check_Valid_Age(int _totalAge)       // Metoden tar med sig argumentet _antalMenyval
        {
            int totalAge = _totalAge;
            int _age;
            while (!int.TryParse(Console.ReadLine(), out _age ))
            {
                Console.WriteLine("Endast ålder mellan 0 - " + (totalAge--) + " är giltiga.");

            }           

            return _age;
        }   // **** End Check_Valid() ****

        public void Uppg1()         // Hello World!
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 1 - Hello World! *** ** *\n");

            Console.WriteLine("Hello World!\n");

            GetBack();
        }
        public void Uppg2()         //Input/Output
        {
            string firstName;
            string lastName;
            int age;
            int totalAge = 100;

            Console.WriteLine("* ** *** Uppgift 2 - Input/Output *** ** *\n");

            Console.WriteLine("\nAnge ditt Förnamn:");
            firstName = Console.ReadLine();

            Console.WriteLine("\nAnge ditt Efternamn:");
            lastName = Console.ReadLine();

            Console.WriteLine("\nAnge din ålder:");

            age = Check_Valid_Age(totalAge);

            if (age > totalAge)
            {
                Console.WriteLine("\nOj då vad gammal du är!");
            }

            Console.WriteLine("\nDu heter {0} {1} och är {2} år gammal.", firstName, lastName, age);

            GetBack();           
        }

        public void Uppg3()         // Ändra textfärg
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 3 - Ändra textfärg *** ** *\n");

            if (Console.ForegroundColor == ConsoleColor.Blue)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nKonsollens förgrundsfärg är nu vit.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nKonsollens förgrundsfärg är nu blå.");
            }

            GetBack();
        }

        public void Uppg4()         //Dagens datum
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 4 - Dagens datum  *** ** *\n");

            DateTime dagensDatum = DateTime.Now;

            Console.WriteLine("\nDagens datum är: {0}", dagensDatum.ToShortDateString());
            Console.WriteLine("\nKlockan är: {0}", dagensDatum.ToShortTimeString());

            GetBack();
        }

        public void Uppg5()         //Störst tal av två
        {
            int value1;
            int value2;

            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 5 - Störst är bäst  *** ** *\n");

            Console.WriteLine("Ange tal1: ");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange tal2: ");
            value2 = Convert.ToInt32(Console.ReadLine());

            var result = value1 > value2 ? "Tal 1 är större än tal 2." : "Tal 2 är större än Tal 1.";
            Console.WriteLine(result);

            GetBack();
        }

        public void Uppg6()         //Gissa slumptal mellan 1 och 100
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 6 - Gissa talet  *** ** *\n");

            int antalForsok = 1;                                             
            Random redRum = new Random();                                   
            int slumpatTal = redRum.Next(1, 100);                         
            int gissatTal = 0;                      

            while (gissatTal != slumpatTal)                                 
            {
                Console.Write("Gissa ett nummer mellan 1 och 100.");                
                Console.Write(Environment.NewLine);
                string dullBoy = Console.ReadLine();                                
                gissatTal = Convert.ToInt32(dullBoy);                               

                if (gissatTal < slumpatTal)                                         
                {
                    Console.WriteLine("Eeek, no can do! För lågt!");   
                    Console.WriteLine("Försök nr: " + antalForsok + "."); 
                    antalForsok++;
                }
                else if (gissatTal > slumpatTal)                       
                {
                    Console.WriteLine("Yikes! För högt!");   
                    Console.WriteLine("Försök nr: " + antalForsok + "."); 
                    antalForsok++;
                }
            }
            if (gissatTal == slumpatTal)                                
            {
                Console.WriteLine("Snyggt!");                        
                Console.WriteLine("Det tog dig " + antalForsok + " försök att hitta rätt."); 
            }
            
            Console.WriteLine("All work and no play makes Jack a dull boy...");      

            GetBack();
        }

        public void Uppg7()         // Skriv till textfil
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 7 - Skriv textsträng till fil  *** ** *\n");

            Console.WriteLine("Skriv in text att spara i textfilen:");
            string text = Console.ReadLine();

            System.IO.File.WriteAllText(@"C:\temp\Text.txt", text);

            GetBack();
        }

        public void Uppg8()
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 8 - Läs textsträng från fil  *** ** *\n");

            string text = System.IO.File.ReadAllText(@"C:\temp\Text.txt");

            System.Console.WriteLine("WriteText.txt = {0}", text);


            GetBack();
        }

        public void Uppg9()
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 9 - Mattetal (Oh no, I'm back in schooool!  *** ** *\n");

            Console.WriteLine("Skriv in decimaltal:");
            double TalTillRotenUr = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt(TalTillRotenUr);
            Console.WriteLine("Roten ur {0} blir {1}", TalTillRotenUr, result);
            Console.WriteLine($"Roten ur {TalTillRotenUr}^2 blir {(long)Math.Pow(result, 2):N0}");
            Console.WriteLine($"Roten ur {TalTillRotenUr}^10 blir {(long)Math.Pow(result, 10):N0}");

            GetBack();
        }

        public void Uppg10()        //Multiplikationstabell
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 10 - Mulitplikationstabell *** ** *\n");

            int[] tabellArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("  |");

            // Skriv ut x horisontellt
            for (int i = 0; i < tabellArray.Length; i++)
            {
                string testLengthi = Convert.ToString(tabellArray[i]);

                if (testLengthi.Length == 1)
                {
                    Console.Write("   {0}|", tabellArray[i]);
                }
                else if (testLengthi.Length == 2)
                {
                    Console.Write("  {0}|", tabellArray[i]);
                }
            }

            Console.Write("\n");
            Console.Write("---");

            for (int i = 0; i < tabellArray.Length; i++)
            {                
                    Console.Write("-----", tabellArray[i]);                
            }

            Console.Write("\n");

            // Skriv ut y vertikalt
            for (int i = 0; i < tabellArray.Length; i++)
            {
                string testLengthi = Convert.ToString(tabellArray[i]);

                if (testLengthi.Length == 1)
                {
                    Console.Write(" {0}|", tabellArray[i]);                    
                }
                else
                {
                    Console.Write("{0}|", tabellArray[i]);
                }

                {
                    for (int j = 0; j < tabellArray.Length; j++)
                    {
                        int result = tabellArray[i] * tabellArray[j];

                        string testLength = Convert.ToString(result);

                        if (testLength.Length == 1)

                        {
                            // Skriv ut varje tabellrad med 2 blanksteg mellan varje tal om talets längd är 1 (1-9)
                            Console.Write("   {0}|", result);
                        }
                        else if (testLength.Length == 2)
                        {
                            // Skriv ut varje tabellrad med 1 blanksteg mellan varje tal om talets längd är 2 (10-99)
                            {
                                Console.Write("  {0}|", result);
                            }
                        }
                        else if (testLength.Length == 3)
                        {
                            // Skriv ut varje tabellrad med 1 blanksteg mellan varje tal om talets längd är 3 (100+)
                            {
                                Console.Write(" {0}|", result);
                            }
                        }
                    }                    
                }

                Console.Write("\n");
            }

            GetBack();
        }

        public void Uppg11()        // 2 Arrayer; 1 slumpad, 1 sorterad
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 11 - 2 Arrayer; 1 slumpad, 1 sorterad   *** ** *\n");

            var arraySlump = new int[10];
            var arraySorterad = new int[10];
            var slumptal = new Random();

            Console.Write("Osorterad array:\n");

            for (int i = 0; i < arraySlump.Length; i++)
            {
                arraySlump[i] = slumptal.Next(1,100);
                arraySorterad[i] = arraySlump[i];
                 Console.Write("{0} ", arraySlump[i]);
            }

            Console.Write("\n\n");
            Console.Write("Sorterad array:\n");


            Array.Sort(arraySorterad);

            for (int i = 0; i < arraySorterad.Length; i++)
            {
                Console.Write("{0} ", arraySorterad[i]);
            }

            GetBack();
        }

        public void Uppg12()        // Palindrom
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 12 - Michael Palin(drom)  *** ** *\n");

            Console.WriteLine("Skriv in ett ord: ");
            string palin = Console.ReadLine();
            char[] ch = palin.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);
            bool b = palin.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("Snyggt! " + palin + " är en Palindrom!");
            }
            else
            {
                Console.WriteLine("" + palin + " är dessvärre inte en Palindrom!");
            }

            GetBack();
        }

        public void Uppg13()        //Skriv ut mellanliggande tal
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 13 - Skriv ut mellanliggande tal  *** ** *\n");

            int value1;
            int value2;
            int result;

            Console.WriteLine("Ange tal1: ");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange tal2: ");
            value2 = Convert.ToInt32(Console.ReadLine());

            result = value2 - value1;

            Console.Write("\n\n");
            Console.Write("Tal mellan {0} och {1}: \n", value1, value2);

            for (int i = 1; i <= result-1; i++)
            {
                Console.WriteLine("" + (value1 + i));
            }

            GetBack();
        }

        public void Uppg14()        // Sortera Udda/Jämna
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 14 - Sortera Udda/Jämna  *** ** *\n");

            char[] charsToTrim = { ' ', ','};
            int j = 0;

            Console.WriteLine("Skriv in ett antal tal (avgränsade med kommatecken): ");
            string inputToSortOddEven = Console.ReadLine();

            // Skapa sträng-array av tal separerade av komma
            string[] inputList = inputToSortOddEven.Split(",");

            //dela upp textsträng med kommatecken (,) som avdelare placera varje tal i en array  
            int[] numbersToSort = new int[inputList.Length];

            Console.Write("\nSträng konverterad till separata tal: ");
            foreach (string input in inputList)
            {
                string result = input.Trim(charsToTrim);
                numbersToSort[j] = Convert.ToInt32(result);
                Console.Write(" {0}", numbersToSort[j]);

                j++;
            }

            //Sortera array i fallande ordning
            Array.Sort(numbersToSort);

            Console.Write("\n\nTal sorterade: ");

            int evenCount = 0;
            int oddCount = 0;

            // Sortera ut Udda/Jämna
            for (int i = 0; i < numbersToSort.Length; i++)
            {
                Console.Write(" " + numbersToSort[i]);
                if (numbersToSort[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            int[] evenNumbers = new int[evenCount];
            int[] oddNumbers = new int[oddCount];
            int evenUp = 0;
            int oddUp = 0;

            for (int i = 0; i < numbersToSort.Length; i++)
            {
                //Console.Write(" " + numbersToSort[i]);

                if (numbersToSort[i] % 2 == 0)
                {
                    evenNumbers[evenUp] = numbersToSort[i];
                    evenUp++;
                }
                else
                {
                    oddNumbers[oddUp] = numbersToSort[i];
                    oddUp++;
                }
            }

            Console.Write("\n\nJämna tal: ");

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.Write(" " + evenNumbers[i]);

            }

            Console.Write("\n\nUdda tal: ");

            for (int i = 0; i < oddNumbers.Length; i++)
            {
                Console.Write(" " + oddNumbers[i]);

            }

            GetBack();
        }

        public void Uppg15()        // Addera alla tal från inputsträng
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 15 - Addera alla tal  *** ** *\n");

            char[] charsToTrim = { ' ',',' };
            int j = 0;

            Console.WriteLine("Skriv in ett antal tal (avgränsade med kommatecken): ");
            string inputToAdd = Console.ReadLine();

            //dela upp text-sträng med kommatecken (,) som avdelare
            string[] inputList = inputToAdd.Split(",");
            
            //placera varje separat tal som element i en integer-array  
            int[] numbersToSort = new int[inputList.Length];

            //Console.Write("\nSträng konverterad till separata tal: ");
            foreach (string input in inputList)
            {
                string result = input.Trim(charsToTrim);
                numbersToSort[j] = Convert.ToInt32(result);
                //Console.Write(" " + result);
                j++;
            }

            int resultOfAllNumbers = 0;

            for (int i = 0; i < numbersToSort.Length; i++)
            {
                resultOfAllNumbers += numbersToSort[i];                
            }

            Console.WriteLine("\n\nTotalsumma av alla inmatade tal: {0}", resultOfAllNumbers);

            GetBack();
        }

        //public class Player
        //{
        //    public Player(string name)
        //        {
        //        UserName = name;

        //        Random dice = new Random();
        //        int slumpTalHealth = dice.Next(1, 100);
        //        int slumpTalStrength = dice.Next(1, 100);
        //        int slumpTalLuck = dice.Next(1, 12);

        //        UserHealth = slumpTalHealth;
        //        UserStrength = slumpTalStrength;
        //        LuckyPunk = slumpTalLuck;
        //    }
        //    public string UserName { get; }
        //    public int UserHealth { get; }
        //    public int UserStrength { get; }
        //    public int LuckyPunk { get; }
        //}

        public void Uppg16()
        {
            Console.Clear();
            Console.WriteLine("* ** *** Uppgift 16 - EN fråga om Klass - Dungeons & Donuts  *** ** *\n");

            Console.WriteLine("Det är möte med finalchefen i gden sista grottan.\n");
            Console.WriteLine("Ange ditt namn:");
            string player1name = Console.ReadLine();
            var player1 = new Player(player1name);

            Console.WriteLine("Ange din motståndares namn:");
            string player2name = Console.ReadLine();
            var player2 = new Player(player2name);

            Console.WriteLine("\nFighten står mellan:\n");
            Console.WriteLine("Namn: {0}", player1.UserName);
            Console.WriteLine("Hälsa: {0}",player1.UserHealth);
            Console.WriteLine("Styrka: {0}", player1.UserStrength);
            Console.WriteLine("Tur: {0}", player1.LuckyPunk);

            Console.WriteLine("\noch\n");

            Console.WriteLine("Namn: {0}", player2.UserName);
            Console.WriteLine("Hälsa: {0}", player2.UserHealth);
            Console.WriteLine("Styrka: {0}", player2.UserStrength);
            Console.WriteLine("Tur: {0}\n\n", player2.LuckyPunk);

            int player1result = (player1.UserStrength + player1.UserHealth * player1.LuckyPunk);
            int player2result = (player2.UserStrength + player2.UserHealth * player2.LuckyPunk);

            if (player1result > player2result)
            {
                Console.WriteLine("* ** *** {0} är vinnaren! *** ** *\n\n", player1name);
            }
            else if (player1result < player2result)
            {
                Console.WriteLine("*** ** * {0} är vinnaren! * ** ***\n\n", player2name);
            }
            else 
            {
                Console.WriteLine("- - - Det är en slips! - - -\n\n");
            }

            GetBack();
        }
        
        public void GetBack()
        {
            Console.WriteLine("\n\nTryck en tangent för att fortsätta.");
            Console.ReadKey(true);
        }
    }
}
    
