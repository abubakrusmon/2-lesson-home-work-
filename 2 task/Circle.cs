public class Circle : Shape
{
    public double Radius {get;set;}

    public Circle(string Color , double Radius) : base(Color)
    {
        this.Radius = Radius;
    }
}