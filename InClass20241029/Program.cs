// Documentation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass20241029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an object of type cooler
            Cooler myCooler;
            myCooler = new Cooler(); // Instantiate the object 
            myCooler.Color = "Dirty Gray"; // Invokes the setter 
            Console.WriteLine(myCooler.Color); // Invoke the getter
            myCooler.Color = ""; // Empty string value
            Console.WriteLine("New cooler color is " + myCooler.Color);
            myCooler.Cost = 20;
            Console.WriteLine("The cooler cost is " + myCooler.Cost);
            myCooler.Cost = -1;
            Console.WriteLine("The cooler cost is " + myCooler.Cost);
        } 
    }
}
