using System;
using System.Collections.Generic; 
Console.WriteLine("** Davetliler **");

List<string> isim = new List<string>(); // string tipinde bir list tanımlıyoruz. 
{
    // Tek tek davetli isimleri burada ekliyoruz
    isim.Add("1 - Bülent Ersoy");
    isim.Add("2 - Ajda Pekkan");
    isim.Add("3 - Ebru Gündeş");
    isim.Add("4 - Hadise");
    isim.Add("5 - Hande Yener");
    isim.Add("6 - Tarkan");
    isim.Add("7 - Funda Arar");
    isim.Add("8 - Demet Akalın");
}

foreach(string dolas in isim) // foreach ile dolaştırıp yazdırıyıoruz.
{
    Console.WriteLine(dolas);
}