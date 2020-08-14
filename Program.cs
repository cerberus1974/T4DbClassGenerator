using System;
using System.IO;
using System.Text;
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
            ITemplate template = new TextTemplate(namespaceName);

            File.WriteAllText(outputPath, template.TransformText(), new UTF8Encoding(false));
            Console.WriteLine(template.TransformText());
        }
    }
}
