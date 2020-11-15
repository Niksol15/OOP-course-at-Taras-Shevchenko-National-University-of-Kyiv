using System;

//Порушено принцип підстановки Лісков
abstract class Shape
{
    abstract public int GetArea();
}

class Rectangle: Shape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    override public int GetArea()
    {
        return Width * Height;
    }
}
class Square : Shape
{
    public override int GetArea()
    {
        return Side * Side;
    }
    public int Side{ get; set; }
}
class Program
{
    //Демонстрація принципу Лісков
    static int ProccesArea(Shape shape)
    {
        return shape.GetArea();
    }
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;

        Console.WriteLine(ProccesArea(rect));
        //Відповідь 100? Що не так???
        //До того мы просто спочатку встановили сторону 5, потом 10
        Console.ReadKey();
    }
}