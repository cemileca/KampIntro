namespace Metodlar
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int degerTipi1 = 5; // bu Değer tipi ise "ref" anahtar kelimesi ile kullanılacagı için, hemen/ tanındığı aşamada değer atanması mecburidir.
            int degerTipi2;
            var sonuc = RefOutFarkı(ref degerTipi1, out degerTipi2);
            Console.WriteLine(sonuc);
        }


        static int RefOutFarkı(ref int DegerTipi1, out int DegerTipi2)
        {
            DegerTipi2 = 7; // Şurada "Out" anahtar kelimesi kullanıldığı için Bu Değer tipine Mutlaka ve mutlaka bir değer atamak gerekli oldu.

            return DegerTipi1 + DegerTipi2;

        }
    }
}