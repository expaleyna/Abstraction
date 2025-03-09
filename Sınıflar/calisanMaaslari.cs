namespace CalisanMaaslari
{
    //interfaceimi oluşturuyorum maaş için
    public interface CalisanMaas
    {
        decimal maasinizNedir();
    }
    //abstract sınıfım ile çalışanı tanımlıyorum
    public abstract class Calisan : CalisanMaas
    {
        public abstract decimal maasinizNedir();
    }

    //genel müdür
    public class GenelMudur : Calisan
    {
        public override decimal maasinizNedir()
        {
            return 80000;
        }
    }
    //müdür
    public class Mudur : Calisan
    {
        public override decimal maasinizNedir()
        {
            return 60000;
        }
    }
    //programcı
    public class Programci : Calisan
    {
        public override decimal maasinizNedir()
        {
            return 40000;
        }
    }
    //stajyer
    public class Stajyer : Calisan
    {
        public override decimal maasinizNedir()
        {
            return 5000;
        }
    }

    //maaşınız nedir fonksiyonuna return ile maaş miktarını gönderiyorum
}
