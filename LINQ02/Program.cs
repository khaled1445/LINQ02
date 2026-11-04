using LINQ02.DataSorces;
using LINQ02.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01 Get top 3 most expensive products

            //foreach (var p in Sources.ProductList.OrderByDescending(p => p.UnitPrice).Take(3))
            //    Console.WriteLine(p);
            #endregion

            #region Q02 show page 2 of products, with page size = 5

            //int pageNumber = 2, pageSize = 5;
            //foreach (var p in Sources.ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize))
            //    Console.WriteLine(p);

            #endregion

            #region Q03 Take products from the list as long as Their UnitPrice is less than $25 (list is ordered by price).

            //foreach (var p in Sources.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25))
            //Console.WriteLine(p);

            #endregion

            #region Q04 Check if ALL products in the "Seafood" category are in stock

            //bool allSeafoodInStock = Sources.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);
            //Console.WriteLine(allSeafoodInStock);
            #endregion

            #region Q05 Check if the ID list contains 9

            //int[] ids = { 3, 9, 13, 18 };
            //Console.WriteLine(ids.Contains(9));
            #endregion

            #region Q06 Group all products by Category and print each group with its product count.

            //foreach (var g in Sources.ProductList.GroupBy(p => p.Category))
            //{
            //    Console.WriteLine($"{g.Key} ({g.Count()})");
            //    foreach (var p in g) Console.WriteLine($"   {p}");
            //}
            #endregion

            #region Q07 Group products by Category and project only product names per group

            //var namesPerCategory = Sources.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });
            //foreach (var g in namesPerCategory)
            //{
            //    Console.WriteLine(g.Category);
            //    foreach (var name in g.Names) Console.WriteLine($"   {name}");
            //}
            #endregion

            #region Q08 Find all categories that have MORE THAN 3 products

            //foreach (var g in Sources.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3))
            //    Console.WriteLine($"{g.Key} ({g.Count()})");
            #endregion

            #region Q09 Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.

            //var byCountry =
            //from c in Sources.CustomerList
            //group c by c.Country into g
            //select new
            //{
            //    Country = g.Key,
            //    Count = g.Count(),
            //    TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //};
            //foreach (var x in byCountry) Console.WriteLine(x);
            #endregion

            #region Q10 Calculate the total number of units in stock across all products
            //Console.WriteLine(Sources.ProductList.Sum(p => p.UnitsInStock));
            #endregion

            #region Q11 Find the CHEAPEST and MOST EXPENSIVE product prices

            //Console.WriteLine($"Cheapest: {Sources.ProductList.Min(p => p.UnitPrice):C2}");
            //Console.WriteLine($"Most expensive: {Sources.ProductList.Max(p => p.UnitPrice):C2}");
            #endregion

            #region Q12 Get a distinct list of all product categories

            //foreach (var c in Sources.ProductList.Select(p => p.Category).Distinct())
            //    Console.WriteLine(c);
            #endregion

            #region Q13 find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //Console.WriteLine(string.Join(", ", setA.Except(setB)));
            #endregion

            #region Q14 Find countries that appear in list1 but NOT in list2 (case-insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //Console.WriteLine(string.Join(", ", list1.Except(list2, StringComparer.OrdinalIgnoreCase)));
            #endregion

            #region Q15.Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.

            //Dictionary<int, Product> productDict = Sources.ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(productDict[18]);
            #endregion

            #region Q16.Get the first product whose price is greater than $50.

            //Console.WriteLine(Sources.ProductList.First(p => p.UnitPrice > 50));
            #endregion


            #region Q17.Try to get the first product with a price > $500.it returns null instead of throwing.

            //var expensive = Sources.ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(expensive is null ? "null (no product found)" : expensive.ToString());
            #endregion

            #region Q18.Generate a multiplication table row for 7

            //foreach (var i in Enumerable.Range(1, 10))
            //    Console.WriteLine($"7 x {i} = {7 * i}");
            #endregion

            #region Q19.Generate even numbers between 1 and 30.

            //Console.WriteLine(string.Join(", ", Enumerable.Range(1, 30).Where(n => n % 2 == 0)));
            #endregion
           
            #region Q20.Concatenate the first 3 product names with the first 3 customer company names into a single sequence.

            //var combined = Sources.ProductList.Take(3).Select(p => p.ProductName)
            //    .Concat(Sources.CustomerList.Take(3).Select(c => c.CustomerName));
            //foreach (var s in combined) Console.WriteLine(s);
            #endregion


        }
    }
}
