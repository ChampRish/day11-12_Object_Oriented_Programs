using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11And12_Object_Oriented_Programs
{
    internal class Program
    {
            static void Main(string[] args)
            {
            string path = "E:/c# git push/Day_11And12_Object_Oriented_Programs/Day_11And12_Object_Oriented_Programs/jsconfig1.json";

            FetchDataForRice fetchDataForRice = new FetchDataForRice();
            Rice data = fetchDataForRice.Read(path);

            Console.WriteLine(data.Name);
            Console.WriteLine(data.Weight);
            Console.WriteLine(data.Price);
            Console.ReadLine();

        }
    }
}
