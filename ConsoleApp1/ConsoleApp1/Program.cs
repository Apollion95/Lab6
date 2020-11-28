using System;

namespace ConsoleApp1
{
    public class Ksiazka
    {
        public string Tytul { set; get; }
        public string Autor { set; get; }
        public int Regal;
        public int Polka;
        public int Miejsce;

        public Ksiazka(string tytul, string autor, int regal, int polka, int miejsce)
        {
            Tytul = tytul;
            Autor = autor;
            Regal = regal;
            Polka = polka;
            Miejsce = miejsce;
        }
        
        public void Zmien(string tytul, string autor)
        {
            Tytul = tytul;
            Autor = autor;
        }
    }
    class Program
    {
        static void Wyszukaj(Ksiazka[,,] tab2, string nazwa)
        {
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    for (int y = 0; y < tab2.GetLength(2); y++)
                    {
                        if (tab2[i, j, y].Tytul.Contains(nazwa, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Tytuł: {0} \n Autor: {1} \n Regał: {2} \n Półka: {3} \n Miejsce: {4}"
                                , tab2[i, j, y].Tytul, tab2[i, j, y].Autor, tab2[i, j, y].Regal, tab2[i, j, y].Polka, tab2[i, j, y].Miejsce);
                        }
                    }
                }
            }
        }

        static void Main()
        {
            Ksiazka[,,] tab = new Ksiazka[3, 6, 10];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int y = 0; y < tab.GetLength(2); y++)
                    {
                        tab[i, j, y] = new Ksiazka("Metro 2033", "Dimitry Glukhovsky", i, j, y);
                    }
                }
            }
            tab[1, 1, 1].Zmien("Splinter Cell Sojusz Zla", "David Michaels");
            tab[1, 1, 2].Zmien("Ogniem i Mieczem", "Henryk Sienkiewicz");
            Console.WriteLine("Jakiej książki szukasz?: ");
            string szukanaKsiazka = Console.ReadLine();
            Wyszukaj(tab, szukanaKsiazka);   
        }
    }
}