namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console'dan alınan ay'ın mevsimini yazdıran prorgramı yapınız.
            Console.WriteLine("Lütfen ay giriniz");
            string ay = Console.ReadLine();

            if (ay=="ocak")
            {
                Console.WriteLine("KIŞ 1. AY");
            }
            else if (ay=="şubat")
            {
                Console.WriteLine("KIŞ 2. AY");
            }
            else if (ay=="mart")
            {
                Console.WriteLine("İLK BAHAR 3. AY");
            }
            else if (ay=="nisan")
            {
                Console.WriteLine("İLK BAHAR 4. AY");
            }
            else if (ay=="mayıs")
            {
                Console.WriteLine("İLK BAHAR 5. AY");
            }
            else if (ay=="haziran")
            {
                Console.WriteLine("YAZ 6. AY");
            }
            else if (ay=="temmuz")
            {
                Console.WriteLine("YAZ 7. AY");
            }
            else if (ay=="ağustos")
            {
                Console.WriteLine("YAZ 8. AY");
            }
            else if (ay=="eylül")
            {
                Console.WriteLine("SON BAHAR 9. AY");
            }
            else if (ay=="ekim")
            {
                Console.WriteLine("SON BAHAR 10. AY");
            }
            else if (ay=="kasım")
            {
                Console.WriteLine("SOn BAHAR 11. AY");
            }
            else
            {
                Console.WriteLine("KIŞ 12. AY");
            }


            Console.WriteLine("Lütfen ay giriniz");
            ay = Console.ReadLine();


            switch (ay)
            {
                                                                   
                case "OCAK":
                    Console.WriteLine("KIŞ - 1. AY");
                    break;
                case "ŞUBAT":
                    Console.WriteLine("KIŞ - 2. AY");
                    break;
                case "MART":
                    Console.WriteLine("İLK BAHAR - 3. AY");
                    break;
                case "NİSAN":
                    Console.WriteLine("İLK BAHAR - 4. AY");
                    break;
                case "MAYIS":
                    Console.WriteLine("İLK BAHAR - 5. AY");
                    break;
                case "HAZİRAN":
                    Console.WriteLine("YAZ - 6. AY");
                    break;
                case "TEMMUZ":
                    Console.WriteLine("YAZ - 7. AY");
                    break;
                case "AĞUSTOS":
                    Console.WriteLine("YAZ - 8. AY");
                    break;
                case "EYLÜL":
                    Console.WriteLine("SON BAHAR - 9. AY");
                    break;
                case "EKİM":
                    Console.WriteLine("SON BAHAR - 10. AY");
                    break;
                case "KASIM":
                    Console.WriteLine("SON BAHAR - 11. AY");
                    break;
                case "ARALIK":
                    Console.WriteLine("KIŞ - 12. AY");
                    break;

                default:
                    Console.WriteLine("GEÇERSİZ AY GİRDİNİZ");
                    break;
            }











            // eğer ay;  aralık-ocak-şubat      girilirse ekrana KIŞ 
            // mart-nisan-mayıs       girilirse ekrana İLK BAHAR
            // haziran-temmuz-ağustos girilirse ekrana YAZ 
            // eylük-ekim-kasım       girilirse ekrana SON BAHAR
            // mesajlarını veren programı yazınız.. Girilen ay için kaçıncı ay olduunu yazınız ekrana n. Ay şeklinde yazınız..

            // örnek;
            // klavyeden girilen ocak ayı için çıktı aşağıdaki gibi olmalıdır;
            // KIŞ
            // 1. Ay


            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}