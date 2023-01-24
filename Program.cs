using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int integers; 
        int sum_numbers = 0; 
        float average_numbers; 
        int largest = -50;
        int smallestPositive = 3000000;
        int tally = 0; 

        List<int> numbers = new List<int>(); 

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do{
            Console.Write("Enter a integers: ");
            string input = Console.ReadLine(); 
            integers = int.Parse(input);
            numbers.Add(integers);
        }   while (integers != 0);

        foreach (int instance in numbers)
        {
            tally += 1;
            sum_numbers += instance;
            if (instance > largest)
            {
                largest = instance;
            }
            if (instance > 0 && instance < smallestPositive)
            {
                smallestPositive = instance; 
            }

        }

        average_numbers = (float)sum_numbers / tally;

        Console.WriteLine($"The sum_numbers is: {sum_numbers}");
        Console.WriteLine($"The average_numbers is: {average_numbers}");
        Console.WriteLine($"The largest integers is: {largest}");
        Console.WriteLine($"The smallest positive integers is: {smallestPositive}");


    }
}