using System;
using System.Collections.Generic;

Console.WriteLine("Lütfen 5 tane kahve ismi giriniz: "); // Kullanıcıdan kahve isimlerini girmesini isteyen mesaj

List<string> Kahve = new List<string>(); // Kahve isimlerini saklayacak bir liste oluşturuluyor

// 5 kahve ismi almak için bir döngü
for (int i = 1; i < 6; i++) 
{
    // Kullanıcıdan her bir kahve ismini almak için konsola yazdırılır
    Console.Write($"Kahve {i} : "); 
    Kahve.Add(Console.ReadLine()); // Kullanıcının girdiği her kahve ismini listeye ekler
}

Console.WriteLine("-----------------------------"); // Görsel ayırıcı çizgi

Console.WriteLine("Girilen Kahve İsimleri:"); // Kullanıcıya girilen kahve isimlerini gösterecek mesaj

// Listeyi yazdırmak için foreach döngüsü kullanılır
foreach (string Kahveler in Kahve)
{
    Console.WriteLine(Kahveler); // Her bir kahve ismini konsola yazdırır
}
