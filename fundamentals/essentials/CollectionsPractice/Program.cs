using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] FirstArray = {0,1,2,3,4,5,6,7,8,9};

            string[] SecondArray = new string[4];
            SecondArray[0] = "Tim";
            SecondArray[1] = "Martin";
            SecondArray[2] = "Nikki";
            SecondArray[3] = "Sara";

            bool[] ThirdArray = new bool[10];
            for (int i = 0; i < ThirdArray.Length; i++) {
                bool TrueOrFalse;
                if (i == 0 || i % 2 == 0) {
                    TrueOrFalse = true;
                }
                else {
                    TrueOrFalse = false;
                }
                ThirdArray[i] = TrueOrFalse;
            }

            List<string> IceCreams = new List<string>();
            IceCreams.Add("Vanilla");
            IceCreams.Add("Chocolate");
            IceCreams.Add("Cookies and Cream");
            IceCreams.Add("Rocky Road");
            IceCreams.Add("Mint Chocolate Chip");

            Console.WriteLine(FirstArray[5]);
            Console.WriteLine(SecondArray[2]);
            Console.WriteLine(ThirdArray[8]);

            for (int i = 0; i < IceCreams.Count; i++) {
                Console.WriteLine(IceCreams[i]);
            }
        }
    }
}
