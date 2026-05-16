// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Program;
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
		numbers_list.Add(20);

		// List of strings
		List<string> stringsList = new List<string>();
		stringsList.Add("Jason");
		stringsList.Add("Eats"); 
		stringsList.Add("Bread");
		stringsList.Add("I");
		stringsList.Add("Like"); 
		stringsList.Add("Sandwiches");
		foreach (string item in stringsList) 
		{
			Console.WriteLine(item);
		}
		
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
		Dictionary<string, string[]> english_words = new Dictionary<string, string[]>
		{
			{"verbs", new string[]{"Run", "Speak", "Brush", "Listen to", "Walk", "Sleep"}},
			{"colors", new string[]{"Red", "Green", "Blue", "Yellow", "Black", "White", "Purple", "Pink", "Orange"}},
			{"vehicles", new string[]{"Car", "Truck", "Motorcycle", "Airplane", "Ship", "Boat", "Helicopter"}},
			{"fruits", new string[]{"Banana", "Peach", "Grapes", "Watermelon", "Melon", "Apple", "Strawberry"}},
			{"animals", new string[]{"Dog", "Cat", "Horse", "Bird", "Spider", "Snake", "Bear", "Goat", "Bull"}},
		};

		Console.WriteLine($"English words dict: {english_words}");
		Console.WriteLine($"Colors: {english_words["verbs"]}");
		Console.WriteLine($"Vehicles: {english_words["vehicles"]}");

		// LOOPS
		for (int number = 0; number<=10; number++)
		{
			Console.WriteLine(number);
		}

		foreach (var item in english_words)
		{
			Console.WriteLine(string.Join(", ", item.Value));
			Console.WriteLine($"[{item.Key}, [{string.Join(", ", item.Value)}]]");
		}

		// CONDITIONALS
		var myInt = 11;
		if (myInt != 11 || myInt != 12)
		{
			Console.WriteLine("The value is not 11 or 12");
		}
		else if (myInt == 12) {
			Console.WriteLine("The value is 12");
		}
		else {
			Console.Write("The value is 11");
		}

		
		var numbersSum = SumNumbers(10, 22);
		Console.WriteLine($"{Environment.NewLine}Sum: {numbersSum}");
		
		// FUNCTIONS
		static int SumNumbers(int numOne, int numTwo)
		{
			return numOne + numTwo;
		}

		// CUSTOM CLASS INSTANCE
		Dog myDog = new Dog("Bebba", "Jack Russell", 5);

		Console.WriteLine($"My dog's name is {myDog.Name}.");
		Console.WriteLine($"She is a {myDog.Breed} and she is {myDog.Age} years old.");

		myDog.Bark();
		myDog.Eat("Chicken");

		Console.WriteLine($"Is {myDog.Name} currently hungry? {myDog.IsHungry}");
	}

	// CUSTOM CLASS
	class Dog
	{
		public string Name { get; set; }
		public string Breed { get; set; }
		public int Age { get; set; }
		public bool IsHungry { get; private set; }

		public Dog(string name, string breed, int age)
		{
			Name = name;
			Breed = breed;
			Age = age;
			IsHungry = true;
		}

		public void Bark()
		{
			Console.WriteLine($"{Name} says: Woof! Woof!");
		}

		public void Eat(string food)
		{
			Console.WriteLine($"{Name} is eating {food}.");
			IsHungry = false; 
		}
	}
}
