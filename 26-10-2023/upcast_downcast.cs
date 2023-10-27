using System;

public class Shape
{
    public int Width {get; set;}

    public int Height {get; set;}

    public int X {get; set;}

    public int Y {get; set;}

    public void Draw()
    {

    }

    public class Text: Shape
    {
        public int FontSize {get; set;}
        public string FontName {get; set;}
    }
    public class Circle : Shape
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            Shape shape = text;

            shape.X = 10;
            shape.Y = 20;
            shape.Width = 22;
            shape.Height = 20;

            shape.Draw();

            System.Console.WriteLine("X="+shape.X);
            System.Console.WriteLine("Y="+shape.Y);
            System.Console.WriteLine("Width="+shape.Width);
            System.Console.WriteLine("Height="+shape.Height);
        }
    }
}