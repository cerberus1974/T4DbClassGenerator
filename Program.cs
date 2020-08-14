using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppFramework;
using DataClassGenerator.Material;
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
            var tableInfo = new TableInfo
            {
                Name = "TestTable",
                ColumnInfos = new List<ColumnInfo>
                {
                    new ColumnInfo { Name = "Column1", Type = "int", NotNull = true },
                    new ColumnInfo { Name = "Column2", Type = "string", NotNull = true },
                    new ColumnInfo { Name = "Column3", Type = "string", NotNull = false },
                }
            };

            ITemplate template = new TextTemplate(namespaceName, tableInfo);

            File.WriteAllText(outputPath, template.TransformText(), new UTF8Encoding(false));
            Console.WriteLine(template.TransformText());
        }
    }
}
