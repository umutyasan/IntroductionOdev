namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int haksayisi = 3;

            while (haksayisi > 0)
            {
                Console.WriteLine("kullanıcı adını giriniz");
                string kullaniciadi = Console.ReadLine();

                Console.WriteLine("şifre giriniz");
                string sifre = Console.ReadLine();

                if (kullaniciadi == "umut yasan" && sifre == "123")
                {
                    Console.WriteLine("HOŞGELDİNİZ!");
                    break;
                }

                else
                {
                    Console.WriteLine("kullanıcı adı ve ya şifre yanlış. tekrar deneyiniz.");
                     
                    if (haksayisi > 0)
                    {
                        haksayisi-=1;
                    }
                    if (haksayisi == 0)
                        Console.WriteLine("deneme hakkınız bitmiştir");


                          
                    
                    
                }




            }
            
                










        }
    }
}