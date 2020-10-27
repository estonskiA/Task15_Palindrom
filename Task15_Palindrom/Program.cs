using System;
using System.Text.RegularExpressions;

namespace Task15_Palindrom
{
    class Palindrom 
    { 
       public void palindrom_check()
       {
            Console.WriteLine("Введите предложение без знаков препинания, сэр: ");
            string st = Console.ReadLine();
            st = Regex.Replace(st, @"\s+", "").ToLower();
            int st_length = st.Length;
            int flag = 1;
            for (int i = 0; i < st_length/2 + 1; i = i + 1)
            {
                if (st[i] != st[st_length - i - 1])
                {
                    Console.WriteLine("Не в этот раз, но... не теряйте надежду!");
                    flag = 0;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("Это он! Ура!");
            }
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Palindrom();
            p.palindrom_check();

        }
    }
}


