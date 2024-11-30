//zad1
    Console.Write("Podaj liczbe: ");
    var input = Console.ReadLine();
    var liczba = int.Parse(input);

    if (liczba % 2 == 0)
    {
        Console.WriteLine("Liczba jest parzysta");
    }
    else if (liczba % 2 == 1)
    {
        Console.WriteLine("Liczba jest nieparzysta");
    }
    else
    {
        Console.WriteLine("Podana liczba nie jest parzysta ani nieparzysta");
    }

//zad2

Console.Write("Podaj liczbe: ");
var input1 = Console.ReadLine();
var liczba1 = int.Parse(input1);

for (var i = 1; i <= liczba1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//zad3

while (true)
{
    Console.WriteLine("0.end");
    Console.WriteLine("1.a");
    Console.WriteLine("2.b");
    Console.WriteLine("3.c");
    Console.Write("Podaj liczbe: ");
    var input2 = Console.ReadLine();

    switch (input2)
    {
        case "0":
            return;

        case "1":
            Console.WriteLine("a");
            break;

        case "2":
            Console.WriteLine("b");
            break;

        case "3":
            Console.WriteLine("c");
            break;
    }
}


//zad5

var random = new Random();
var losLiczba = random.Next(1, 100);
var try1 = 0;

while (true)
{
    try1++;
    Console.Write("Podaj liczbe:");
    var input3 = Console.ReadLine();
    var liczba3 = int.Parse(input);

    if (liczba3 == losLiczba)
    {
        Console.WriteLine($"Zgadles liczbe {try1} prob");
        break;
    }

    Console.WriteLine(liczba3 < losLiczba ? "mala liczba" : "duza liczba");
}



