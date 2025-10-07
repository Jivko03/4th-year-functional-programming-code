using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class City
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public City(string name, int cod)
        {
            Name = name;
            Code = cod;
        }
    }
    public delegate void ListCity();
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            cities.Add(new City("Gabrovo", 5300));
            cities.Add(new City("Haskovo", 6300));
            ListCity lists = delegate ()
            {
                foreach (City city in cities)
                {
                    Console.WriteLine("Grad:" + city.Name + ", poshtenski kod: " + city.Code);
                }
            };
            lists();
        }
    }
}
