namespace reactegz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();

            Console.WriteLine(film.getTytul());
            Console.WriteLine(film.getWypozyczenia());

            Console.WriteLine();

            film.setTytul("Sami swoi");

            Console.WriteLine(film.getTytul());

            Console.WriteLine("Wypożyczenia: " + film.getWypozyczenia());

            film.inkrementacja();

            Console.WriteLine("Wypożyczenia po inkrementacji: " + film.getWypozyczenia());
        }
    }
}
