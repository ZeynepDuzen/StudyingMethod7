using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StudyingMethod7
{
    internal class Program
    {
        static void Hobby(string hobby = "Coding")
        {
            Console.WriteLine(hobby);
        }
        static void Main(string[] args)
        {
            Hobby("Gardening");
            Hobby("Reading book");
            Hobby();
            Hobby("Swimming");
            Hobby("Fishing");

            Console.Read();
        }
    }
}
