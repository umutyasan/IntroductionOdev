namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Vize Final Notu Hesaplama");

            // Console'^dan girilen vize ve final notları ile ortalamayı hesaplayan bu ortalamaya göre harfnotunu bulup ekrana ortalama ve harfnotunu yazan prog. yazınız.. tanımladığım değişkenleri kullanınız... 


            float vize, final, ort=0;

            // vize notu isteyiniz
            Console.WriteLine("Vize notunu gir");
            vize = Convert.ToSingle(Console.ReadLine());

            // final notu isteyiniz
            Console.WriteLine("Final notunu gir");
            final = Convert.ToSingle(Console.ReadLine());

           

            // ortalama hesaplayınız
            // ortalam vize notunun %40 finalnotunun %60 formülü ile hesaplanır. Formül (vizenotu * 0.4) + (finalnotu * 0.6)
            ort = vize * 0.4f + final * 0.6f; // ortalamayı bulduk

            string harfNotu="FF";

            // buranın altında otyalama göre harfnoyu hesaplanmalı

            // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

            if (ort > 85 && ort < 100)
            {
                Console.WriteLine(harfNotu = "AA");
            }
            else if (ort > 75 && ort < 84)

            {
                Console.WriteLine(harfNotu = "BA");
            }
            else if (ort > 65 && ort < 74)
            {
                Console.WriteLine(harfNotu = "BB");
            }
            else if (ort > 50 && ort < 64)
            {
                Console.WriteLine(harfNotu = "CC");
            }
            else if ( ort > 25 && ort < 49)
            {
                Console.WriteLine(harfNotu = "DC");
            }
            else
            {
                Console.WriteLine(harfNotu = "FF");
            }

            



            Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");


            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız


            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}