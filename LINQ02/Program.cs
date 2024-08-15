using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static LINQ02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region LINQ - Aggregate Operators
            //1.Get the total units in stock for each product category.
            //var Result = ProductsList.GroupBy(P=>P.Category)
            // .Select(C => new
            //{
            //    CategoryId = C.Key,
            //    TotalUnitsInStock = C.Sum(p => p.UnitsInStock)
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //2. Get the cheapest price among each category's products
            //var Result = ProductsList.GroupBy(P=>P.Category)
            // .Select(C => new
            //{
            //    CategoryId = C.Key,
            //     CheapestPrice = C.Min(p => p.UnitPrice)
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //3. Get the products with the cheapest price in each category (Use Let)
            //var Result = from p in ProductsList
            //             group p by p.Category into g
            //             let minPrice = g.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 CategoryId = g.Key,
            //                 CheapestProducts = g.Where(p => p.UnitPrice == minPrice)
            //             };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //4. Get the most expensive price among each category's products.
            //var Result = ProductsList
            //             .GroupBy(p => p.Category)
            //             .Select(g => new
            //             {
            //                 CategoryId = g.Key,
            //                 MostExpensivePrice = g.Max(p => p.UnitPrice)
            //             });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //5. Get the products with the most expensive price in each category.
            //var Result = ProductsList
            //             .GroupBy(p => p.Category)
            //             .Select(g => new
            //             {
            //                 CategoryId = g.Key,
            //                 MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(minProduct => minProduct.UnitPrice))
            //             });
            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.CategoryId);
            //    foreach (var Product in Category.MostExpensiveProducts)
            //    {
            //        Console.WriteLine( Product);
            //    }
            //}
            //6. Get the average price of each category's products.
            //var Result = ProductsList
            //             .GroupBy(p => p.Category)
            //             .Select(g => new
            //             {
            //                 CategoryId = g.Key,
            //                 AveragePrice = g.Average(p => p.UnitPrice)
            //             });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Set Operators
            //1. Find the unique Category names from Product List
            //var Result = ProductsList.Select(P => P.Category).Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //2. Produce a Sequence containing the unique first letter from both product and customer names.


            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var commonFirstLetters = ProductsList
            //                        .Select(p => char.ToUpper(p.ProductName[0]))
            //                        .Intersect(CustomersList.Select(c => char.ToUpper(c.CustomerName[0])));
            //foreach (var item in commonFirstLetters)
            //{
            //    Console.WriteLine(item);
            //}
            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductsList
            //            .Select(p => char.ToUpper(p.ProductName[0]))
            //            .Except(CustomersList.Select(c => char.ToUpper(c.CustomerName[0])));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ProductsList
            //             .Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
            //             .Concat(CustomersList.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Partitioning Operators
            //1. Get the first 3 orders from customers in Washington
            //var Result = CustomersList.Where(C => C.City == "Washington").SelectMany(c => c.Orders).Take(3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //2. Get all but the first 2 orders from customers in Washington.
            //var Result = CustomersList.Where(C => C.City == "Washington").SelectMany(c => c.Orders).Take(2);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, i) => n > i);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n % 3 != 0).ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            // 5.Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((n, i) => n >= i);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region LINQ - Quantifiers
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string filePath = "dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);
            //var Result = words.Any(word => word.Contains("ei"));

            //Console.WriteLine(Result);
            // 2.Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var Result = ProductsList.Where(P=>P.UnitsInStock==0).GroupBy(P=>P.Category).Select(g => new
            //{
            //    CategoryId = g.Key,
            //    Products = g.ToList()
            //});
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item.CategoryId);
            //     foreach (var item1 in item.Products)
            //     {
            //         Console.WriteLine(item1);
            //     }
            // }
            //3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).GroupBy(P => P.Category).Select(g => new
            //{
            //    CategoryId = g.Key,
            //    Products = g.ToList()
            //});
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item.CategoryId);
            //     foreach (var item1 in item.Products)
            //     {
            //         Console.WriteLine(item1);
            //     }
            // }
            #endregion
            #region LINQ – Grouping Operators
            //1.Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers
            //    .GroupBy(n => n % 5)
            //    .Select(g => new { Remainder = g.Key, Numbers = g.ToList() });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Numbers with a Remainder of {item.Remainder} when divided by 5");
            //    foreach (var n in item.Numbers)
            //    {
            //        Console.WriteLine(n);
            //    };
            //}
            //2.Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //string filePath= "dictionary_english.txt"; 
            //string[] words = File.ReadAllLines(filePath);

            //var groupedWords = words
            //    .GroupBy(word => char.ToUpper(word[0]))
            //    .Select(g => new
            //    {
            //        FirstLetter = g.Key,
            //        Words = g.ToList()
            //    });


            //foreach (var group in groupedWords)
            //{
            //    Console.WriteLine(group.FirstLetter);
            //    foreach (var word in group.Words)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            //3.Consider this Array as an Input String[] Arr = { "from", "salt", "earn", " last", "near", "form"}; Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            String[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            #endregion
        }
    }
}
