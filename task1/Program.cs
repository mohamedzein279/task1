namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallPrice = 25;
            int largePrice = 35;
            double taxRate = 0.06;

            Console.WriteLine("Number of small carpets: ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of large carpets: ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            int cost = (smallCarpets * smallPrice) + (largeCarpets * largePrice);
            double tax = cost * taxRate;
            double total = cost + tax;

            Console.WriteLine("Number of small carpets: " + smallCarpets);
            Console.WriteLine("Number of large carpets: " + largeCarpets);
            Console.WriteLine("Cost: $" + cost);
            Console.WriteLine("Tax: $" + tax);
            Console.WriteLine("Total estimate: $" + total);
        }
    }
}


    
