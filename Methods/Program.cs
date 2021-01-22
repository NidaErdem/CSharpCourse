using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // neden metotyazarız? -veri tabanına bir kullanıcının bilgilerini kaydetmek istiyoruzz.. 
            //gidip tek tek gerekli olan yerlere bunu yazabiliriz ama bir şeyi değiştirmek istediğimizde yine tek tek onlarca yeri değiştirmemiz gerekmektedir..
            //metotlar ile bir işlemi yaptığımızda ve o işlemi tekrar kullandığımızda aynı metotu kullanıp tek merkezde kontrol ederiz..
            //metotu yazdıktan sonra metotun çağırımını gerçekleştirmeliyiz..
            Add();
            //aşağıda kurulan metotun ismi Add olduğu için burada aynen kullanabilirim..
            //farklı yerlerde buna ("Added!" yazısına ihtiyacım olduğunda hep Add(); yazarım..
            Add();
            Add();
            Add();
            Add2(20, 30);
            //burada çalıştırdığımızda added dışında başka bir şey görmeyiz..
            //bunun sebebi ise add2 metotunu oluştururken sadece bir hesap yaptık ve sonuç döndürdük
            //şöyle yaparsak burda yazar..
            var result = Add2(20, 30);
            Console.WriteLine(result);
            //şimdi toplam sonucu çıktı ekranında yazıyor..
            //var yerine int de diyebilirim, eski dersi hatırla.. result bir int değişkeni olduğu için int koyabilirdim.. ama var değişken tipini otomatik içinde seçiyor..ü

            int number3 = 20;
            int number4 = 100;
            //şeklinde 2 değişken tanımladık..
            var result2 = Add3(number3, number4);
            Console.WriteLine(result2);
            //bu şekilde sıkıntı yok result2 yi ekrana yazdırdık..peki ben şöyle yazsaydım bu şartlarda sonuç ne olurdu?
            Console.WriteLine(number3);
            //fakat 112. satırda olduğu gibi (satır sayısı değişebilir düzelt onu..) number3=30 yazdık..
            //çalıştırırsak burada number3 ü 30 number4 ü 100 alacak ve cevap 130dur..
            //peki şu an number3 kaçtır? 20mi yoksa 30 mu? 
            //38. satırın cevabında da görüldüğü gibi number3 hala 20dir.. eee ama az önce aşağıya number3 = 30 demiştik, ona ne oldu?
            //32. ve 33. satırda değer tipler ile çalışıyoruz.. değer tiplerde mevzu tamamen değişkenin değeriyle ilgilidir..
            //yani Add3'e number3 yazdığımızda aslında oraya number3 değil onun sayısal değeri gitmektedir..
            //107. satıra git.. (satır değişebilir, bulamadım :))

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1,2,3,4,5,6));                   //params olduğu için istediğim kadar veri gönderebiliyorum şimdilik 1,2,3,4,5 ve 6 yı gönderdim (öylesine rakamlar yazdık yani önemi yok) cevabın 21 olması gerekiyor.. çalıştırdık ve cevap 21..




            Console.ReadLine();

        }

        //ben bir hesaplama işlemi yapmak istiyorum: toplama işlemi
        static void Add()
        {
            Console.WriteLine("Added!");
            //mesajı değişmek istediğimde buradan değiştiririm ve bütün Add(); komutları değişir..
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //PARAMETRELİ METOTLARLA ÇALIŞMAK

        static int Add2(int number1, int number2)
        {
            //burda bir mesaj vermek yerine gerçekten iki sayıyı toplamak istiyorum.. 
            //Bu yüzden yukarıya parametre gönderdik (int number1, int number2)
            //bu şu anlama gelir: Add2 yi kullanan kişinin number1 ve number2 isimli 2 tane değişkeni, parametreyi buraya göndermesi lazım..

            // return number1 + number2;  etkisiz hale getirdim alttakini kullancam..
            //bunları topla ve bana döndür demektir..
            //return altı görüldüğü gibi kırmızı çizgidir.. bunun sebebi bu bir void değildir..
            //void git şunu yap demektir.. yani bir işlem yap, bişey yaz, kayıt yap vs..
            //fakat burada ben sonuç olarak sayı tipinde veri istiyorum.. bu yüzden voidi sildim ve oraya int yazdım..

            //yukarıdaki kod şöyle de yazılabilirdi:
            var result = number1 + number2;
            return result;
            //yukarıda addlerin altına add2yi yazalım, çalıştırmak için.. yazarken parantez içinde bana diyor ki bana number1 ve number2 yu int olarak söyle..

        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //DEFAULT PARAMETRELİ METOTLARLA ÇALIŞMAK

        //burada da şöyle bir örnek verelim.. yukarıdaki örneği bir daha yazalım..
        //static int Add2(int number1, int number2=40)
        //var result = number1 + number2;
        //burada yukardakinden farklı olark number2=30 yazdık..
        //bu şu anlama gelir: eğer number2 değeri verilirse onu kullan ama verilmezse 30u kullan..
        //mesela default ile yazmadan önce yukarda toplama işlemini yazarken var result = Add(20, 30); yazmıştık..
        //ve 30 ya da 20 yi yazmayınca eror verriyordu..
        //default kullanırsak ve yazmazsak error vermeyecek ve yazılmayan number2 değeri için 40 yazacaktır.. 
        //default değerlerin her zaman metotun en sonunda olması gerekir.. yani number1 için default değeri veremiyorum.. her zaman sonuncu için default değeri verebilirim..
        //bunun yanında birden fazla default değeri verebilirim.. sondan başlayarak vermem gerekiyor..
        //mesela kdv hesaplarken genelde bunu kullanırız.. hiç değer vermezse %18 olsun verirse o değer olsun vs vs..

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //CHALLENGE: REF KEYWORD İLE ÇALIŞMAK

        static int Add3(int number3, int number4)
        {
            number3 = 30;
            return number3 + number4;
            //şimdi uygulamaya gidelim satır 32..
            //burada başka bir değişken tanımlıyoruz, isimleri aynı olsa bile bunların hiçbir alakası yoktur..
            //şimdi kodlar aşağıdan yukarı doğru okunuyor.. number3 e 20 değerni vermiştik sonra number3 değeri değişip 30 oldu..
            //fakat bu işlem hçbir zaman orjinal number3 ü bağlamaz..
            //ben eğer 20 olan number3ü buraya gönderirken burası başta 20 ve sonra 30 oluyor bilindiği gibi ama orjinal değer 20 kalıyor ya, heh işte ben diyorumki;
            //yok arkadaş ben orjinal number3ünde değişmesini istiyorum.. ben buraya hangi değeri yazarsam yazayım o da değişsin diyorsak Ref keyword ü ile göndermemiz gerekiyor
            //bunu yapabilmek için 102. satır şöyle olmalı.. static int Add3(ref int number3, int number4)
            //35. satır da şöyle olmalıdır.. var result2 = Add3(ref number3, number4);
            //referans tip gibi gönderildiği için iki tarafta da refi eklememiz lazım..
            //bu şekilde yaparsak yani hangi değeri değiştirdiysek onun önüne ref koyarak parametrenin orjinal değerini de değiştirmiş oluruz..
            // ref keyword ü ile değer tiplerinin referans tip gini kullanılması sağlar..
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //OUT KEYWORD İLE ÇALIŞMAK

        //refin alternatifidir..
        //bunu yapabilmek için 102. satır şöyle olmalı.. static int Add3(out int number3, int number4)
        //35. satır da şöyle olmalıdır.. var result2 = Add3(out number3, number4)
        //çalıştırdığımızda yine burada aynı sonucu, 30u alırız..
        //peki farkı nedir?
        //ref de number3ün mutlaka bir değeri olması gerekiyor.. ama out da böyle bir zorunluluk yok..

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //METHOD OVERLOADİNG

        //metodların daha farklı yazılış biçimidir..
        //çarpma metodu yazalım..

        static int Multiply(int number3, int number4)
        {
            return number3 * number4;
            //47.satırda uyguladık..
            //3 sayıyı çarpmak istiyorsam..?
        }

        //metodların ismi değişirse yani bazı yerlerde 2 bazı yerlerde 3lü çarpma yapcam ama biri multiply diğeri multiply2 olursa sıkıntı olabilir..
        //bu yüzden aynı ismide kullanabiliriz.. çünkü "int Multiply(int number3, int number4)" buraya metodun imzası deniliyor.. integer döndüren ve ismi multiply olan parametreleri de parantez içinde yazan..
        //biz aşağıdakinde aynı ismi kullandığımızda ama farklı parametreler kullandığımızda hiçbir sıkıntı olmaz..
        //buna metodların aşırı yüklenmesi denir..

        static int Multiply(int number3, int number4, int number5)
        {
            return number3 * number4 *number5;
            //48. satırda uyguladık..
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //PARAMS KEYWORD

        //static int Add4(int number1, int number2, int number3) //174de yazdığım gibi burayı inaktifleştirdim..
        //  {
        //  return number1 + number2 + number3;
        // }

        //şimdi iyi hoşda 40-50 tane toplama yapmak istediğimde tek tek böyle mi yapacağım? her biri için over loiding yazmam gerekiyor.. pek mantıklı hareket değil..
        //bunu şu şekilde yazacağım.. yukarıdakini // yaptım..


        static int Add4(params int [] numbers)                                      //dizi rotasyonu ile yazıyoryuz normalde ama şu an dizinin içeriğini doğal olarak bilmiyoruz..
        {                                                                           // yani burada dizi formatında 10-20-100 istediğim kadar parametreyi gönderirim..
            return numbers.Sum();                                                   //numbers dizisindeki parametreler sayısal olduğundan sonuna .Sum yazınca anlamı : dizideki bütün parametreleri topla sonucuda return et (zaten int)

            //satır 50 de bunu uygulayalım..
            //paramsla metodumuza aynı tipte istediğimiz kadar parametre gönderebiliriz.. 
            //params yaparken onun önüne yani öncesine istersek başka parametrelerde yerleştirebiliriz.. ama her zaman son parametreler paramsdakiler olmak zorunda..
        }

    }


}
