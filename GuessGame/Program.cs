﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int randomNumber = random.Next(100, 999);
			int tries = 0;

			string Answer = randomNumber.ToString();
			var charAnswer = Answer.ToCharArray();

			List<int> NotClose = new List<int>();
			List<int> Close = new List<int>();
			List<int> HiT = new List<int>();
			
			bool exit = false;

			Console.WriteLine("Welcome to the Guessing Game.");
			Console.WriteLine(" ");
			Console.WriteLine("You will be prompted to guess a 3 digit number");
			Console.WriteLine(" ");
			Console.WriteLine("If the numbers in your guess do not match in any order, it will be put in the 'Not Close' catagory");
			Console.WriteLine("If at least one number in your guess matches but not in the right place, it will be put in the 'Close' catagory");
			Console.WriteLine("If at least one number in your guess matches in the right place, it will be put in the 'Hang in there' catagory");
			Console.WriteLine(" ");
			Console.WriteLine("Press any Key to continue. ");
			Console.WriteLine(" ");
			Console.ReadKey();

			while (exit == false)
			{
				Console.Clear();
				Console.WriteLine("   Not Close   ");
				Console.WriteLine("+-------------+");

				foreach (int Guess in NotClose)
				{
					Console.WriteLine(Guess + "     ");
				}

				Console.WriteLine("     Close");
				Console.WriteLine("+-------------+");

				foreach (int Guess in Close)
				{
					Console.WriteLine(Guess+ "     ");
				}
				Console.WriteLine(" Hang in There");
				Console.WriteLine("+-------------+");
				foreach (int Guess in HiT)
				{
					Console.WriteLine(Guess + "     ");
				}

				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("What is your guess??");
				int Guesses = int.Parse(Console.ReadLine());
				Console.WriteLine("");

				while (Guesses < 100)
				{
					Console.WriteLine("Not a Valid choice, Try again.");
					Console.WriteLine(" ");
					Console.WriteLine("What is your guess??");
					Guesses = int.Parse(Console.ReadLine());
				}

				while (Guesses > 999)
				{
					Console.WriteLine("Not a Valid choice, Try again.");
					Console.WriteLine(" ");
					Console.WriteLine("What is your guess??");
					Guesses = int.Parse(Console.ReadLine());
				}


				string GuessStr = Guesses.ToString();
				var GuessChar = GuessStr.ToCharArray();
				bool exit2 = false;

				while (exit2 == false)
				{
					int z = 0;
					int j = 0;
					if (GuessChar[z] == charAnswer[j])
					{
						HiT.Add(Guesses);
					}
					else if (GuessChar[z + 1] == charAnswer[j + 1])
					{
						HiT.Add(Guesses);
					}
					else if (GuessChar[z + 2] == charAnswer[j + 2])
					{
						HiT.Add(Guesses);
					}
					else if (GuessChar[z] == charAnswer[j + 1])
					{
						Close.Add(Guesses);
					}
					else if (GuessChar[z] == charAnswer[j + 2])
					{
						Close.Add(Guesses);
					}
					else if (GuessChar[z + 1] == charAnswer[j])
					{
						Close.Add(Guesses);
					}
					else if (GuessChar[z + 1] == charAnswer[j + 2])
					{
						Close.Add(Guesses);
					}
					else if (GuessChar[z + 2] == charAnswer[j])
					{
						Close.Add(Guesses);
					}
					else if (GuessChar[z + 2] == charAnswer[j + 1])
					{
						Close.Add(Guesses);
					}
					else
					{
						NotClose.Add(Guesses);
					}
					exit2 = true;
                }
				
				if (Guesses == randomNumber)
				{
					exit = true;
				}
				tries++;
			}
			Console.WriteLine("You've guessed the secret number " + randomNumber + "!!");
			Console.WriteLine("It took you " + tries + " tries!!");
			Console.ReadKey();
		}
	}
}
