using System;

namespace odev1
{
    class program
    {
        static void Main(string[]args)
        {
            int a,b, sonuc;
                  string islem1, islem2;

                  Console.Write("1.Sayıyı Giriniz:");

                  islem1 = Console.ReadLine();
                  Console.Write("2 Sayıyı Giriniz:");
                  islem2= Console.ReadLine();

                  a=Convert.ToInt32(islem1);
                  b=Convert.ToInt32(islem2);

                  sonuc = a+b;
                  sonuc+=6;
                
                  Console.WriteLine(" Girmiş Olduğunuz 2 Sayının Toplamı:" + sonuc.ToString());

                  Console.ReadKey();



         

        }
    }
}   