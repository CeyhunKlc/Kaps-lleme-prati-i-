using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsullemePratik
{ 
    class program
    { 
        static void Main(string[] args)
        { 
           Personel P1= new Personel(); // p1 adında yeni bir personel tanımladık.
           
           P1.TCKİMLİKNO = "12345678956"; // p1 adındaki personelin tc numarasını tanımladık

           Console.WriteLine("TC Kimlik Numaranız : "+P1.TCKİMLİKNO); // personelin tc numarasını ekrana yazdırdık.
        }
    }
}