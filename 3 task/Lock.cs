public class Lock: IDevice
{
    public string PinCode {get;set;}
    public void UnlockDoor(string code)
    {
        if(PinCode == code)
        {
            System.Console.WriteLine("Unlock");
        }
        else
        {
            System.Console.WriteLine("Wrong code");
        }
    }
    public void TurnOn()
    {
        System.Console.WriteLine("Lock system activated");
    }
    public void TurnOff()
    {
        System.Console.WriteLine("Lock system Deactivated");
    }
}