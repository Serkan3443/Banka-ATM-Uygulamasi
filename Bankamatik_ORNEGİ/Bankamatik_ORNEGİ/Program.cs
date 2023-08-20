using System.ComponentModel.Design;

namespace Bankamatik_ORNEGİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long Bakiye = 250;
            string sifre = "ab18";
            Console.WriteLine("işleminizi kartlı:(1) veya kartsız:(2) işlem olarak seçiniz:");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen şifrenizi giriniz:");
            string pass = Console.ReadLine();
            int hak = 3;
            int sayac = 0;
            while (sayac < hak)
            {
                if (secim == 1 && sifre == pass)
                {

                    Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                    Console.WriteLine("Para çekmek için(1)`e basınız:");
                    Console.WriteLine("para yatırmak için(2)`ye basınız:");
                    Console.WriteLine("para transferleri için(3)`e basınız:");
                    Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                    Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                    Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                    Console.WriteLine("İşleminizi seçiniz:");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    switch(islem) 
                    {
                        case 1: 
                            Console.WriteLine("Bakiyeniz:" + Bakiye);
                            Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                            long tutar = Convert.ToInt64(Console.ReadLine());
                            if(tutar>Bakiye)
                            {
                                Console.Write("Yetersiz bakiye.Tekrar giriniz:");
                                tutar = Convert.ToInt32(Console.ReadLine());
                            }
                            Bakiye -= tutar;
                            Console.WriteLine("Yeni bakiyeniz:" + Bakiye);
                            Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                            int karar= Convert.ToInt32(Console.ReadLine());
                            if(karar==9)
                            {
                                Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                Console.WriteLine("Para çekmek için(1)`e basınız:");
                                Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                Console.WriteLine("para transferleri için(3)`e basınız:");
                                Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                Console.WriteLine("İşleminizi seçiniz:");
                                 islem = Convert.ToInt32(Console.ReadLine());

                            }
                            else if(karar==0)
                            {
                                Console.WriteLine("sistemden çıkış yaptınız.");
                                return;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Bakiyeniz:" + Bakiye);
                            Console.Write("Kredi kartına para yatırmak için (1)`i kendi hesabınıza para yatırmak için (2)`ye basınız:");
                            int paratransfer=Convert.ToInt32(Console.ReadLine());
                            if(paratransfer==1)
                            {
                                Console.WriteLine("Kredi kartı numaranızı giriniz:");
                                long kredikartno = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Göndermek istediğiniz miktarı giriniz:");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Kredi kartına gelen miktar:" + tutar);
                                Bakiye -= tutar;
                                Console.WriteLine("Hesapta Kalan bakiyeniz:" + Bakiye);
                            }
                            else if(paratransfer==2)
                            {
                                Console.WriteLine("Bakiyeniz:" +Bakiye);
                                Console.WriteLine("Hesabınıza para mı yatıracaksınız(Evet:e, Hayır:h):");
                                char sec=Convert.ToChar(Console.ReadLine());
                                if(sec=='e')
                                {
                                    Console.WriteLine("Hesabınıza yatırmak istediğiniz tutarı giriniz:");
                                    tutar = Convert.ToInt32(Console.ReadLine());
                                    Bakiye += tutar;
                                    Console.WriteLine("Yeni bakiyeniz:" + Bakiye);
                                    Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                                     karar = Convert.ToInt32(Console.ReadLine());
                                    if (karar == 9)
                                    {
                                        Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                        Console.WriteLine("Para çekmek için(1)`e basınız:");
                                        Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                        Console.WriteLine("para transferleri için(3)`e basınız:");
                                        Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                        Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                        Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                        Console.WriteLine("İşleminizi seçiniz:");
                                        islem = Convert.ToInt32(Console.ReadLine());

                                    }
                                    else if (karar == 0)
                                    {
                                        Console.WriteLine("sistemden çıkış yaptınız.");
                                        return;
                                    }
                                }
                            }
                            break;
                        case 3:
                            long miktar;
                            string hesapno = "12345678910";
                            string eftno ="TR1234565001";
                            Console.WriteLine("Başka Hesaba EFT işlemi yapmak için (1)`e, başka hesaba havale yapmak için (2)`ye basınız:");
                           int secimm=Convert.ToInt32(Console.ReadLine());
                            if(secimm==1)
                            {
                                Console.WriteLine("12 haneli eft numarası girin:");
                                string iban = Console.ReadLine();
                                if(eftno==iban)

                                {
                                    Console.WriteLine("Karşı hesaba göndermek istediğiniz miktarı giriniz:");
                                    tutar = Convert.ToInt32(Console.ReadLine());
                                    if (Bakiye > tutar)
                                    {
                                        Bakiye -= tutar;
                                        Console.WriteLine($"Hesabınızdan para çıktı, hesabınızda kalan para: {Bakiye} hesabınızdan çıkan para: {tutar} Türk lirasıdır:");
                                    }
                                    else if (Bakiye < tutar)
                                    {
                                        Console.WriteLine("Yetersiz bakiye");
                                    }
                                }
                               
                                while (eftno!=iban)
                                {
                                    Console.WriteLine("Yanlış bilgi girdiniz, tekrar deneyin");
                                    Console.WriteLine("12 haneli eft numarası girin:");
                                    iban = Console.ReadLine();

                                }
                                
                              
                           
                              
                            }
                            else if(secimm==2)
                            {

                               
                                Console.WriteLine("11 haneli hesap numrası giriniz:");
                                string hesap = Console.ReadLine();
                                if (hesap == hesapno)
                                {
                                    
                                    Console.WriteLine("Havale yoluyla göndermek istediğiniz miktarı giriniz:");
                                    tutar = Convert.ToInt32(Console.ReadLine());
                                    if (Bakiye > tutar)
                                    {
                                        Bakiye -= tutar;
                                        Console.WriteLine($"Hesabınızdan para çıktı, hesabınızda kalan para:{Bakiye} ve çıkan para: {tutar}:");
                                    }
                                    else if (Bakiye < tutar)
                                    {
                                        Console.WriteLine("Yetersiz bakiye");
                                    }
                                }
                               
                               
                                while (hesap!=hesapno)
                                {
                                    Console.WriteLine("Yanlış giridiniz, lütfen tekrar deneyiniz:");
                                    Console.WriteLine("11 haneli hesap numrası giriniz:");
                                    hesap = Console.ReadLine();

                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine("Eğitim ödemeleri sayfası şuan arızalı lütfen daha sonra tekrar deneyiniz!!!");
                            Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                            karar = Convert.ToInt32(Console.ReadLine());
                            if (karar== 9)
                            {
                                Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                Console.WriteLine("Para çekmek için(1)`e basınız:");
                                Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                Console.WriteLine("para transferleri için(3)`e basınız:");
                                Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                Console.WriteLine("İşleminizi seçiniz:");
                                islem = Convert.ToInt32(Console.ReadLine());

                            }
                            else if (karar == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("sistemden çıkış yaptınız.");
                                return;
                            }
                            break;
                        case 5:
                            Console.WriteLine("*******Ödemeler kısmına hoşgeldiniz:******");
                            Console.WriteLine("Bakiyeniz:" + Bakiye);
                            Console.WriteLine("Elektrik faturası için(1)");
                            Console.WriteLine("Telefon faturası için(2)");
                            Console.WriteLine("İnternet faturası için(3)");
                            Console.WriteLine("Su faturası için(4)");
                            Console.WriteLine("OGS faturası için(5)");
                            Console.WriteLine("İşleminizi seçiniz:");
                            int islem2=Convert.ToInt32(Console.ReadLine());

                            switch(islem2)
                            {
                                case 1:
                                    
                                    Console.WriteLine("Elektrik faturası ödeme sayfası");
                                    Console.WriteLine("Elektrik faturasını mı ödeyeceksiniz(Evet:e Hayır:h):");
                                    string cevap2=Console.ReadLine();
                                    if(cevap2=="e")
                                    {
                                        Console.WriteLine("Fatura  tutarınızı giriniz:");
                                        tutar = Convert.ToInt64(Console.ReadLine());
                                        if(Bakiye>tutar)
                                        {
                                            Bakiye -= tutar;
                                            Console.WriteLine("faturanız ödenmiştir ");
                                        }
                                        else if(Bakiye<tutar)
                                        {
                                            Console.WriteLine("Fturayı ödemek için bakiyeniz yetersizdir.");
                                        }
                                        Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                                        karar = Convert.ToInt32(Console.ReadLine());
                                        if (karar == 9)
                                        {
                                            Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                            Console.WriteLine("Para çekmek için(1)`e basınız:");
                                            Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                            Console.WriteLine("para transferleri için(3)`e basınız:");
                                            Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                            Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                            Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                            Console.WriteLine("İşleminizi seçiniz:");
                                            islem = Convert.ToInt32(Console.ReadLine());

                                        }
                                        else if (karar == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("sistemden çıkış yaptınız.");
                                            return;
                                        }
                                    }
                                    break;

                                case 2:

                                    Console.WriteLine("Telefon faturası ödeme sayfası");
                                    Console.WriteLine("Teleofon faturasını mı ödeyeceksiniz(Evet:e Hayır:h):");
                                     cevap2 = Console.ReadLine();
                                    if (cevap2 == "e")
                                    {
                                        Console.WriteLine("Fatura  tutarınızı giriniz:");
                                        tutar = Convert.ToInt64(Console.ReadLine());
                                        if (Bakiye > tutar)
                                        {
                                            Bakiye -= tutar;
                                            Console.WriteLine("faturanız ödenmiştir ");
                                        }
                                        else if (Bakiye < tutar)
                                        {
                                            Console.WriteLine("Faturayı ödemek için bakiyeniz yetersizdir.");
                                        }
                                        Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                                        karar = Convert.ToInt32(Console.ReadLine());
                                        if (karar == 9)
                                        {
                                            Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                            Console.WriteLine("Para çekmek için(1)`e basınız:");
                                            Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                            Console.WriteLine("para transferleri için(3)`e basınız:");
                                            Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                            Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                            Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                            Console.WriteLine("İşleminizi seçiniz:");
                                            islem = Convert.ToInt32(Console.ReadLine());

                                        }
                                        else if (karar == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("sistemden çıkış yaptınız.");
                                            return;
                                        }
                                    }
                                    break;
                                case 3:

                                    Console.WriteLine("İnternet faturası ödeme sayfası");
                                    Console.WriteLine("İnternet faturasını mı ödeyeceksiniz(Evet:e Hayır:h):");
                                    cevap2 = Console.ReadLine();
                                    if (cevap2 == "e")
                                    {
                                        Console.WriteLine("Fatura  tutarınızı giriniz:");
                                        tutar = Convert.ToInt64(Console.ReadLine());
                                        if (Bakiye > tutar)
                                        {
                                            Bakiye -= tutar;
                                            Console.WriteLine("faturanız ödenmiştir ");
                                        }
                                        else if (Bakiye < tutar)
                                        {
                                            Console.WriteLine("Faturayı ödemek için bakiyeniz yetersizdir.");
                                        }
                                        Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                                        karar = Convert.ToInt32(Console.ReadLine());
                                        if (karar == 9)
                                        {
                                            Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                            Console.WriteLine("Para çekmek için(1)`e basınız:");
                                            Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                            Console.WriteLine("para transferleri için(3)`e basınız:");
                                            Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                            Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                            Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                            Console.WriteLine("İşleminizi seçiniz:");
                                            islem = Convert.ToInt32(Console.ReadLine());

                                        }
                                        else if (karar == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("sistemden çıkış yaptınız.");
                                            return;
                                        }
                                    }
                                    break;
                                case 4:

                                    Console.WriteLine("Su faturası ödeme sayfası");
                                    Console.WriteLine("Su faturasını mı ödeyeceksiniz(Evet:e Hayır:h):");
                                    cevap2 = Console.ReadLine();
                                    if (cevap2 == "e")
                                    {
                                        Console.WriteLine("Fatura  tutarınızı giriniz:");
                                        tutar = Convert.ToInt64(Console.ReadLine());
                                        if (Bakiye > tutar)
                                        {
                                            Bakiye -= tutar;
                                            Console.WriteLine("faturanız ödenmiştir ");
                                        }
                                        else if (Bakiye < tutar)
                                        {
                                            Console.WriteLine("Fturayı ödemek için bakiyeniz yetersizdir.");
                                        }
                                        Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                                        karar = Convert.ToInt32(Console.ReadLine());
                                        if (karar == 9)
                                        {
                                            Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                            Console.WriteLine("Para çekmek için(1)`e basınız:");
                                            Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                            Console.WriteLine("para transferleri için(3)`e basınız:");
                                            Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                            Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                            Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                            Console.WriteLine("İşleminizi seçiniz:");
                                            islem = Convert.ToInt32(Console.ReadLine());

                                        }
                                        else if (karar == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("sistemden çıkış yaptınız.");
                                            return;
                                        }
                                    }
                                    break;
                                case 5:

                                    Console.WriteLine("OGS fsturası ödeme sayfası");
                                    Console.WriteLine("OGS faturasını mı ödeyeceksiniz(Evet:e Hayır:h):");
                                     cevap2 = Console.ReadLine();
                                    if (cevap2 == "e")
                                    {
                                        Console.WriteLine("Fatura  tutarınızı giriniz:");
                                        tutar = Convert.ToInt64(Console.ReadLine());
                                        if (Bakiye > tutar)
                                        {
                                            Bakiye -= tutar;
                                            Console.WriteLine("faturanız ödenmiştir ");
                                        }
                                        else if (Bakiye < tutar)
                                        {
                                            Console.WriteLine("Faturayı ödemek için bakiyeniz yetersizdir.");
                                        }
                                        Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                                        karar = Convert.ToInt32(Console.ReadLine());
                                        if (karar == 9)
                                        {
                                            Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                            Console.WriteLine("Para çekmek için(1)`e basınız:");
                                            Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                            Console.WriteLine("para transferleri için(3)`e basınız:");
                                            Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                            Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                            Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                            Console.WriteLine("İşleminizi seçiniz:");
                                            islem = Convert.ToInt32(Console.ReadLine());

                                        }
                                        else if (karar == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("sistemden çıkış yaptınız.");
                                            return;
                                        }
                                    }
                                    break;

                            }
                            break;
                        case 6:
                            string yenisifre = "serkan3434";
                            Console.WriteLine("Şifreni mi unuttun, Şifreni değiştirmek için 1`e bas:");
                             char cevap = Convert.ToChar(Console.ReadLine());
                            if(cevap=='1')
                            {
                                Console.WriteLine("Yeni şifrenizi girebilirsiniz");
                                pass = Console.ReadLine();
                                if(pass==yenisifre)
                                {
                                    Console.WriteLine("Şifreniz başarıyla güncellenmiştir");
                                    while(secim==1 && pass==yenisifre)
                                    {

                                        Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                        Console.WriteLine("Para çekmek için(1)`e basınız:");
                                        Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                        Console.WriteLine("para transferleri için(3)`e basınız:");
                                        Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                        Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                        Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                        Console.WriteLine("İşleminizi seçiniz:");
                                        islem = Convert.ToInt32(Console.ReadLine());

                                    }

                                }
                                Console.WriteLine("anamenüye dönmek için 9 çıkış yapmak için 0 a basınız:");
                                karar = Convert.ToInt32(Console.ReadLine());
                                if (karar == 9)
                                {
                                    Console.WriteLine("*******ANA MENÜYE HOŞGELDİNİZ:***********");
                                    Console.WriteLine("Para çekmek için(1)`e basınız:");
                                    Console.WriteLine("para yatırmak için(2)`ye basınız:");
                                    Console.WriteLine("para transferleri için(3)`e basınız:");
                                    Console.WriteLine("Eğitim Ödemeleri için(4)`e basınız:");
                                    Console.WriteLine("Ödemeler kısmı için(5)`e basınız:");
                                    Console.WriteLine("Bilgi Güncelleme için(6)`ya basınız:");
                                    Console.WriteLine("İşleminizi seçiniz:");
                                    islem = Convert.ToInt32(Console.ReadLine());

                                }
                                else if (karar == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("sistemden çıkış yaptınız.");
                                    return;
                                }

                            }
                            break;




                    }

                }
                else
                {

                    Console.WriteLine($"Yanlış şifre! Kalan deneme hakkı:{hak - sayac}");

                    Console.WriteLine("işleminizi kartlı:(1) veya kartsız:(2) işlem olarak seçiniz:");
                    secim = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen şifrenizi giriniz:");
                    pass = Console.ReadLine();

                    sayac++;


                }
            }
            if (sayac == hak)
            {
                Console.WriteLine("3 ten fazla yanlış giriş denemsi yaptınız! Sistemden atılıyorsunuz");
                return;
            }

        }
    }
}







