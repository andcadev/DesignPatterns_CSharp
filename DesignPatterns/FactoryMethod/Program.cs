namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("======= BEGIN DEMO - FACTORY METHOD =======");
            Console.WriteLine("===========================================");

            OvenController controller;

            // Set temperature of the legacy oven which uses a serial connection:
            Console.WriteLine("Setting temperature of the legacy oven:");
            controller = new LegacyOvenController();
            controller.SetOvenTemperature(85);


            // Set temperature of the modern oven which uses a TCP connection:
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Setting temperature of the modern oven:");
            controller = new ModernOvenController();
            controller.SetOvenTemperature(123);

            Console.WriteLine("===========================================");
            Console.WriteLine("======== END DEMO - FACTORY METHOD ========");
            Console.WriteLine("===========================================");

        }
    }
}