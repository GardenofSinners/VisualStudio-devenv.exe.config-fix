using System;
using System.IO;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Loading program...");
            //StreamReader sr = new StreamReader("C:\\Users\\Tenshi\\AppData\\Local\\Microsoft\\VisualStudio\\15.0_30c469e8\\devenv.exe.config");

            //Neko's version: c:\\Users\\%username%\\AppData\\Local\\Microsoft\\VisualStudio\\15.0_4e1003d0\\devenv.exe.config
            lineChanger("<dependentAssembly>\n    <assemblyIdentity name=\"System.Management.Automation\" publicKeyToken=\"31bf3856ad364e35\" />\n             <publisherPolicy apply=\"no\" />\n          </dependentAssembly>\n        <dependentAssembly>\n          <assemblyIdentity name=\"Microsoft.PowerShell.Commands.Utility\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n        <dependentAssembly>\n <assemblyIdentity name =\"Microsoft.PowerShell.ConsoleHost\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n        <dependentAssembly>\n          <assemblyIdentity name=\"Microsoft.PowerShell.Commands.Management\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n        <dependentAssembly>\n          <assemblyIdentity name=\"Microsoft.PowerShell.Security\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n<dependentAssembly>\n          <assemblyIdentity name=\"Microsoft.PowerShell.Commands.Diagnostics\" publicKeyToken=\"31bf3856ad364e35\" />\n          <publisherPolicy apply=\"no\" />\n        </dependentAssembly>\n        <dependentAssembly>", "C:\\Users\\%username%\\AppData\\Local\\Microsoft\\VisualStudio\\15.0_4e1003d0\\devenv.exe.config", 37);
            Console.WriteLine("All registries found in the first answer of: https://stackoverflow.com/questions/12638289/embedding-powershell-v2-0-in-net-app-on-windows-8-rtm have been added to devenv.exe.config");
            Console.WriteLine("Press any key to exit the application.");
            Console.ReadKey(true);
        }

        public static void lineChanger(string newText, string fileName, int line_to_edit) {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}  
