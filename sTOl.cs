using System;
using System.Collections.Generic;
using System.Linq;

namespace pLAYgROUND
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>
            {
                1,4,5
            };            

            Console.WriteLine(ListToString(list));

            Console.ReadKey();


        }

        public static string ListToString(List<int> list)
        {
            string st = "";
           
                st = string.Join(",",list);
            
            return st;
        }

        public static List<int> StringToList(string st) //st is a comma seperated string
        {
            
            var list = st.Split(',').Select(int.Parse).ToList();

            return list;
        }
    }
}
