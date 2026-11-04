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
        }
    }
}
