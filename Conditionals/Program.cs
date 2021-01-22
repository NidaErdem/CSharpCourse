using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            //burada ben sayının geliş değerine göre bir karar bloğu yapabilirim.. bu sayı belli şartlarda değişen bir sayı olabilirdi..
            //ifdeki parantez içi şart bloğuna karşılık gelir..
            //eşittir işlemini karşılaştırma işlemlerinde yapmak istersek == yazılır.. = tek eşittir atamaya denk geliyor, doğal olarak...
            //Eğer sayı 10 ise: if(number==10)

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
                //burada sayı 10 ise o yazı yazılacak ki zaten yukarıda değerini yazmıştık..
                //hangi projeyi çalıştırmak istiyorsak ona sağ tıkla ve set as startup project e tıkla..
            }
            else if (number == 20)
            {

                Console.WriteLine("Number is 20");

            }
            else
            {
                Console.WriteLine("Number is not 10");
            }
            //bu ikisini aynı zamanda şöyle de yazabiliriz:
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            //önce şart bloğu-soru işareti- true durum- false durum

            //sayı 10da bunu yap, 20de bunu yap, diğerlerinde şunu yap demek için if - else if -else


            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {

                Console.WriteLine("Number is 20");

            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //SWITCH BLOĞU

            //iflerin farklı versiyonu..
            //aynı kodun switch versyonu:


            switch (number)
            {

                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }

            //ÇOKLU ŞARTLARDA ÇALIŞMAK...

            //örnek uygulama : bir sayının yüzlük dilimlerde nereye geldiğini bulmaya çalışalım.. sayımız yukarıdaydı zaten:20..


            if (number >= 0 && number <= 100)
            {

                //number büyük eşittir 0 ve number küçük eşittir 100 ise.. yani iki şart birden sağlanırsa...
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if(number > 200 || number < 0)
            {
                //number büyüktür 200 ya da number küçüktür 0..
                //gündelik hayat için.. bana ahmeti ve ayşeyi çağır.. bana ahmeti veya/ya da ayşeyi çağır..
                Console.WriteLine("Number is less than 0 or greater than 200");
            }
            //aslında burda else yazmaya gerek yok.. bütün şartları zaten yazdık..

            //İÇ İÇE İFLER..
            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {

                }
            }

            //dıştan içe doğru gidilir.. sayımız 11di ilk şartı sağladı, sayı 100 den küçük.. ama 2. şartı sağlamadı..








            Console.ReadLine();
        }
    }
}
//yeni proje açıyoruz, yine framework ismi: Methods