using System;

namespace NewPigLatinProject
{
	class Program
	
	{
		static string vowels = "aeiou";
		static char[] chars = vowels.ToCharArray();
		string word;
		
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Pig Latin Translator!");
			 GetFirstVowelIndex();

		}
		public static int GetFirstVowelIndex()
		{
			Console.WriteLine("Please enter a word");
			string word = Console.ReadLine().ToLower();
			int indexOfFirstVowel = 0;
			for (int i = 0; i < vowels.Length; i++)
			{
				indexOfFirstVowel = i;
				
			}return indexOfFirstVowel;
		}
		public static string FirstLetterIsVowel(string word, int indexOfFirstVowel)
		{
			if ((indexOfFirstVowel) == 0)
			{

			}
			
		}
	}
}
