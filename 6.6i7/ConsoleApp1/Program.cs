using System;

class Punkt
{
    public int x;
    public int y;

    public Punkt(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static bool CzyNaProstej(Punkt p1, Punkt p2, Punkt p3)
    {
        return (p2.y - p1.y) * (p3.x - p2.x) == (p3.y - p2.y) * (p2.x - p1.x);
    }

}

class Odcinek
{
    public Punkt poczatek;
    public Punkt koniec;

    public Odcinek(Punkt poczatek, Punkt koniec)
    {
        this.poczatek = poczatek;
        this.koniec = koniec;
    }

    public double Dlugosc()
    {
        int dx = koniec.x - poczatek.x;
        int dy = koniec.y - poczatek.y;
        return Math.Sqrt(dx * dx + dy * dy);

    }
}
class Program
{
    static void Main(string[] args)
    {
        Punkt[] punkty = new Punkt[3];
        punkty[0] = new Punkt(0, 0);
        punkty[1] = new Punkt(1, 1);
        punkty[2] = new Punkt(2, 2);

        if (Punkt.CzyNaProstej(punkty[0], punkty[1], punkty[2]))
        {
            Console.WriteLine("Punkty leżą na jednej prostej");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Punkty nie leżą na jednej prostej");
            Console.ReadKey();
        }

        Odcinek odcinek = new Odcinek(new Punkt(0, 0), new Punkt(3, 4));
        Console.WriteLine("Długość odcinka: " + odcinek.Dlugosc());
        Console.ReadKey();
    }
}