using System;
using System.IO;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Loading program...");
            Console.WriteLine("Input File Location (The folder inside AppData/Local/Microsoft/VisualStudio)");
            string folder = Console.ReadLine().ToString();

            LineChanger("<dependentAssembly>\n    <assemblyIdentity name=\"System.Management.Automation\" publicKeyToken=\"31bf3856ad364e35\" />\n             <publisherPolicy apply=\"no\" />\n          </dependentAssembly>\n        <dependentAssembly>\n          <assemblyIdentity name=\"Microsoft.PowerShell.Commands.Utility\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n        <dependentAssembly>\n <assemblyIdentity name =\"Microsoft.PowerShell.ConsoleHost\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n        <dependentAssembly>\n          <assemblyIdentity name=\"Microsoft.PowerShell.Commands.Management\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n        <dependentAssembly>\n          <assemblyIdentity name=\"Microsoft.PowerShell.Security\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n<dependentAssembly>\n          <assemblyIdentity name=\"Microsoft.PowerShell.Commands.Diagnostics\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n        <dependentAssembly>", $"{folder}\\devenv.exe.config", 37);
            Console.WriteLine("All registries found in the first answer of: https://stackoverflow.com/questions/12638289/embedding-powershell-v2-0-in-net-app-on-windows-8-rtm have been added to devenv.exe.config");
            Console.WriteLine("Press any key to exit the application.");
            Console.ReadKey(true);
        }

        public static void LineChanger(string newText, string fileName, int line_to_edit) {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}  
