using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebAppForCross.Models;

namespace SampleWebAppForCross.Controllers
{
    public class HomeController : Controller
    {
        public Guid customerID { get; set; } = Guid.NewGuid();
        public class SomeType
        {
            public string StringData { get; }
            public int IntData { get; set; }
        }

        public class Customer
        {
            public int Discount() { return 0; }
        }

        public class PrivilegedCustomer : Customer
        {
            public new int Discount() { return 10; }
        }

        public IActionResult Index()
        {
            var type1 = new SomeType().GetType();
            type1.GetMembers().Where(member => member.MemberType == System.Reflection.MemberTypes.Constructor);
            var propertyType = type1.GetProperty("StringData").PropertyType;
            // var isReadOnly = type1.GetProperty("StringData").;

            var greatest = new Dictionary<string, string>()
            {
                {"a", "b" },
                {"c", "d" }
            };

            var p = new { Name = "n", DateOfBirth = new DateTime(1975, 6, 21) };
            string t1 = string.Format("{0}{1:D}", p.Name, p.DateOfBirth);
            string t2 = $"{p.Name}{p.DateOfBirth:D}";
            // string t3 = "{Name}{DateOfBirth:D}".Format(p);
            // string t4 = p.For
            // string t5 = StringTemplate

            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            List<int> b = new List<int>();
            b.Add(1);
            b.Add(2);
            b.Add(3);
            Console.WriteLine(a == b);

            int[][] jagged = new int[3][];

            Customer cust = new PrivilegedCustomer();
            Console.WriteLine(cust.Discount());

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
