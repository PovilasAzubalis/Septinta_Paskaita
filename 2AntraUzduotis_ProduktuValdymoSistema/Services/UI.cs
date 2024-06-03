using System.Globalization;

namespace AntraUzduotis_ProduktuValdymoSistema.Services
{
        // Sukurkite programą, kuri valdo produktų katalogą. Programa leis atlikti šias operacijas:
        // Pridėti naują produktą.
        // Rodyti visus produktus.
        // Pridėti pirkėją.
        // Atnaujinti produkto informaciją.
        // Pirkti - pasirinkti pirkėja, pasirinkti produktą ir išrašyti kvitą į naują txt failą
        // Išsaugoti ir nuskaityti produktų duomenis iš failo.

        // Klases:
        // Zaislas - Pavadinimas(string), Kaina(decimal)
        // Pirkinių krepšelio Prekė - Žaislas ir kiekis (int)
        // Pirkėjas - Vardas, krepšelio prekių sąrašas
        class UI
        {
                public static void Main(string[] args)
                {
                        MenuText();
                        MenuCheck(out bool inputCheckMenu, out int inputMenu);

                        while (inputCheckMenu == true)
                        {
                                Menu(ref inputCheckMenu, ref inputMenu);
                                Console.WriteLine();
                                MenuText();
                                MenuCheck(out inputCheckMenu, out inputMenu);
                        }

                }

                public static (bool, int) MenuCheck(out bool inputCheckMenu, out int inputMenu)
                {
                        inputCheckMenu = int.TryParse(Console.ReadLine(), out inputMenu);
                        return (inputCheckMenu, inputMenu);
                }
                public static void MenuText()
                {
                        Console.WriteLine("|MENU|");
                        Console.WriteLine("1 - Pridėti naują produktą i produktu meniu.");
                        Console.WriteLine("2 - Atnaujinti produkto informaciją.");
                        Console.WriteLine("3 - Perziureti produktu meniu.");
                        Console.WriteLine("4 - Išsaugoti produktu meniu.");

                        Console.WriteLine("7 - Pridėti pirkėją.");
                        Console.WriteLine("8 - Perziureti pirkiniu krepseli.");
                        Console.WriteLine("9 - Pildyti pirkiniu krepseli ir pirkti.");

                        Console.WriteLine("0 - Issaugoti ir baigti darba.");
                }

                public static void Menu(ref bool inputCheckMenu, ref int inputMenu)
                {
                        switch (inputMenu)
                        {
                                case 0:
                                        Environment.Exit(0);
                                        break;
                                case 1:
                                        PridetiIMenu();
                                        break;
                                case 2:

                                        break;
                                case 3:
                                        SkaitytiMenu();
                                        break;
                                case 4:

                                        break;
                                case 5:

                                        break;
                                case 6:

                                        break;
                                default:
                                        break;
                        }
                }

                public static void PridetiIMenu()
                {
                        Console.Write("Iveskite zaislo pavadinima: ");
                        string zaisloPavadinimas = Console.ReadLine();
                        Console.Write("Iveskite zaislo kaina(pvz.: 0.00): ");
                        decimal.TryParse(Console.ReadLine(), out decimal zaisloKaina);
                        
                        //string kaina = Console.ReadLine();
                        //decimal d = decimal.Parse(kaina);
                        //string zaisloKaina = d.ToString("0.00");

                        

                        using (StreamWriter Menu = new StreamWriter("C:\\Users\\azuba\\source\\repos\\SeptintaPaskaita\\2AntraUzduotis_ProduktuValdymoSistema\\Saved documents\\ProduktuMenu.txt", append: true))
                        {
                                Menu.WriteLine($"{zaisloPavadinimas} {zaisloKaina}");
                        }
                }
                public static void SkaitytiMenu()
                {
                        using (StreamReader Menu = new StreamReader("C:\\Users\\azuba\\source\\repos\\SeptintaPaskaita\\2AntraUzduotis_ProduktuValdymoSistema\\Saved documents\\ProduktuMenu.txt"))
                        {
                                while (!Menu.EndOfStream)
                                {
                                        string ReadLine = Menu.ReadLine();
                                        Console.WriteLine(ReadLine);
                                }
                                Menu.Close();
                        }
                }


        }
}
