using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp 
{
    class Program
    {
        static void Main(string[] args)
        {

            MultiBuilding multiBuilding = new MultiBuilding("fsd", "fsd", "fsd", "fsd", "fsd");

            multiBuilding.Print();
       
        }
    }
    class Building
    {
        public Building()
        {
           
        }
        public Building(string address, string length, string width, string hidth)
            {
            Address=address;
            Length=length;
            Width=width;
            Height = hidth;
            }
        public string Address { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public void Print()
        {
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
        }
    }

    sealed class MultiBuilding : Building
    {
        public MultiBuilding(string address, string length, string width, string hidth, string storeys)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = hidth;
            Storeys = storeys;
        }
        public string Storeys { get; set; }

        public void Print()
        {
           base.Print();
            Console.WriteLine("Number of storeys: " + Storeys);
        }

    }
}

