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
		
		// List of strings with pre-defined data
		List<string> items = new List<string> {"Headphones", "Orange Juice 1L", "Tablecloth 6pack", "Flowers 12pieces", "T-Shirt XL"};
		
		items.Add("Dishes dozen");
		items.Add("Keyboard");
		
		Console.WriteLine($"Items list: {items}");
		
		// Array first example
		string[] common_colors = {"Red", "Blue", "Green", "Orange", "Yellow", "White", "Black", "Purple", "Pink", "Gray", "Brown"};
		Console.WriteLine($"Common colors: {common_colors}");
	
		// Dict first example
		Dictionary<string, int> users_dict = new Dictionary<string, int>{
			{"henxo10", 120},
			{"nofaceman", 165},
			{"thefatherofyou", 98},
			{"theprogrammer", 107},
		};
		Console.WriteLine($"Users dict: {users_dict}");
		
		Console.WriteLine("Dictionary Element: " + users_dict["nofaceman"]);

		// Dict of lists
		Dictionary<List> english_words = new Dictionary<List>{
			{"verbs", ["Run", "Speak", "Brush", "Listen to", "Walk", "Sleep"]},
			{"colors", ["Red", "Green", "Blue", "Yellow", "Black", "White", "Purple", "Pink", "Orange"]},
			{"vehicles", ["Car", "Truck", "Motorcycle", "Airplane", "Ship", "Boat", "Helicopter"]},
			{"fruits", ["Banana", "Peach", "Grapes", "Watermelon", "Melon", "Apple", "Strawberry"]},
			{"animals", ["Dog", "Cat", "Horse", "Bird", "Spider", "Snake", "Bear", "Goat", "Bull"]},
		};

		Console.WriteLine($"English words dict: {english_words}");
		Console.WriteLine($"Colors: {english_words["verbs"]}");
		Console.WriteLine($"Vehicles: {english_words["vehicles"]}");
	}
}
