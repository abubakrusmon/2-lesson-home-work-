public class Rectangle : Shape
{
    public double Length {get;set;}
    public double Width {get;set;}

    public  Rectangle(string Color ,double Length , double Width ) : base(Color)
    {
        this.Length = Length;
        this.Width = Width;
    }
}