// See https://aka.ms/new-console-template for more information

using ICT3101_Lab2;

Console.WriteLine("Hello, World!");
string workingDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Current working directory: {workingDirectory}");

Calculator calculator = new Calculator();
double result = calculator.GenMagicNum(1, new FileReader());

Console.WriteLine(result);