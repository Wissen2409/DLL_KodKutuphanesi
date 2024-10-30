

namespace DLL_KodKutuphanesi;

public class Ogrenci
{

    //dotnet new classlib komutu ile bir class Library oluşturduk!!
    // Exe ile DLL arasındaki en önemli fark : DLL'lerde main metodu yoktur!!
    // DDL dosyaları tek başlarına çalıştırılamazlar!!!
    // Her exe uygulamada kesinlikle bir main metot olmalıdır!!!
    // DLL dosyalarında main metot olmadığı için çalıştırılamazlar, zaten çalıştırmak için değil
    // başka uygulamalara yardımcı olmak için varlardır!!

    // dll dosyasını oluşturmak için , terminal ekranına dotnet build yazmanız yeterlidir!!
    public void Calis(){
        Console.WriteLine("Ögrenci çalıştı");
    }
    public void Uyu(){
        Console.WriteLine("Öğrenci uyudu!!!");

        // internal olan üyeye aynı sınıf içerisinden erişim mevcut!!
        DerstenKac();
    }
    internal void DerstenKac(){
        Console.WriteLine("Dersten kaçıldı");
    }
    // Not : DLL'i derlemek için, terminal ekranına dotnet build yazmanız gereklidir!!!!

    
    

}
