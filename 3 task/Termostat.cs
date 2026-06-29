public class Thermostat: IDevice
{
    public int Temperature {get;set;}
    public void SetTemperature(int degrees)
    {
        this.Temperature = degrees;
        Console.WriteLine($"Temperature set to {degrees}");
    }
    public void TurnOn()
    {
        System.Console.WriteLine("The Thermostat is TurnOn");
    }

    public void TurnOff()
    {
        System.Console.WriteLine("The Thermostat is TutnOff");
    }
}