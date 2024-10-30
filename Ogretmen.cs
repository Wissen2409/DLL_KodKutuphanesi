using DLL_KodKutuphanesi;

public class Ogretmen{


    public Ogretmen()
    {
        Ogrenci o = new Ogrenci();

        // aynı proje içerisinde farklı bir sınıf içerisinden de internal üyeye eriştik!!!
        o.DerstenKac();
    }
}