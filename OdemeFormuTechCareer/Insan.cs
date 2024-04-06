using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuTechCareer
{
    public class Insan
    {//scope
         //access modifiers dataType değişken adı
            public string adi = null;
            public string soyadi;
            //tam sayısal
            public int yas = 0;
            public double maas = 0.0;
            //true ya da false
            public bool cinsiyet = false;
            public static int boy;

            //metotlar fiiller
            //geriye değer döndüren, geriye değer döndürmeyen
            public void uyu(string isim, string soyisim)
            {
                Console.WriteLine(isim + " " + soyisim + " uyuyor....");
            }
            public void ekranaYaz(string isim, string soyisim)
            {
                Console.WriteLine("kişinin adı " + " " + adi + " " + "kişinin soyadı " + " " + soyadi);
            }
            public int yasiniz(int dogumYili)
            {
                int sonuc = 0;
                sonuc = DateTime.Now.Year - dogumYili;
                return sonuc;
            }

            public string yasHesap(int yas)
            {
                string mesaj = " ";
                if (yas > 0 && yas < 18)
                {
                    mesaj = "Küçüksünüz";
                }
                else if (yas > 18 && yas < 35)
                {
                    Console.WriteLine("Gençsiniz");
                }
                else if (yas > 35 && yas < 55)
                {
                    mesaj = "Yetişkinsiniz";
                }
                else if (yas > 55 && yas < 75)
                {
                    mesaj = "Gençsiniz";
                }
                else if (yas > 75 && yas < 99)
                {
                    mesaj = "Çok yaşlısınız";
                }
                else
                {
                    mesaj = "Geçersiz";
                }
                return mesaj;
            }

            //boş constructor
            public Insan()
            {

            }

            //parametre alan constructor
            public Insan(string adi, string soyadi)
            {
                this.adi = adi;  //this bulunduğumuz classı ifade ediyor
                this.soyadi = soyadi;
            }

            public Insan(string adi, string soyadi, int yas, double maas, bool cinsiyet)
            {
                this.adi = adi;
                this.soyadi = soyadi;
                this.yas = yas;
                this.maas = maas;
                this.cinsiyet = cinsiyet;
            }
        }
    }
