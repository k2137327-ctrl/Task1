namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of small carpets:");
            int smallcarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of large carpets:");
            int largecarpets = Convert.ToInt32(Console.ReadLine());

            int cost = (smallcarpets * 25) + (largecarpets * 35);
            double tax = (cost * 0.06);


            Console.WriteLine("Price per small carpet : $25");     //by kerulos hany
            Console.WriteLine("Price per large carpet : $35");     //by kerulos hany  
            Console.WriteLine($"Cost : {cost}$");
            Console.WriteLine($"Tax : {tax}$");

        }
    }
}
