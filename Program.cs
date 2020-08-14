using System;
using System.Threading.Tasks;
using ConsoleAppFramework;
using Microsoft.Extensions.Hosting;

namespace DataClassGenerator
{
    class Program : ConsoleAppBase
    {
        static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder().RunConsoleAppFrameworkAsync<Program>(args);
        }

        public void Run(
            [Option("o", "output file path")]string outputPath,
            [Option("n", "namespace name")]string namespaceName
            )
        {
            Console.WriteLine(outputPath);
            Console.WriteLine(namespaceName);
        }
    }
}
