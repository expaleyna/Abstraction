namespace AracYakitTuketim
{
    // interfacei tanımlıyorum
    public interface arabaYakit
    {
        double YakıtTuketimi();
    }

    // ortak özelliği abstract tanımlıyorum
    public abstract class Araba : arabaYakit
    {
        // arabaların 1 saatlik benzin verisi
        protected double benzinTuketimi;

        // yakıt hesaplıyorum
        public abstract double YakıtTuketimi();
    }

    // bmw
    public class BMWYakit : Araba
    {
        public BMWYakit()
        {
            benzinTuketimi = 80.0;
        }
        public override double YakıtTuketimi()
        {
            return benzinTuketimi;
        }
    }

    // mercedes
    public class MercedesYakit : Araba
    {
        public MercedesYakit()
        {
            benzinTuketimi = 70.0;
        }
        public override double YakıtTuketimi()
        {
            return benzinTuketimi;
        }
    }

    // porsche
    public class PorscheYakit : Araba
    {
        public PorscheYakit()
        {
            benzinTuketimi = 60.0;
        }
        public override double YakıtTuketimi()
        {
            return benzinTuketimi;
        }
    }

    //arabanın yakıt tüketimini önce giriyor sonra double verisi olarak YakıtTüketimi fonksiyonundan return ediyorum böylece veri maaş hesaplamasında olduğu gibi decimal olarak değil double tipinde dönüyor. 
}
