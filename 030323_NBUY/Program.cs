using System;
using System.IO;

namespace _030323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziye 1-200 arası eleman atama ve 100 den buyuk olanları yazdırma
            /* go:
                 int sayi = 0;
                 Console.WriteLine("Dizi Kaç Elemanlı Olsun");
                 int adet = Convert.ToInt32(Console.ReadLine());
                 Random rnd = new Random();
                 int[] sayilar = new int[adet];
                 for (int i = 0; i < sayilar.Length; i++)
                 {
                     sayilar[i] = rnd.Next(1, 200);
                     sayi = sayilar[i];

                     if (sayi >= 100)
                     {
                         Console.WriteLine("100DEN BUYUK OLANLAR" + " " + sayi);

                     }
                     else
                     {
                         Console.WriteLine("ELEMAN 100'den BUYUK DEGILDIR");
                     }

                 }
                 Console.WriteLine();
                 goto go; */
            #endregion

            #region Üstteki örnek farklı çözüm
            /*  int sayi = 0;
              Console.WriteLine("bir adet giriniz: ");
              int adet = int.Parse(Console.ReadLine());
              Random rnd = new Random();
              int[] sayilar = new int[adet];
              for (int i = 0; i < adet;)
              {
                  sayi = rnd.Next(20, 180);
                  if (sayi > 100)
                  {
                      sayilar[i] = sayi;
                      i++;
                  }
              }
              for (int i = 0; i < sayilar.Length; i++)
              {
                  Console.WriteLine("sayilar:[" + sayi + "]=" + sayilar[i]);
              } */
            #endregion

            #region Girilen Sayının Random Dizi İçerisinde Kaç Kere Tekrar Edildiğini Bulma
            /*   int sayi, tekrar = 0;
               Console.WriteLine("Sayi Girin : ");
               Random rnd = new Random();
               sayi = int.Parse(Console.ReadLine());
               Console.WriteLine("Dizi Kaç Elemanlı Olsun");
               int adet = Convert.ToInt32(Console.ReadLine());
               int[] sayilar = new int[adet];

               for (int i = 0; i < sayilar.Length; i++)

               {
                   sayilar[i] = rnd.Next(1, 10);
                   Console.WriteLine(sayilar[i] + "\t");

                   if (sayi == sayilar[i])
                   {
                       tekrar++;
                   }

               }
               Console.WriteLine();
               Console.WriteLine("Girdiğiniz sayı şu kadar tekrar edilmiştir" + " " + tekrar); */
            #endregion

            #region Kullanıcı Cumlesindeki Kelimeleri Ekrana Yazdırma
            /*string cumle;
            int kelime = 0;
            Console.WriteLine("Cumle Girin : ");
            cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');

            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.WriteLine(kelimeler[i]);
            } */
            #endregion

            #region 100 hücrelik hapishanede  
            /*  int toplam = 0;
              int[] mahkum = new int[100];
              for (int i = 0; i < 100; i++)
              {
                  toplam += i;
                  if (toplam % 2 == 1)
                  {
                      mahkum[i] = i;
                      Console.WriteLine($"çıkacak mahkumlar={mahkum[i]}");
                  }
              } */
            #endregion

            #region 100 hucrelık hapishane farklı cozum
            /*   int x = 0;
               int y = 1;
               int z = 0;

               int[] prison = new int[100];

               while (x < 100)
               {
                   for (int i = x; i < 100; i++)
                   {
                       prison[i] += y;
                   }
                   x++;
                   y++;
               }

               for (int i = 0; i < prison.Length; i++)
               {

                   if (prison[i] % 2 == 1)
                   {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine($"{prison[i]} ({i + 1}).hücresinin kapısı açık");

                   }
                   else
                   {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine($"{prison[i]} ({i + 1}.hücresinin kapısı kapalı)");
                   }
               } */
            #endregion

            #region 2 boyutlu dizi örnek
            /*  int[,] kup = new int[2, 3];
              kup[0, 0] = 8;
              kup[0, 1] = 9;
              kup[0, 2] = 16;
              kup[1, 0] = 11;
              kup[1, 1] = 12;
              kup[1, 2] = 13;

              for (int i = 0; i < 2; i++)
              {
                  for (int j = 0; j < 3; j++)
                  {
                      Console.WriteLine(kup[i, j]);
                  }
              } */
            #endregion

            #region iki boyutlu dizi olacak, diziye random değer atanıp dizinin ortalaması alınacak
            /*  int x, y;
              int t = 0;
              Random rnd = new Random();
              Console.WriteLine("Satır Sayısı Gir");
              x = int.Parse(Console.ReadLine());
              Console.WriteLine("Sütün Sayısı Gir");
              y = int.Parse(Console.ReadLine());
              int[,] dizi = new int[x, y];


              for (int i = 0; i < x; i++)
              {
                  for (int j = 0; j < y; j++)
                  {
                      dizi[i, j] = rnd.Next(1, 100);
                      t = t + dizi[i, j];
                      Console.WriteLine(dizi[i, j]);
                  }
              }
              int ort = t / (x * y);
              Console.WriteLine("ortalama" + " " + ort); */
            #endregion

            #region iki boyutlu dizi olacak, diziye random değer atanıp dizinin ortalaması alınacak farklı çözüm
            /*  go:
                  Random rand = new Random();
                  Console.WriteLine("satır sutün gir");
                  int x = Convert.ToInt32(Console.ReadLine());
                  int y = Convert.ToInt32(Console.ReadLine());
                  int[,] k = new int[x, y];
                  int t = 0;
                  for (int i = 0; i < k.GetLength(0); i++)
                  {
                      for (int j = 0; j < k.GetLength(1); j++)
                      {
                          k[i, j] = rand.Next(1, 100);
                          t = t + k[i, j];

                          Console.Write(k[i, j] + ",");
                      }
                      Console.WriteLine();

                  }
                  Console.WriteLine();
                  Console.WriteLine("ort :" + (t / (x + y)));
                  goto go; */
            #endregion

            #region 1 adet çift boyutlu dizi oluşturulacak bu dizi tek boyutlu diziye dönüştürülecek.
            /* int[,] diziçift = new int[4, 5];
             int[] dizitek = new int[20];//dizi içeriği çift dize elemanlarının çarpımı olmalı.
             Random rast = new Random();
             int sayac = 0;
             for (int i = 0; i < diziçift.GetLength(0); i++)
             {
                 for (int j = 0; j < diziçift.GetLength(1); j++)
                 {
                     diziçift[i, j] = rast.Next(1, 10);
                     Console.WriteLine(diziçift[i, j] + "\t");
                 }
                 Console.WriteLine("\n");
             }
             for (int i = 0; i < diziçift.GetLength(0); i++)
             {
                 for (int j = 0; j < diziçift.GetLength(1); j++)
                 {
                     dizitek[sayac] = diziçift[i, j];
                     sayac++;
                 }
                 Console.WriteLine("\n");
             } */
            #endregion

            #region METOD TANIMI
            /* static void Main(string[] args)
                 * { Yaz();  direkt aşağıdan yaz metodunun içerisindeki işlemleri yaptırır.
                 * }
                 * static void Yaz()
                 * {
                 * console.write("merhaba");
                 * }
                 */
            #endregion

            #region Metod denemesi
            /*   Yaz();
             *   
               static void Yaz()
               {
                   int tekrar;
                   Console.WriteLine("Kaç Kere Yazılsın");
                   tekrar = Convert.ToInt32(Console.ReadLine());
                   for (int i = 0; i < tekrar; i++)
                   {
                       Console.WriteLine("bugun ders erken bitsin lütfen!!!");
                   } 
               }*/
            #endregion

            #region Toplama Metodu
            /*  topla();

              static void topla()
              {
                  Console.WriteLine("Toplanacak Sayıları Giriniz : ");
                  int a = Convert.ToInt32(Console.ReadLine());
                  int b = Convert.ToInt32(Console.ReadLine());
                  int top = a + b;
                  Console.WriteLine("Toplama Sonucu:" + " " + top);
              } */
            #endregion

            #region Tek Çift Sayı Metodu
            /*  tekcift();

              static void tekcift()
              {
                  int sayi;
                  Console.WriteLine("Sayı Gir");
                  sayi = (Convert.ToInt32(Console.ReadLine()));

                  if (sayi % 2 == 0)
                  {
                      Console.WriteLine("Çift Sayı");
                  }
                  else
                  {
                      Console.WriteLine("Tek Sayı");
                  }
              } */
            #endregion

            #region Uc Sayıyı Buyukten Kucuge Sıralayan Metod
         /*   ucsayı();

        }

        private static void ucsayı()
        {
            int a, b, c;
            Console.WriteLine("3 SAYI GİR:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine(a + ">" + b + ">" + c);
            }
            else if (a > b && c > b)
            {
                Console.WriteLine(a + ">" + c + ">" + b);
            }
            else if (b > a && a > c)
            {
                Console.WriteLine(b + ">" + a + ">" + c);
            }
            else if (b > a && c > a)
            {
                Console.WriteLine(b + ">" + c + ">" + a);
            }
            else if (c > a && a > b)
            {
                Console.WriteLine(c + ">" + a + ">" + b);
            }
            else if (c > b && b > a)
            {
                Console.WriteLine(c + ">" + b + ">" + a);
            } */
            #endregion



        }
    }
}
