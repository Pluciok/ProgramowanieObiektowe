//zad1
public class Licz
{
    private int Liczba { get; set; }

    public Licz(int liczba)
    {
        Liczba = liczba;
    }

    public int Wypisz()
        => Liczba;

    public void Dodaj(int liczba)
    {
        Liczba += liczba;
    }

    public void Odejmij(int liczba)
    {
        Liczba -= liczba;
    }
}
//zad2

public class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;
    private string pesel;

    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public int Wiek { get; private set; }
    public string Pesel { get; }

    public Osoba(string imie, string nazwisko, int wiek, string pesel)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.wiek = wiek;
        this.pesel = pesel;
    }

    public string PrzedstawSie()
    {
        return $"Mam na imię {imie} a na nazwisko {nazwisko}, mam {wiek} lat";
    }

    public void Wiekk(int wiekkk)
    {
        if (wiekkk < 0)
        {
            Wiek = 0;
            return;
        }

        Wiek = wiekkk;
    }
}
//zad3

public class Sumator
{
    private int[] liczby;

    public Sumator(int[] liczby)
    {
        this.liczby = liczby;
    }

    public int Suma()
    {
        return liczby.Sum();
    }

    public float Podzile3()
    {
        return liczby.Sum() / 3;
    }

    public int IleElementow()
    {
        return liczby.Length;
    }

    public void Wypisz()
    {
        foreach (var liczba in liczby)
        {
            Console.WriteLine(liczba);
        }
    }

    public void Indexer(int lowIndex, int highIndex)
    {
        for (var i = lowIndex; i <= highIndex; i++)
        {
            Console.WriteLine(liczby[i]);
        }
    }
}