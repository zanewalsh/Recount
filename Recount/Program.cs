using System;
using System.Collections.Generic;
using System.Linq;

namespace Recount
{
	class Program
	{
		static void Main(string[] args)
		{
			IDictionary<string, int> candidates = new Dictionary<string, int>();
			string name;
			int maxCount = 0;
			int countOfMaxCount = 0;
			string maxName = "Someone Famous";
			int count = 0;

			do
			{
				//Getting name user input
				name = Console.ReadLine();
				// Checks right off the bad if it wants to end the vote
				if (name == "***")
				{
					break;
				}
				count++;
				// Check if the name is already in the dictonary
				if (candidates.ContainsKey(name))
				{
					candidates[name] += 1;
					if (candidates[name] > maxCount)
					{
						maxName = name;
						maxCount = candidates[name];
						countOfMaxCount = 1;
					}
					else if (candidates[name] == maxCount)
					{
						countOfMaxCount += 1;
					}
				}
				// If they're not in the dictionary, this else runs
				else
				{
					if (maxCount == 0)
					{
						maxName = name;
						maxCount = 1;
						countOfMaxCount = 1;
					}
					// Adds to dictonary
					candidates.Add(name, 1);
					if (maxCount == 1)
					{
						countOfMaxCount += 1;
					}
				}
			} while (name != "***");

			if (count <= 1 || countOfMaxCount > 1)
				Console.WriteLine("Runoff!");
			else
				Console.WriteLine(maxName);
		}

	}
}