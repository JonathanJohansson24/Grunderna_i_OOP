namespace Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle(5);
            Circle secondCircle = new Circle(6);
            Triangle firstTriangle = new Triangle(7, 8);
            firstCircle.PrintAllInfo();

            secondCircle.PrintAllInfo(); 

            

            firstTriangle.TriangleArea();

        }
    }
}