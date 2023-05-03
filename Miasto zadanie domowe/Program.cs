namespace Miasto_zadanie_domowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Miasto gdansk = new Miasto();
            gdansk.Nazwa = "Gdańsk";
            gdansk.Populacja = 582205;
            gdansk.Powierzchnia = 262;
            Console.WriteLine("Gęstość zaludnienia miasta {0} wynosi {1} os/km2", gdansk.Nazwa, gdansk.GęstośćZaludnienia);

            Miasto gdynia = new Miasto();
            gdynia.Nazwa = "Gdynia";
            gdynia.Populacja = 244458;
            gdynia.Powierzchnia = 135.1;
            Console.WriteLine("Gęstość zaludnienia miasta {0} wynosi {1} os/km2", gdynia.Nazwa, gdynia.GęstośćZaludnienia);

            Miasto sopot = new Miasto();
            sopot.Nazwa = "Sopot";
            sopot.Populacja = 37089;
            sopot.Powierzchnia = 17.31;
            Console.WriteLine("Gęstość zaludnienia miasta {0} wynosi {1} os/km2", sopot.Nazwa, sopot.GęstośćZaludnienia);
        }
    }
}