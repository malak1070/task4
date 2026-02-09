// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
    string dotNetVersion = RuntimeInformation.FrameworkDescription;
    string operatingSystem = RuntimeInformation.OSDescription;
    string cpuArchitecture = RuntimeInformation.OSArchitecture.ToString();

    Console.WriteLine("Runtime Information:");
    Console.WriteLine($"- .NET Runtime Version: {dotNetVersion}");
   Console.WriteLine($"- Operating System: {operatingSystem}");
    Console.WriteLine($"- CPU Architecture: {cpuArchitecture}");

   switch (dotNetVersion)
    {
  case string r when r.Contains(".NET"):
   Console.WriteLine("Modern .NET Runtime");
         break;

  default:
       Console.WriteLine("Legacy Runtime");
  break;
        }
    }
}
