using System;
using System.Linq;

//Samed Semih Sürmeli
//samedsemihs@gmail.com
//09.06.2022

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcode = "2750365698450";
            barcode = CalculateCheckDigit(barcode);
            Console.WriteLine("new barcode: " + barcode);
        }

        private static string CalculateCheckDigit(string barcode)
        {
            int sumOfProduct = 0,
                checkDigit = 0;
            string newBarcode = "";

            barcode = barcode.Substring(0, barcode.Length - 1);

            var divideBarcode = barcode.Select(d => d - 48).ToList();

            int k = divideBarcode.Count;

            for (int i = 0; i < divideBarcode.Count; i++)
            {
                if ((i+2) % 2 == 0)
                    sumOfProduct += Convert.ToInt32(divideBarcode[i]) * 1;
                else
                    sumOfProduct += Convert.ToInt32(divideBarcode[i]) * 3;
            }

            if (sumOfProduct % 10 == 0)
                checkDigit = 0;
            else
                checkDigit = 10 - sumOfProduct % 10;

            newBarcode = barcode + checkDigit.ToString();

            return newBarcode;
        }
    }
}
