namespace HesapMakinesiOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi Programına Hoş Geldiniz.");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");

            Console.WriteLine("v1 - Sayı Toplama ve toplanan sayıların ortalamasını alma");
            Console.WriteLine("v2 - 4 işlem yapma (toplama/çıkarma/çarpma/bölme)");
            Console.WriteLine("v3 - Sayı girip işlem seçme");

            string secim = Console.ReadLine();

            if(secim == "1")
            {
                Console.Clear();
                Console.WriteLine("Kaç adet sayı toplamak istiyorsunuz: ");
                int adet = int.Parse(Console.ReadLine());

                double sayi = 0;
                double ortalama = 0;

                for (int i = 1; i <= adet; i++)
                {
                    Console.WriteLine(i + ". sayıyı giriniz: ");
                    sayi += int.Parse(Console.ReadLine());
                }

                ortalama = (double)sayi / (double)adet;

                Console.Clear();
                Console.WriteLine("Toplama sonucu: " + sayi);
                Console.WriteLine("Ortalama sonucu: " + ortalama);
            }

            if (secim == "2")
            {
                Console.Clear();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Çıkarma");
                Console.WriteLine("3 - Çarpma");
                Console.WriteLine("4 - Bölme");

                string v2secim = Console.ReadLine();

                if (v2secim == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Kaç adet sayı toplamak istiyorsunuz: ");
                    int adet = int.Parse(Console.ReadLine());

                    double sayi = 0;
                    double ortalama = 0;

                    for (int i = 1; i <= adet; i++)
                    {
                        Console.WriteLine(i + ". sayıyı giriniz: ");
                        sayi += int.Parse(Console.ReadLine());
                    }

                    ortalama = (double)sayi / (double)adet;

                    Console.Clear();
                    Console.WriteLine("Toplama sonucu: " + sayi);
                    Console.WriteLine("Ortalama sonucu: " + ortalama);
                }

                if (v2secim == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Kaç adet sayı çıkarmak istiyorsunuz: ");
                    int adet = int.Parse(Console.ReadLine());

                    int sayi = 0;

                    for (int i = 1; i <= adet; i++)
                    {
                        Console.WriteLine(i + ". sayıyı giriniz: ");

                        if (i == 1)
                        {
                            sayi = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            int islem = int.Parse(Console.ReadLine());
                            sayi -= islem;
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("Çıkarma sonucu: " + sayi);
                }

                if (v2secim == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Kaç adet sayı çarpmak istiyorsunuz: ");
                    int adet = int.Parse(Console.ReadLine());

                    int sayi = 1;

                    for (int i = 1; i <= adet; i++)
                    {
                        Console.WriteLine(i + ". sayıyı giriniz: ");
                        int carpim = int.Parse(Console.ReadLine());
                        sayi *= carpim;
                    }
                    Console.Clear();
                    Console.WriteLine("Çarpma sonucu: " + sayi);
                }

                if (v2secim == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Kaç adet sayı bölmek istiyorsunuz: ");
                    int adet = int.Parse(Console.ReadLine());
                    Console.WriteLine("1. sayıyı giriniz: ");
                    double bolme = int.Parse(Console.ReadLine());

                    for (int i = 1; i < adet; i++)
                    {
                        Console.WriteLine((i + 1) + ". sayıyı giriniz: ");
                        bolme /= int.Parse(Console.ReadLine());                        
                    }

                    Console.Clear();
                    Console.WriteLine("Bölme sonucu: " + bolme);
                }

            }

            if (secim == "3")
            {
                Console.Clear();
                Console.WriteLine("Sayı giriniz: ");
                double inputSayi = Convert.ToDouble(Console.ReadLine());

                bool sayi = true;

                while(sayi)
                {
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                    Console.WriteLine("1 - Toplama");
                    Console.WriteLine("2 - Çıkarma");
                    Console.WriteLine("3 - Çarpma");
                    Console.WriteLine("4 - Bölme");
                    Console.WriteLine("5 - sonuç");

                    string inputSecim = Console.ReadLine();

                    if(inputSecim == "1")
                    {
                        Console.WriteLine("Sayı giriniz: ");
                        double toplama = Convert.ToDouble(Console.ReadLine());

                        inputSayi += toplama;

                        Console.WriteLine("Toplama sonucu: " + inputSayi);
                    }
                    else if (inputSecim == "2")
                    {
                        Console.WriteLine("Sayı giriniz: ");
                        double cikartma = Convert.ToDouble(Console.ReadLine());

                        inputSayi -= cikartma;

                        Console.WriteLine("Çıkartma sonucu: " + inputSayi);
                    }
                    else if (inputSecim == "3")
                    {
                        Console.WriteLine("Sayı giriniz: ");
                        double carpma = Convert.ToDouble(Console.ReadLine());

                        inputSayi *= carpma;

                        Console.WriteLine("Çarpma sonucu: " + inputSayi);
                    }
                    else if (inputSecim == "4")
                    {
                        Console.WriteLine("Sayı giriniz: ");
                        double bolme = Convert.ToDouble(Console.ReadLine());

                        inputSayi /= bolme;

                        Console.WriteLine("Bölme sonucu: " + inputSayi);
                    }
                    else
                    {
                        Console.WriteLine("Hesaplama sonucu: " + inputSayi);
                        sayi = false;
                        Console.WriteLine("Çıkış yapmak için 'E' basınız.");
                        string cikis = Console.ReadLine();

                        if (cikis == "e" || cikis == "E")
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
