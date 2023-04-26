using System;

public class Punkt
{
    private int x;
    private int y;

    public Punkt(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Punkt()
    {
        this.x =0;
        this.y =0;
    }

    public void Przesun(int dx, int dy)
    {
        x += dx;
        y += dy;
    }

    public void Wyswietl()
    {
        Console.WriteLine("Aktualne współrzędne punktu: ({0}, {1})", x, y);
        Console.ReadKey();
    }

    public int X
    {

        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public static void Main()
    {
        Punkt p = new Punkt(1, 1);
        p.Wyswietl(); // Aktualne współrzędne punktu: (0, 0)
        p.Przesun(2, 4);
        p.Wyswietl(); // Aktualne współrzędne punktu: (2, 4)
        p.X = 3;
        p.Y = 5;
        p.Wyswietl(); // Aktualne współrzędne punktu: (3, 5)

        Punkt p2 = new Punkt();
        p2.Wyswietl();
    }
}