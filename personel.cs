using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsullemePratik
{
    public class Personel
    {
        private string tckimlikno;

        public string TCKİMLİKNO // TCKİMLİKNO adında string property tanımladık  property get ve set blokları ile çalışır. 
        {
            get
            {
                return tckimlikno.Substring(0, 4) + "******"; //gizlilik için tc numarasının sadece ilk 5 hanesini göstermemizi sağladı 

            }
            set
            {
                bool kontrol = false;

                if (value.Length == 11)   // value: numaranın değerine tutan anahtar kelimedir.
                                          // Length : Nesne sayısını döndürür.
                                          //verilen numaranın  11 haneli olduğunu doğrular
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMİ = char.IsNumber(value[i]);  // girilen numaranın rakam olup olmadığını sorgular.

                        if (sayiMİ)
                        {
                            //yapmam gereken birşey yok
                        }
                        else
                        {
                            kontrol = true;  // girilen kimlik numarasında harf var ise aşağıdaki komutlar çalışır.
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("TC Numaranızda geçersiz karakter bulundu.");
                    }
                    else
                    {
                        tckimlikno = value;
                    }



                }
                else
                {
                    Console.WriteLine("Girdiniz TC No Eksik.");
                }

            }
        }

    }
}


