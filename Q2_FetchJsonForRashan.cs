using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_Program
{
     public class Q2_FetchJsonForRashan
    {
        public Rashan Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rashan>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading file");
                    return null;
                }
            }
        }
    }
}
