using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleConsoleApp;


internal class Program
{        
    static void Main(string[] args)
    {
        /*List the pre-defined specifications of the fruit. 
            * Allow the predertimed classes to recieve data to display inside the return value
            */
        var Fruits = new List<Fruit>
        {
            new Fruit { Quantity = "10", Color = "Red", Type = "Apple", State = "Frozen"}
                
        };

        foreach (var fruit in Fruits) {
            Console.WriteLine(fruit);
        }

        
        Console.ReadLine();

        
        }

    public class Fruit
    {
        public string Quantity { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        //get, set, code recieving the fruit variables assigned to it

        public override string ToString()
        {
            return $"You have {Quantity} {Color} {Type}'s that are {State}.";
        }

    }
}
