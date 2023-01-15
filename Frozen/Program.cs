using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
	class Program
	{
	
		class Frozen
		{
			string name;
			string wish;
			

			public Frozen(string _name, string _wish)
			{
				name = _name;
				wish = _wish;
				
			}


			public string Name
			{
				get { return name; }
			}

			public string Wish
			{
				get { return wish; }
			}

			
		}
		static void Main(string[] args)
		{
			List<Frozen> myWishes = new List<Frozen>();
			string[] wishesFromFile = GetDataFromFile();

			foreach (string line in wishesFromFile)
			{
				string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
				Frozen newFrozen = new Frozen(tempArray[0], tempArray[1]);
				myWishes.Add(newFrozen);
			}

			foreach (Frozen wishFromlist in myWishes)
			{
				Console.WriteLine($"{wishFromlist.Name} wants {wishFromlist.Wish} for Christmas.");
			}



		}
		public static void DisplayElementsFromArray(string[] someArray)
		{
			foreach (string element in someArray)
			{
				Console.WriteLine($"Strinf from array: {element}");
			}
		}
		public static string[] GetDataFromFile()
		{
			string filePath = @"C:\Users\...\samples\Frozen.txt";
			string[] dataFromFile = File.ReadAllLines(filePath);

			return dataFromFile;
		}
	}
}
