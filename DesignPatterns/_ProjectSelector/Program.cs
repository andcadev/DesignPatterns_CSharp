using System.Diagnostics;

namespace _ProjectSelector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOTE: Compile all the projects before running this code
            string? input;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Available design patterns:\n" +
                                  "1. Factory Method\n" +
                                  "2. Abstract Factory\n");
                Console.WriteLine("Insert the desig pattern number to view the related demo " +
                    "or press 'Q' to terminate:\n");

                input = Console.ReadLine()?.ToLower().Trim();

                switch (input)
                {
                    case "q":
                        exit = true;
                        break;

                    case "1":
                        Console.WriteLine("Launching 'Factory Method' demo...");
                        LaunchProject("FactoryMethod");
                        break;

                    case "2":
                        Console.WriteLine("Launching 'Abstract Factory' demo...");
                        LaunchProject("AbstractFactory");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                //Console.WriteLine("=====================================================");
            }

        }

        private static void LaunchProject(string projectName)
        {
            try
            {
                string solutionRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\..\..\"));

                string projectBinPath = Path.Combine(solutionRoot, projectName, "bin");

                string[] executables = Directory.GetFiles(projectBinPath, $"{projectName}.exe", SearchOption.AllDirectories);

                if (executables.Length > 0)
                {
                    // Create a new ProcessStartInfo object
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = executables[0];

                    // Create a new Process object
                    Process process = new Process();
                    process.StartInfo = startInfo;

                    // Start the process
                    process.Start();

                    // Wait for the process to exit
                    process.WaitForExit();

                    //Console.WriteLine($"\nProgram '{projectName}' terminated.");
                }
                else
                {
                    Console.WriteLine($"Errore: file {projectName} not found.");
                    Console.WriteLine("Be sure that the project has been compiled.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore durante l'avvio del progetto: {ex.Message}");
            }
        }

    }


}