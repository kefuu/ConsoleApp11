namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task1 
            Piece piece = new Piece("Гамлет", "Вільям Шекспір", "Трагедія", 1603);

            piece.DisplayInfo();

            Console.ReadLine();

            // task 2
            using (Shop shop = new Shop("Супермаркет", "вул. Привітання, 123", ShopType.Grocery))
            {
                shop.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}