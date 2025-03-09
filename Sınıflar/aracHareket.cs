using AracYakitTuketim;

namespace AracHareketleri
{
    //araba interfacei
    public interface Arac
    {
        void HizliGit();
        void DenizdeYuz();
        void HavadaUc();
    }
    //bmw çok hızlı gider, denizde yüzer, havada uçar
    public class BMW : Arac
    {
        public void HizliGit()
        {
            Console.WriteLine("BMW çok hızlı gidiyor.");
        }

        public void DenizdeYuz()
        {
            Console.WriteLine("BMW denizde yüzüyor.");
        }

        public void HavadaUc()
        {
            Console.WriteLine("BMW havada uçuyor.");
        }

        public static implicit operator BMW(BMWYakit v)
        {
            throw new NotImplementedException();
        }
    }

    //mercedes denizde yüzer, havada uçar
    public class Mercedes : Arac
    {
        public void HizliGit()
        {
            Console.WriteLine("Mercedes'in hızlı gitme özelliği bulunmuyor.");
        }

        public void DenizdeYuz()
        {
            Console.WriteLine("Mercedes denizde yüzüyor.");
        }

        public void HavadaUc()
        {
            Console.WriteLine("Mercedes havada uçuyor.");
        }
    }
    //porsche havada uçar
    public class Porsche : Arac
    {
        public void HizliGit()
        {
            Console.WriteLine("Porsche'nin hızlı gitme özelliği bulunmuyor.");
        }

        public void DenizdeYuz()
        {
            Console.WriteLine("Porsche denizde yüzemez.");
        }

        public void HavadaUc()
        {
            Console.WriteLine("Porsche havada uçuyor.");
        }
    }
}
