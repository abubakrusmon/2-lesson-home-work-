public class Person
{
    public int Age {get;set;}

    public void Greet()
    {
        System.Console.WriteLine("hello!");
    }
    public void Setage(int age)
    {
        Age = age;
    }
}