using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            try
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int karesi = sayi * sayi;
                 Console.WriteLine("Girdiğiniz sayinin karesi : {0}",karesi);
            }catch (Exception)
            {
                Console.WriteLine("Gecersiz karakter girdiniz");
            }

            Console.ReadLine();
        }
    }
}
