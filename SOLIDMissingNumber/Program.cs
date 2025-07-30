// See https://aka.ms/new-console-template for more information
using SOLIDMissingNumber;
using SOLIDMissingNumber.Implementations;

Console.WriteLine("Hello, World!");


//var input = Console.ReadLine();

var input = "3,0,1";

int[] inputArray = [.. input.Split(",").Select(x=> int.Parse(x))];

var methodOne = new SolutionWithArray();
var methodTwo = new SolutionWithLoop();

//Either methods can be substituted here
var processor = new MissingNumberProcessor(methodOne);

int response = processor.FindMissingNumber(inputArray);

Console.WriteLine(response);

