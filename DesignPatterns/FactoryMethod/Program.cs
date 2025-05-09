namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OvenController controller;

            // Set temperature of the legacy oven which uses a serial connection:
            Console.WriteLine("Setting temperature of the legay oven:");
            controller = new LegacyOvenController();
            controller.SetOvenTemperature(85);


            // Set temperature of the modern oven which uses a TCP connection:
            Console.WriteLine("\n***********************************");
            Console.WriteLine("Setting temperature of the modern oven:");
            controller = new ModernOvenController();
            controller.SetOvenTemperature(123);

        }
    }
}