using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kitap   // Kitap adında bir class oluşturuyoruz
    {
        // Property tanımlamaları       
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi {  get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayınevi { get; set; }
        public DateTime KayitTarihi { get; private set; }

        // Default Constructor
        public Kitap()
        {
            KayitTarihi = DateTime.Now;
            Console.WriteLine("Kitap nesnesi oluşturuldu.");
        }

        // Alternatif Constructor
        public Kitap(string kitapAdi, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            Yayınevi = yayinevi;
            KayitTarihi = DateTime.Now;
            Console.WriteLine("Kitap nesnesi oluşturuldu.");
        }

        // Kitap bilgilerini yazdırmak için bir metot
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Kitap Adı: {KitapAdi}, Yazar Adı: {YazarAdi}, Yazar Sayadı: {YazarSoyadi}, Sayfa Sayısı: {SayfaSayisi}, Yayınevi: {Yayınevi}, Kayıt Tarihi: {KayitTarihi}");
        }
    }
}