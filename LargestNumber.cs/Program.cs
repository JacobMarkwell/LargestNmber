using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 20;
        
        // Call the method to find the largest number
        int largest = FindLargest(num1, num2);
        
        // Print the result
        Console.WriteLine("The largest number between {0} and {1} is: {2}", num1, num2, largest);
    }

    // Method to find the largest number between two numbers
    static int FindLargest(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }
}