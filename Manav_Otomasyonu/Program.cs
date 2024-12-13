using System.Collections;

namespace Manav_Otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList meyveler = new ArrayList() { "Elma", "Portakal", "Limon", "Çilek" }; 
            ArrayList sebzeler = new ArrayList() { "Havuç", "Ispanak", "Domates", "Patlıcan" };
            ArrayList haldenAlinanMeyveler = new ArrayList();
            ArrayList haldenAlinanSebzeler = new ArrayList();
            ArrayList manavdanSecilenMeyveler = new ArrayList();
            ArrayList manavdanSecilenSebzeler = new ArrayList();
            #region HAL
            while (true)
            {
                Console.WriteLine("****HALE HOŞGELDİNİZ****");
                Console.WriteLine("Meyve için 'M' ve Sebze için 'S' basınız.");
                string halSecim = Console.ReadLine();
                if (halSecim.ToLower() == "m")
                {
                    foreach(string item in meyveler)
                    {
                        Console.WriteLine(item);
                    }
                    Console.Write("Bir ürün seçiniz: ");
                    haldenAlinanMeyveler.Add(Console.ReadLine());
                    Console.WriteLine("Kaç kilo: ");
                    haldenAlinanMeyveler.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Başka bir arzunuz var mı ?(evet/hayır)");
                    string arzuSecim = Console.ReadLine();
                    if (arzuSecim.ToLower() == "evet")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (halSecim.ToLower() == "s")
                {
                    foreach (string item in sebzeler)
                    {
                        Console.WriteLine(item);
                    }
                    Console.Write("Bir ürün seçiniz: ");
                    haldenAlinanSebzeler.Add(Console.ReadLine());
                    Console.WriteLine("Kaç kilo: ");
                    haldenAlinanSebzeler.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Başka bir arzunuz var mı ?(evet/hayır)");
                    string arzuSecim = Console.ReadLine();
                    if (arzuSecim.ToLower() == "evet")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış seçim");
                }

            }
            #endregion
            #region MANAV
            while (true)
            {
                Console.WriteLine("****MANAVA HOŞGELDİNİZ****");
                Console.WriteLine("Meyve için 'M' ve Sebze için 'S' basınız.");
                string manavSecim = Console.ReadLine();
                if(manavSecim.ToLower() == "m")
                {
                    if (haldenAlinanMeyveler.Count == 0)
                    {
                        Console.WriteLine("Halden bir meyve alınmamıştır");
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < haldenAlinanMeyveler.Count; i+=2)
                        {
                            Console.WriteLine(haldenAlinanMeyveler[i]);
                        }
                        Console.Write("Lütfen bir ürün seçiniz: ");
                        string urun = Console.ReadLine();
                        Console.Write("Kaç kilo alacaksınız: ");
                        int alinacakKilo = Convert.ToInt32(Console.ReadLine());
                        bool urunVarMi = false;
                        for (int i = 0; i < haldenAlinanMeyveler.Count; i += 2)
                        {
                            if (urun == (string)haldenAlinanMeyveler[i])
                            {
                                urunVarMi = true;
                                if (alinacakKilo > (int)haldenAlinanMeyveler[i + 1])
                                {
                                    Console.WriteLine($"Yeterli sayıda {urun} yok");
                                }
                                else
                                {
                                    haldenAlinanMeyveler[i + 1] = (int)haldenAlinanMeyveler[i + 1] - alinacakKilo;
                                    if (manavdanSecilenMeyveler.Contains(urun))
                                    {
                                        int index = manavdanSecilenMeyveler.IndexOf(urun);
                                        manavdanSecilenMeyveler[index + 1] = (int)manavdanSecilenMeyveler[index + 1] + alinacakKilo;
                                    }
                                    else
                                    {
                                        manavdanSecilenMeyveler.Add(urun);
                                        manavdanSecilenMeyveler.Add(alinacakKilo);
                                    }
                                }
                            }
                        }
                        if (!urunVarMi)
                        {
                            Console.WriteLine("Ürün yok");
                        }
                    }
                    Console.WriteLine("Başka bir arzunuz var mı ?(evet/hayır)");
                    string arzuSecim = Console.ReadLine();
                    if (arzuSecim.ToLower() == "evet")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if(manavSecim.ToLower() == "s")
                {
                    if (haldenAlinanSebzeler.Count == 0)
                    {
                        Console.WriteLine("Halden bir sezbe alınmamıştır");
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < haldenAlinanSebzeler.Count; i += 2)
                        {
                            Console.WriteLine(haldenAlinanSebzeler[i]);
                        }
                        Console.Write("Lütfen bir ürün seçiniz: ");
                        string urun = Console.ReadLine();
                        Console.Write("Kaç kilo alacaksınız: ");
                        int alinacakKilo = Convert.ToInt32(Console.ReadLine());
                        bool urunVarMi = false;
                        for (int i = 0; i < haldenAlinanSebzeler.Count; i += 2)
                        {
                            if (urun == (string)haldenAlinanSebzeler[i])
                            {
                                urunVarMi = true;
                                if (alinacakKilo > (int)haldenAlinanSebzeler[i + 1])
                                {
                                    Console.WriteLine($"Yeterli sayıda {urun} yok");
                                }
                                else
                                {
                                    haldenAlinanSebzeler[i + 1] = (int)haldenAlinanSebzeler[i + 1] - alinacakKilo;
                                    if (manavdanSecilenSebzeler.Contains(urun))
                                    {
                                        int index = manavdanSecilenSebzeler.IndexOf(urun);
                                        manavdanSecilenSebzeler[index + 1] = (int)manavdanSecilenSebzeler[index + 1] + alinacakKilo;
                                    }
                                    else
                                    {
                                        manavdanSecilenSebzeler.Add(urun);
                                        manavdanSecilenSebzeler.Add(alinacakKilo);
                                    }
                                }
                            }
                        }
                        if (!urunVarMi)
                        {
                            Console.WriteLine("Ürün yok");
                        }
                    }
                    Console.WriteLine("Başka bir arzunuz var mı ?(evet/hayır)");
                    string arzuSecim = Console.ReadLine();
                    if (arzuSecim.ToLower() == "evet")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış seçim");
                }

            }
            #endregion
            #region Musteri Listesi
            if (manavdanSecilenMeyveler.Count == 0)
            {
                Console.WriteLine("Manavdan Meyve alınmamıştır.");
            }
            else
            {
                for (int i = 0; i < manavdanSecilenMeyveler.Count; i += 2)
                {
                    Console.WriteLine($"{manavdanSecilenMeyveler[i]}: {manavdanSecilenMeyveler[i + 1]} kg");
                }
            }
            Console.WriteLine("************");
            if (manavdanSecilenSebzeler.Count == 0)
            {
                Console.WriteLine("Manavdan Sebze alınmamıştır.");
            }
            else
            {
                for (int i = 0; i < manavdanSecilenSebzeler.Count; i += 2)
                {
                    Console.WriteLine($"{manavdanSecilenSebzeler[i]}: {manavdanSecilenSebzeler[i + 1]} kg");
                }
            }

            #endregion
        }
    }
}
