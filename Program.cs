using AracHareketleri;
using CalisanMaaslari;
using AracYakitTuketim;
namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------------------------------------------------------------//
            //1.Ödev
            //araç interfaceinden araba verilerimi alıyorum
            Arac bmw = new BMW();
            Arac mercedes = new Mercedes();
            Arac porsche = new Porsche();

            Console.WriteLine("Ödev 1:");

            //bmw verisi
            Console.WriteLine("BMW Özellikleri:");
            bmw.HizliGit();
            bmw.DenizdeYuz();
            bmw.HavadaUc();

            //mercedes verisi
            Console.WriteLine("\nMercedes Özellikleri:");
            mercedes.HizliGit();
            mercedes.DenizdeYuz();
            mercedes.HavadaUc();           

            //porsche verisi
            Console.WriteLine("\nPorsche Özellikleri:");
            porsche.HizliGit();
            porsche.DenizdeYuz();
            porsche.HavadaUc();

            Console.WriteLine("1. Ödevin Sonu\n\n ");
            //1. Ödevin Sonu
            //------------------------------------------------------------------------------------------------------------------------------------//
            //2. Ödevin Başı
            Console.WriteLine("Ödev 2:");

            //çalışanların nesnelerrini oluşturuyorum
            GenelMudur genelMudur = new GenelMudur();
            Mudur mudur = new Mudur();
            Programci programci = new Programci();
            Stajyer stajyer = new Stajyer();

            //maaş bilgilerini sayısal olarak maasinizNedir fonksiyonundan hesaplıyorum
            decimal genelMudurMaas = genelMudur.maasinizNedir();
            decimal mudurMaas = mudur.maasinizNedir();
            decimal programciMaas = programci.maasinizNedir();
            decimal stajyerMaas = stajyer.maasinizNedir();

            //maaş verilerini ekrana yazıyorum bilgi için
            Console.WriteLine("Genel Müdür maaşı: " + genelMudurMaas);
            Console.WriteLine("Müdür maaşı: " + mudurMaas);
            Console.WriteLine("Programcı maaşı: " + programciMaas);
            Console.WriteLine("Stajyer maaşı: " + stajyerMaas);

            // toplam maaşı da ayrı olarak en sona yazdırıyorum
            decimal toplamMaas = genelMudurMaas + mudurMaas + programciMaas + stajyerMaas;
            Console.WriteLine("Toplam maaş: " + toplamMaas);

            Console.WriteLine("2. Ödevin Sonu\n\n\n ");
            //2. Ödevin Sonu
            //------------------------------------------------------------------------------------------------------------------------------------//
            //3. Ödevin Başı
            Console.WriteLine("Ödev 3:");

            BMWYakit bmwYakit = new BMWYakit();
            MercedesYakit mercedesYakit = new MercedesYakit();
            PorscheYakit porscheYakit = new PorscheYakit();

            Console.WriteLine("BMW'nin 1 saatlik benzin tüketimi: " + bmwYakit.YakıtTuketimi() + " L");
            Console.WriteLine("Mercedes'in 1 saatlik benzin tüketimi: " + mercedesYakit.YakıtTuketimi() + " L");
            Console.WriteLine("Porsche'nin 1 saatlik benzin tüketimi: " + porscheYakit.YakıtTuketimi() + " L");

            double toplamTuketim = bmwYakit.YakıtTuketimi() + mercedesYakit.YakıtTuketimi() + porscheYakit.YakıtTuketimi();
            Console.WriteLine("Toplam benzin tüketimi: " + toplamTuketim + " L");

            Console.WriteLine("3. Ödevin Sonu\n\n\n ");
            Console.ReadLine();
            //3. Ödevin Sonu
            //------------------------------------------------------------------------------------------------------------------------------------//
            //4. Ödev
            //Dizi (Array), aynı türden birden fazla veriyi tek bir değişken içinde saklamamızı sağlayan yapılardır.
            //Düşünün ki elinizde birçok kalem var ve hepsini numaralandırarak sıraya dizer gibi, dizi de verileri sıralı bir şekilde tutar.
            //Böylece istediğiniz kaleme (veya veriye) indeks numarasıyla kolayca ulaşabilirsiniz.
            //Örneğin, bir sınıftaki öğrencilerin notlarını tutmak istiyorsunuz.
            //Notları tek tek saklamak yerine, bir dizi oluşturup her notu o dizinin bir elemanı olarak ekleyebilirsiniz.C# dilinde bu şöyle tanımlanabilir:
            //int[] ogrenciNotlari = new int[5];
            //Burada, dizinin her bir elemanına 0'dan başlayan indeks numarasıyla erişirsiniz.
            //Yani, ilk öğrencinin notu ogrenciNotlari[0], ikinci öğrencinin notu ogrenciNotlari[1] gibi.
            //Kısaca, dizi öğrenci ödevlerinde verileri düzenli tutmak, işlem yapmak ve saklamak için çok kullanışlı bir araçtır.
            //Her veri aynı türde olduğu için, bellekte de düzenli bir şekilde yer kaplar ve erişim işlemleri hızlıca yapılır.
            //Teşekkürler.
        }
    }
}
