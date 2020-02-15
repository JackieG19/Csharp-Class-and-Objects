using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpFundamentals
{    
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);
            
            point.Move(new Point(40,60));
            Console.Write("Point is at ({0}, {1})", point.X, point.Y);
            
            point.Move(100, 200);
            Console.Write("Point is at ({0}, {1})", point.X, point.Y);
        }
    }
}
