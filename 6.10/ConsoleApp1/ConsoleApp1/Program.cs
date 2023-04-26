using System;

struct KandydatNaStudia
{
    public string nazwisko;
    public double punktyMatematyka;
    public double punktyInformatyka;
    public double punktyJezykObcy;

    public double ObliczLacznaLiczbePunktow()
    {
        double sumaPunktow = 0.6 * punktyMatematyka + 0.5 * punktyInformatyka + 0.2 * punktyJezykObcy;
        return sumaPunktow;
    }
}

class Program
{
    static void Main(string[] args)
    {
        KandydatNaStudia[] kandydaci = new KandydatNaStudia[3];
        kandydaci[0].nazwisko = "Kowalski";
        kandydaci[0].punktyMatematyka = 70;
        kandydaci[0].punktyInformatyka = 80;
        kandydaci[0].punktyJezykObcy = 60;

        kandydaci[1].nazwisko = "Nowak";
        kandydaci[1].punktyMatematyka = 80;
        kandydaci[1].punktyInformatyka = 70;
        kandydaci[1].punktyJezykObcy = 90;

        kandydaci[2].nazwisko = "Kwiatkowski";
        kandydaci[2].punktyMatematyka = 90;
        kandydaci[2].punktyInformatyka = 60;
        kandydaci[2].punktyJezykObcy = 70;

        Console.WriteLine("Lista kandydatów:");
        foreach (KandydatNaStudia kandydat in kandydaci)
        {
            Console.WriteLine("{0}: {1} punktów", kandydat.nazwisko, kandydat.ObliczLacznaLiczbePunktow());
        }

        Console.ReadKey();
    }
}
