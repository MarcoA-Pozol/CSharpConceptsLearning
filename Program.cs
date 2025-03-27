// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");

		Console.WriteLine("C# is good!");

		string name = "Marco";

		Console.WriteLine($"This is my name: {name}");

		// Console.WriteLine($"Strings Array: {strings_array}")
		Console.WriteLine("This is C#!!!");
		
		// Create a list of numbers and add numbers
		List<int> numbers_list = new List<int>();
		
		numbers_list.Add(56);
		numbers_list.Add(82);
		numbers_list.Add(35);
		numbers_list.Add(90);
		numbers_list.Add(12);
		
		// For each loop
		foreach (int number in numbers_list)
        {
            Console.WriteLine(number);
        }
		
		// Printing a list
		Console.WriteLine($"\nList of numbers: {numbers_list}");
	}
}
