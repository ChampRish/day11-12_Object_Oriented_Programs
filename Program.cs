using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Q2_FetchJsonForRashan fetchJsonforRashan = new Q2_FetchJsonForRashan();
            Rashan rashanData = fetchJsonforRashan.Read("E:/c# git push/Day_11And12_Object_Oriented_Programs/Day_11And12_Object_Oriented_Programs/jsconfig1.json");
            for (int i = 0; i < rashanData.TypeRice.Count; i++)
            {
                var nameRice = rashanData.TypeRice[i].name;
                var weightRice = rashanData.TypeRice[i].weight;
                var pricesRice = rashanData.TypeRice[i].prices;
                Console.WriteLine(nameRice + "=" + (weightRice * pricesRice));
            }
            Console.WriteLine("-------------------------------------------");

            for (int j = 0; j < rashanData.TypeWheat.Count; j++)
            {
                var nameWheat = rashanData.TypeWheat[j].name;
                var weightWheat = rashanData.TypeWheat[j].weight;
                var pricesWheat = rashanData.TypeWheat[j].prices;
                Console.WriteLine(nameWheat + "=" + (weightWheat * pricesWheat));
            }

            Console.WriteLine("-------------------------------------------");
            for (int k = 0; k < rashanData.TypeRice.Count; k++)
            {
                var namePulses = rashanData.TypePulses[k].name;
                var weightPulses = rashanData.TypePulses[k].weight;
                var pricesPulses = rashanData.TypePulses[k].prices;
                Console.WriteLine(namePulses + "=" + (weightPulses * pricesPulses));
            }
            Console.ReadLine();

        }
    }
}
