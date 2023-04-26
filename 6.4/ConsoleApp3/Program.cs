using System;

public class EnergyUsageTracker
{
    private int _startMeterReading;
    private int _currentMeterReading;

    public void RegisterStartMeterReading(int reading)
    {
        _startMeterReading = reading;
    }

    public void RegisterCurrentMeterReading(int reading)
    {
        _currentMeterReading = reading;
    }

    public int GetStartMeterReading()
    {
        return _startMeterReading;
    }

    public int GetCurrentMeterReading()
    {
        return _currentMeterReading;
    }

    public int CalculateEnergyUsage()
    {
        int energyUsage = _currentMeterReading - _startMeterReading;
        return energyUsage;
    }
}

public class Program
{
    static void Main()
    {
        EnergyUsageTracker tracker = new EnergyUsageTracker();

        tracker.RegisterStartMeterReading(1000);
        tracker.RegisterCurrentMeterReading(1100);

        int startReading = tracker.GetStartMeterReading();
        int currentReading = tracker.GetCurrentMeterReading();
        int energyUsage = tracker.CalculateEnergyUsage();

        Console.WriteLine($"Start Meter Reading: {startReading}");
        Console.ReadKey();
        Console.WriteLine($"Current Meter Reading: {currentReading}");
        Console.ReadKey();
        Console.WriteLine($"Energy Usage: {energyUsage}");
        Console.ReadKey();
    }
}
