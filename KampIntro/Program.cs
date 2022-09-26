// See https://aka.ms/new-console-template for more information


using System.Windows;

Urunler Urun = new Urunler();
Urun.UrunAdi = "Yuzuk";
Urun.UrunKodu = 101;
Urun.TalebCokMu = true;
Urun.UrunKaliteDerecesi = 3;
Urun.UrunMarkasi = "TekTaş";

Urunler Urun1 = new Urunler();
Urun1.UrunAdi = "Bilerzik";
Urun1.UrunKodu = 100;
Urun1.TalebCokMu = true;
Urun1.UrunKaliteDerecesi = 2;
Urun1.UrunMarkasi = "Yektaş";

Urunler Urun2 = new Urunler();
Urun2.UrunAdi = "Kolye";
Urun2.UrunKodu = 125;
Urun2.TalebCokMu = false;
Urun2.UrunKaliteDerecesi = 1;
Urun2.UrunMarkasi = "Simpaş";

Urunler[] urunDizisi = new Urunler[] { Urun, Urun1, Urun2 };


Console.WriteLine("************************* for döngüsü *************************************");
for (int i = 0; i < urunDizisi.Length; i++)
{
    Console.WriteLine("Ürün Kodu: " + urunDizisi[i].UrunKodu + " " + "--Ürün Adi: " + urunDizisi[i].UrunAdi + " " + "--Ürüne Talep nedir? : " + (urunDizisi[i].TalebCokMu ? "Talep Çoktur" : "Talep Zayıftır") + " " + "--Ürün Kalitesi: " + (urunDizisi[i].UrunKaliteDerecesi == 3 ? "Düşük Kalite" : "Yüksek Kalite") + " " + "--Ürün Markası: " + urunDizisi[i].UrunMarkasi + "\n");
}

Console.WriteLine("************************* Foreach*************************************");

foreach (var urun in urunDizisi)
{
    Console.WriteLine("Ürün Kodu: " + urun.UrunKodu + " " + "--Ürün Adi: " + urun.UrunAdi + " " + "--Ürüne Talep nedir? : " + (urun.TalebCokMu ? "Talep Çoktur" : "Talep Zayıftır") + " " + "--Ürün Kalitesi: " + (urun.UrunKaliteDerecesi == 3 ? "Düşük Kalite" : "Yüksek Kalite") + " " + "--Ürün Markası: " + urun.UrunMarkasi + "\n");
}

Console.WriteLine("************************* While döngüsü *************************************");

int diziSayisi = urunDizisi.Length - 1;
while (diziSayisi != -1)
{
    Console.WriteLine("Ürün Kodu: " + urunDizisi[diziSayisi].UrunKodu + " " + "--Ürün Adi: " + urunDizisi[diziSayisi].UrunAdi + " " + "--Ürüne Talep nedir? : " + (urunDizisi[diziSayisi].TalebCokMu ? "Talep Çoktur" : "Talep Zayıftır") + " " + "--Ürün Kalitesi: " + (urunDizisi[diziSayisi].UrunKaliteDerecesi == 3 ? "Düşük Kalite" : "Yüksek Kalite") + " " + "--Ürün Markası: " + urunDizisi[diziSayisi].UrunMarkasi + "\n");
    diziSayisi--;
}

class Urunler
{
    public int UrunKodu { get; set; }
    public string UrunAdi { get; set; }
    public int UrunKaliteDerecesi { get; set; }
    public bool TalebCokMu { get; set; }
    public int Fiyat { get; set; }

    public string UrunMarkasi { get; set; }

}
