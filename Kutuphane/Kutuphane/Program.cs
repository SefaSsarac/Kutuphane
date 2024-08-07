using Kutuphane;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main()
    {
        // Default Constructor ile kitap nesnesi oluşturma
        Kitap kitap1 = new Kitap();
        kitap1.KitapAdi = "Aylin";
        kitap1.YazarAdi = "Ayşe";
        kitap1.YazarSoyadi = "Kulin";
        kitap1.SayfaSayisi = 398;
        kitap1.Yayınevi = "Remzi Kitabevi";
        kitap1.BilgileriYazdir();

        // Alternatif Constructor ile kitap nesnesi oluşturma
        Kitap kitap2 = new Kitap("Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
        kitap2.BilgileriYazdir();
    }
}
