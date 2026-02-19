// See https://aka.ms/new-console-template for more information
using Leetcode_Solution;
Console.WriteLine("Enter numbers (e.g., 123):");
string inputStr = Console.ReadLine();
int[] input = inputStr?.Select(c => int.Parse(c.ToString())).ToArray() ?? Array.Empty<int>();
Console.WriteLine("Enter target number:");
int target = int.Parse(Console.ReadLine());

int[] result = TwoSum.FindTwoSum(input, target);
if (result.Length > 0)
{
    Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    Console.WriteLine($"Values: {input[result[0]]}, {input[result[1]]}");
}
else
{
    Console.WriteLine("No two elements found with the given sum.");
}

Console.WriteLine("Enter terget character:");
char target = Console.ReadLine()[0]; // user types a
SmallestLetterGreterThanTerget solution = new SmallestLetterGreterThanTerget();
char returnedChar = solution.NextGreatestLetter(letters, target);
Console.WriteLine($"The smallest letter greater than '{target}' is: '{returnedChar}'");


