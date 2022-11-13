using System;
using System.Linq;

namespace _13._11._22_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");


            // Console.WriteLine(ReverseName("Ayaz Alakbarov"));


           // Console.WriteLine(Replace("A,c,a,d,e,m,y"));
        
        }





        //task--2den cox sozu ters cevir
        static string ReverseName(string word)
        {

            string str = word;

            string res = string.Join(" ", str.Split(' ').Select(str => new String(str.Reverse().ToArray())));

            return res;
        }





        static string Replace(string str)
        {

            foreach (var item in str)
            {
                str = str.Replace(",", "");
            }
            return str;
        }




























    }
}
