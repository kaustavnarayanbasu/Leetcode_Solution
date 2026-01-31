// See https://aka.ms/new-console-template for more information
using Leetcode_Solution;

Console.WriteLine("Enter characters (e.g., cfj):");
string input = Console.ReadLine();   // user types cfj
char[] letters = input.ToCharArray(); // convert string to char array

Array.Sort(letters);
foreach (char c in letters)
{
    Console.Write(c + " ");
}

Console.WriteLine("Enter terget character:");
char target = Console.ReadLine()[0]; // user types a
SmallestLetterGreterThanTerget solution = new SmallestLetterGreterThanTerget();
char returnedChar = solution.NextGreatestLetter(letters, target);
Console.WriteLine($"The smallest letter greater than '{target}' is: '{returnedChar}'");
