using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSearchInfo
{
    //https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
    //https://www.thomasclaudiushuber.com/2021/02/25/c-9-0-pattern-matching-in-switch-expressions/
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (NorthwindEntities northwindEntities = new NorthwindEntities())
            //{

            //    var result = MyDataInformation.GetByCodi<Product>(northwindEntities.Products, "Chang", "ProductName");



            //    Console.WriteLine(result.ProductName);

            //    Console.ReadKey();
            //}

            //var obj = new Person();
            //string favoriteTask = "";

            //switch (obj) // Switching by object is not supported before C# 7.0
            //{
            //    case Developer dev: // typeof does not work here in any C# version
            //        favoriteTask = "Write code" + dev.FirstName;
            //        break;
            //    case Person _:
            //        favoriteTask = "Create meetings";
            //        break;
            //    case null: // The null pattern
            //        favoriteTask = "Look into the void";
            //        break;
            //    default:
            //        favoriteTask = "Listen to music";
            //        break;
            //}


          var d=   Singleton2.Instance;

            Console.WriteLine(d.test);


        }
    }
}
