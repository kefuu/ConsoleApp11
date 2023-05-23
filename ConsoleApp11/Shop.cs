using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    enum ShopType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

    internal class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Назва магазину: {0}", Name);
            Console.WriteLine("Адреса магазину: {0}", Address);
            Console.WriteLine("Тип магазину: {0}", Type);
        }

        public void Dispose()
        {
            Console.WriteLine("Викликаний метод Dispose для магазину {0}", Name);

        }
    }
}
