namespace Telefonszamok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> telefonszamok = new List<string>();

            telefonszamok.Add("+36202275895");
            telefonszamok.Add("06203568987");
            telefonszamok.Add("(06)20/2558222");
            telefonszamok.Add("203568978+");
            telefonszamok.Add("nullahat202289578548");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 Kilépés");
                Console.WriteLine("1 Az összes telefonszám");
                Console.WriteLine("2 Csak a számjegyeket tartalmazók");
                Console.WriteLine("3 Csak a 12 karakter hosszúak");
                Console.WriteLine("4 Csak számjegyeket és + jelet tartalmazók");
                Console.WriteLine("5 Csak azok jelenjenek meg amiben 6-os szám van");
                Console.WriteLine("6 Csak számok és + jel, de csak elől lehet a +jel");
                Console.WriteLine("7 06-al kezdődik");
                Console.WriteLine("8 ( és vagy ) jel van benne");

                string valaszt = Console.ReadLine();

                if(valaszt == "0")
                {
                    return;
                }
                else if(valaszt == "1")
                {
                    Console.Clear();
                    foreach(string tel in telefonszamok)
                    {
                        Console.WriteLine(tel);
                    }
                }
                else if (valaszt == "2")
                {
                    Console.Clear();
                    foreach(string tel in telefonszamok)
                    {
                        bool jo = true;

                        foreach(char ch in tel)
                        {
                            if (!char.IsDigit(ch))
                                jo = false;
                        }
                        if (jo)
                        {
                            Console.WriteLine(tel);
                        }
                    }
                }
                else if (valaszt == "3")
                {
                    Console.Clear();
                    foreach(string tel in telefonszamok)
                    {
                        if (tel.Length == 12)
                        {
                            Console.WriteLine(tel);
                        }
                    }
                }
                else if (valaszt == "4")
                {
                    Console.Clear();
                    foreach (string tel in telefonszamok)
                    {
                        bool jo = true;

                        foreach (char ch in tel)
                        {
                            if (!(char.IsDigit(ch) || ch == '+'))
                                jo = false;
                        }
                        if (jo)
                        {
                            Console.WriteLine(tel);
                        }
                    }
                }
                else if (valaszt == "5")
                {
                    Console.Clear();
                    foreach(string tel in telefonszamok)
                    {
                        if (tel.Contains('6'))
                        {
                            Console.WriteLine(tel);
                        }
                    }
                }
                else if (valaszt == "6")
                {
                    Console.Clear();
                    foreach(string tel in telefonszamok)
                    {
                        bool jo = true;
                        bool jo_plusz = true;
                        if (tel.Contains("+"))
                        {
                            if (tel[0] == '+')
                            {
                                jo_plusz = false;
                            }
                        }
                        foreach(char ch in tel)
                        {
                            
                            if (!char.IsDigit(ch))
                            {
                                jo = false;
                            }
                        }
                        if (jo == jo_plusz)
                        {
                            Console.WriteLine(tel);
                        }
                    }
                }
                else if (valaszt == "7")
                {
                    Console.Clear();
                    foreach(string tel in telefonszamok)
                    {
                        if (tel[0] == '0' && tel[1] == '6')
                        {
                            Console.WriteLine(tel);
                        }
                    }
                }
                else if (valaszt == "8")
                {
                    
                }
                else
                {
                    Console.WriteLine("Nincs ilyen parancs!");
                }
                Console.ReadKey();
            }
        }
    }
}
