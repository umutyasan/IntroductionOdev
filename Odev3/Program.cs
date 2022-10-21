namespace Odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float vize, final, ort=0, enbort = 0, enkort = 100, orttoplam = 0;
                        
            string adsoyad, adsoyadenb = "", adsoyadenk = "";
                    
                    
            Console.WriteLine("kaç öğrenci bilgisini istiyorsunuz?");
            int ogrsayisi = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (n < ogrsayisi)
            {
                Console.WriteLine($"{n + 1}. öğrecinin ad ve soyadını giriniz");
                adsoyad = Console.ReadLine();

                
                do
                {
                    Console.WriteLine($"{n + 1}. öğrencinin vize notunu giriniz");
                    vize = Convert.ToSingle(Console.ReadLine());
                } while (vize < 0 || vize > 100);

                do
                {
                    Console.WriteLine($"{n + 1}. öğrencinin final notunu giriniz");
                    final = Convert.ToSingle(Console.ReadLine());
                } while (final < 0 || final > 100);

                ort = vize * 0.4f + final * 0.6f;
                orttoplam += ort;
                if (ort > enbort)
                {
                    enbort = ort;
                    adsoyadenb = adsoyad;
                }
                if ( ort < enkort)
                {
                    enkort = ort;
                    adsoyadenk = adsoyad;
                }
                n++;
                                                                                              
            }
            Console.WriteLine($"sınıf geçme notu {orttoplam / n}");
            Console.WriteLine($"En Büyük Ortalama {enbort}. Öğrenci Adı ={adsoyadenb}");
            Console.WriteLine($"En Küçük Ortalama {enkort}. Öğrenci Adı ={adsoyadenk}");




            










        }
    }
}