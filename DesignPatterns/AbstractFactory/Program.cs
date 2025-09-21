namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("====== BEGIN DEMO - ABSTRACT FACTORY ======");
            Console.WriteLine("===========================================");

            // Legacy oven
            #region
            Console.WriteLine("Legacy oven management:");

            // New oven controller using the Legacy oven factory
            OvenController oven1 = new OvenController(new LegacyOvenFactory());

            // Open connection, set temperature, read current temperature, then close connection
            oven1.OpenConnection();
            oven1.SetTemperature(180);
            oven1.StartCycle();
            int temp1 = oven1.ReadTemperature();
            Console.WriteLine($"Current temperature for oven1: { temp1 } °C");
            oven1.CloseConnection();
            #endregion

            // Modern oven
            #region 
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Modern oven management:");

            // New oven controller using the Modern oven factory
            OvenController oven2 = new OvenController(new ModernOvenFactory());

            // Open connection, set temperature, read current temperature, then close connection
            oven2.OpenConnection();
            oven2.SetTemperature(290);
            oven2.StartCycle();
            int temp2 = oven2.ReadTemperature();
            Console.WriteLine($"Current temperature for oven2: {temp2} °C");
            oven2.CloseConnection();
            #endregion

            Console.WriteLine("===========================================");
            Console.WriteLine("======= END DEMO - ABSTRACT FACTORY =======");
            Console.WriteLine("===========================================");



        }
    }


}