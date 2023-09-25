using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CW6_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix2D firstMatrix = new Matrix2D(5, 5);
            Matrix2D secondMatrix = new Matrix2D(5, 5);
            firstMatrix.SetRandomNumbers(10, 100);
            secondMatrix.SetRandomNumbers(10, 100);
            Console.WriteLine(firstMatrix.ToString());
            Console.WriteLine(secondMatrix.ToString());
            Console.WriteLine(firstMatrix == secondMatrix);
            Matrix2D thirdMatrix = firstMatrix + secondMatrix;
            Console.WriteLine(thirdMatrix.ToString());
            Console.ReadLine();
        }
    }
}
