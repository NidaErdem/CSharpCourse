using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //şimdi diğer uygulamada start diyince bu hoop çalışıyordu ancak bunda yani Framewok'de start diyince 2. ekran kodun çalıştığını götermek için saniyelik görünüp kapanıyor.
            //ne yazdırdığımı görmek için yani 2. ekranı görmek için her zaman şu kodu da yazmam gerekiyor.
            Console.ReadLine();
            //şimdi çalıştırınca ne yazdığımı görebilicem ve herhangi bir tuşa basarsam ekran kapanacaktır.. (enter)

            //---------------------------------------------------------------------------------------------------------------------------------------------

            //INT VERİ TİPİ

            int number1 = 10;
            Console.WriteLine("Number1 is {0}", number1);
            Console.ReadLine();
            //number1 is {0} demek şudur: virgülden sonraki ilk değeri yaz.. burada sıralama her zaman 0-1-2... vs
            //şimdi burda sadece Hello World yazmış olabilir, entera bas 10 yazısı da gelecektir.
            //Böyle olmasının sebebi ise readline komutu bizim basmamız ile kapanacağı için her yazıda bekleme yapıyor..
            //bütün veri tiplerinin bir sınırı vardır.. Eğer aşılırsa eror verir ve çalışmaz.. 
            //int aralıkları -2147483648 ile +2147483647 dır (o sayılar dahil)

            //------------------------------------------------------------------------------------------------------------------------------------------------

            //LONG VERİ TİPİ

            //int ın tam 2 katı kadar bellekte yer kaplar bu yüzden int değerleri arasındaysa int kullanılmalıdır..
            long number2 = 2147483648;
            //longun sınırları -9223372036854775808 ile +9223372036854775807 dir (o sayılar dahil)
            Console.WriteLine("Number2 is {0}", number2);
            Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------------------------------------------------

            //SHORT VERİ TİPİ

            //long 64 bit, int 32 bit, short ise 16 bitlik yer tutar.. Bunların hepsi tamsayıdır btw
            //sayı aralığı -32768 ile +32767
            short number3 = 32767;
            Console.WriteLine("Number3 is {0}", number3);
            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------------------------------------

            //BYTE VERİ TİPİ

            //bellekte 8 bit yani 1 byte yer kaplar..
            //0 ile 255 arasında değer tutar..
            byte number4 = 255;
            Console.WriteLine("Number4 is {0}", number4);
            Console.ReadLine();

            //----------------------------------------------------------------------------------------------------------------------------------------------------------

            //BOOLEAN (BOOL) VERİ TİPİ

            //Mantıksal bir veri tipidir..
            //Aslında tuttuğu değer true/false dur
            //if gibi karşılaştırma bloklarında çoğunlukla kullanılır.. yani şart doğruysa, geçerliyse bunu yap.. hatalıysa bunu yap..
            //condition = şart
            bool condition = false;

            //--------------------------------------------------------------------------------------------------------------------------------------------------------

            //CHAR VERİ TİPİ

            char charecter = 'A';
            //tek tırnakla yazılır.. Atama yaparız aslında o da tek tırnakla olur..
            //şey gibi düşün string city = "Ankara"; yazdığımızda city değişkeni Ankara yazısı yani 6 karakterden oluşan (harf) bir dizidir diyebiliriz..
            Console.WriteLine("Charecter is {0}", charecter);
            Console.ReadLine();
            //!!!!!!!!!!ÖNEMLİ NOT!!!!! KODLARIN ÇIKTISINI GÖRMEK İÇİN YAZILAN READLİNE KOMUTUNU HER ŞEY BİTTİKTEN SONRA SON SATIRA YAZARSAN TEK TEK BASMANA GEREK KALMADAN AÇILACAKTIR.
            //Ascii denilen olay = klavyedeki her karaketerin aslında bir sayısal değeri vardır.. Bu veri tipi yazı olmasına rağmen sayısal değer için şöyle yazılmalıdır:
            Console.WriteLine("Charecter is {0}", (int)charecter);
            Console.ReadLine();

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //DOUBLE VERİ TİPİ

            //sayısal değerlerdir.. hem ondalıklı hemde int gibi tam sayılı değerleri okuyabilir..
            double number5 = 10.4;
            Console.WriteLine("Number5 is {0}", number5);
            Console.ReadLine();
            //bellekte 64 bitlik veri tutuşu vardır

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //DECIMAL VERİ TİPİ

            //ınt için long neyse double içinde decimal odur..
            //double virgülden sonra 15-16 değer tutabiliyoken, decimal 28-29 tutabilir..
            decimal number6 = 10.4m;
            //m harfi küçük ya da büyük olabilir sıkıntı yok ama ondalıklı sayı ise koymalısın.. tam sayı ise m koyma..
            Console.WriteLine("Number6 is {0}", number6);
            Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //ENUM VERİ TİPİ

            //inam diye okunuyo hee dhfdhsf
            //en temel amacı : programlamada magic string denilen değerler tutmak yerine, örneğin;
            //string days ="Monday" ben bunu kullanılırken mondayi karşılaştırmam gerektiğinde onu yazmam gerekiyor.. 
            //fakat enum ile programlama yaparken merkezi bir noktadan biz bir enum sabiti vasıtasıyla tek tek yazmaktan kuruluruz..
            //classın dışında yazılır çünkü parantezlidir, parantez içinde olmaç, aşağı yazdım..
            //bir karşılaştırma yapacağım zaman;
            // if (Days.Friday==)
            // {
            //
            // }
            //bu şekilde tak tak yazarım enum olmasaydı if ("Friday") yazardım ve eğer bu friday sunday olarak değişeceği zaman programda gidip tek tek her yerden değiştirmem gerekiyor.
            //enum ile bu artık çok kolay.. reklamları izlediniz, tişikkirlir..
            //he değişiklik yapcağım zaman hangisini değiştirceksem enum tarafından değiştiririm
            //enumlarda tip değişimi önemlidir;
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
            //bu şekilde Friday yazdı .. tip dönüşümü de şöyle:
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
            //4 yazdı çünkü bu enum sabiti 4. sırada (0-1-2-3-4 vs..)
            //burada başlangıç değeride değşebilir, şöyle ki enum parantezinde Monday=10 dersen artık sıralama 10-11-12-13 vs olur..
            //en son hangisine değer atadıysam sonraki onun peşinden gider Monday=10 Tuesday=20 ise diğerlerine bişey atamazsam Wednesday=21 olur vs vs..
            //enum en sona kaydı sorry..

            //--------------------------------------------------------------------------------------------------------------------------------

            //VAR KEYWORD İLE ÇALIŞMAK

            //aslında bir değişken değildir , değişken tutmak için kullanılır... örneğin;
            var number7 = 10;
            //bizim burada atadağımız değerin tipi neyse var onu otomatik olarak seçer yani burada var bunu int olarak niteler..
            number7 = 'A';
            //bu şekilde yazabilirsin çünkü bu değerin bir sayısal karşılığı vardır.. ancak number7 = "A" yapamayız bu komple string değişkeni oluyor çünkü.. yani başta hangi tipse bundan sonra öyle devam edecektir..

            //----------------------------------------------------------------------------------------------------------------------------------

            //ŞART BLOKLARI

            //Belli bir şarta göre uygulamanın akışını değiştirmek için kullanılır..
            //bunun için yeni proje oluşturacağız
            //add new project- console app (.net framework)- isim: Conditionals



        }
    
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

            

}
