using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_i_OOP
{                                                   // JONATHAN NORDIN SUT23
    internal class Triangle
    {
        public int BaseNr;
        public int HeightNr;

        public Triangle(int baseNr, int heightNr)
        {
            BaseNr = baseNr;
            HeightNr = heightNr;
        }
        public void TriangleArea()
        {
            int triangleArea = BaseNr * HeightNr / 2;

            Console.WriteLine($"Arean av triangel med basen: {BaseNr}cm och höjden {HeightNr}cm är: {triangleArea}cm2");
        }
    }
}
