using System;
using System.Drawing;

namespace App
{
    class App
    {
        
        
        static void Main(string[] args)
        {
            Random r = new Random();
            
            var rValue = r.Next(0, 255);
            var bValue = r.Next(0, 255);
            var cValue = r.Next(0, 255);
            
            Console.WriteLine(Color.FromArgb(rValue, bValue, cValue)); 
            Console.ReadLine();

        }
    }
}

