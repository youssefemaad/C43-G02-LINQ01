using System;
using System.Linq;
using System.Collections.Generic;
using static Assignment_1.ListGenerator;

class Program
{
    static void Main()
    {
        
        #region LINQ - Restriction Operators
        // Find all products that are out of stock.
        var Result = ProductsList.Where(p => p.UnitsInStock == 0);
        // Find all products that are in stock and cost more than 3.00 per unit.
        Result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

        // Returns digits whose name is shorter than their value.
        string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var Result3 = Arr.Select((name, index) => new { name, index })
                                  .Where(x => x.name.Length < x.index)
                                  .Select(x => x.name);

        foreach (var digit in Result3)
        {
            Console.WriteLine(digit);
        }
        #endregion

        #region LINQ - Element Operator
        // Get first Product out of Stock
        var Result4 = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);

        // Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
        var Result5 = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);

        // Retrieve the second number greater than 5
        int[] numArr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var Result6 = numArr.Where(n => n > 5).ElementAt(1);


        #endregion


        #region LINQ - Aggregate Operators
        // Uses Count to get the number of odd numbers in the array
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var oddNumbers = numbers.Count(n => n % 2 == 1);

        // Return a list of customers and how many orders each has.
        var Result7 = CustomersList.Select(c => new { c.CustomerID, OrderCount = c.Orders.Count() });

        // Return a list of categories and how many products each has.

        // Get the total of the numbers in an array.

        // Get the total number of characters of all words in dictionary_english.txt

        // Get the length of the shortest word in dictionary_english.txt

        // Get the length of the longest word in dictionary_english.txt

        // Get the average length of the words in dictionary_english.txt
        #endregion

        #region LINQ - Ordering Operators
        // Sort a list of products by name.

        // Uses a custom comparer to do a case-insensitive sort of the words in an array.
        string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        // Sort a list of products by units in stock from highest to lowest.

        // Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

        // Sort first by-word length and then by a case-insensitive sort of the words in an array.

        // Sort a list of products, first by category, and then by unit price, from highest to lowest.

        // Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

        // Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
        #endregion

        #region LINQ - Transformation Operators
        // Return a sequence of just the names of a list of products.

        // Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

        // Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

        // Determine if the value of int in an array matches their position in the array.

        // Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };

        // Select all orders where the order total is less than 500.00.

        // Select all orders where the order was made in 1998 or later.
        #endregion


    }
}
