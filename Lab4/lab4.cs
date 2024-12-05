//zad1

public abstract class Shape
{


    protected int X { get; set; }

    protected int Y { get; set; }  


    protected Shape(int x, int y)
    {

            X = x;
            Y = y;

    }

    protected abstract double Calc();

}

//zad2

public interface IVehicle 
{

    void Start();

    void Stop();

    int MaxSpeed
    {

        get;
        set;
    }
}

public class Samochod : IVehicle
{
    public int MaxSpeed { get; set; }
    string Name { get; set; }
    public Samochod(int max, string name)
    {

            MaxSpeed = max;

            Name = name;

    }

    public void Start()
    {
        Console.WriteLine("Wystartuj samochód");
    }

    public void Stop()
    {
        Console.WriteLine("Zatrzymaj samochód");
    }
}