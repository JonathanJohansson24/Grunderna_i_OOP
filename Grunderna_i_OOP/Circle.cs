using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_i_OOP
{
    internal class Circle
    {
        public int Radius;
        float Pi = 3.141f;
        public Circle(int radius)
        {
            Radius = radius;
        }
        public void GetArea()
        {
            float area = Radius * Radius * Pi;
            Console.WriteLine($"Arean av cirkeln med radien: {Radius}, är: {area}");
        }
        public void GetSphereArea()
        {
            float sphereArea = (4 * Radius) * Radius *  Pi;
            Console.WriteLine($"Arean av sfär med radien: {Radius}, är: {sphereArea}cm2");
        }
        public void GetSphereVolume()
        {
            float sphereVolume = 4 * Pi * Radius * Radius * Radius / 3;
            Console.WriteLine($"Volymen av sfär med radien: {Radius}, är: {sphereVolume}cm3");
        }
    }
}
