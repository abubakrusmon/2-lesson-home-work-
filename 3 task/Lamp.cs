public class Lamp: IDevice
{
    public string? Color {get;set;}
    public void ChangeColor(string newcolor)
    {
        this.Color = newcolor;
    }
    public void TurnOn()
    {
        System.Console.WriteLine("Turn on the lamp");
    }
    public void TurnOff()
    {
        System.Console.WriteLine("TurnOff the lamp");
    }
}