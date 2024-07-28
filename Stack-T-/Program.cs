internal class Program
{
    private static void Main(string[] args)
    {
        //Stack tanımlama
        var karakterYigini = new Stack<char>();

        //Ekleme
        Console.WriteLine("Stack'lerde elemanlarda LIFO - Son giren ilk çıkar ilkesi uygulanır.");
        karakterYigini.Push('Ş');
        karakterYigini.Push('ü');
        karakterYigini.Push('k');
        karakterYigini.Push('r');
        karakterYigini.Push('ü');

        Console.WriteLine("Yığın listesi:");
        foreach (var item in karakterYigini)
        {
            Console.Write(item);
        }
        Console.WriteLine();
        Console.WriteLine();

        //Çıkarma - Son giren eleman çıkartılır
        Console.WriteLine( karakterYigini.Pop() +  " yığından çıkarıldı");
        Console.WriteLine( karakterYigini.Pop() +  " yığından çıkarıldı");
        Console.WriteLine( karakterYigini.Pop() +  " yığından çıkarıldı");
        Console.WriteLine();

        Console.WriteLine("Yeni yığın listesi:");
        foreach (var item in karakterYigini)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        Console.WriteLine("ASCII Karakter Listesi:");

        var asciiKarakterler = new Stack<char>();
        for (int i = 65; i <= 90;i++)
        {
            asciiKarakterler.Push((char)i);
            Console.Write ($"{asciiKarakterler.Peek()} yığına eklendi. - ");
            Console.WriteLine($"Yığındaki karakter sayısı : {asciiKarakterler.Count}");
        }


        Console.WriteLine();
        Console.WriteLine("Yığından karakter çıkarmak için bir tuşa basın:");
        Console.ReadKey();

        // Diziye ekleme - sıralama tersine çevrilerek
        var asciiDizisi = asciiKarakterler.Reverse().ToArray();

        while (asciiKarakterler.Count > 0)
        {
            Console.Write($"{asciiKarakterler.Pop()} yığından çıkarıldı - ");
            Console.WriteLine($"Yığındaki eleman sayısı : {asciiKarakterler.Count}");
        }
        Console.WriteLine();
        Console.WriteLine("Karakter Sayısı : " + asciiKarakterler.Count);
        Console.WriteLine();

        Console.Write($"Yeni Dizi {asciiDizisi.GetType()} : ");

        foreach (var c in asciiDizisi)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("-----------------");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Bir sayı girin : ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        var sayiYigini = new Stack<int>();

        while(sayi > 0)
        {
            int k = sayi % 10;
            sayiYigini.Push(k);
            sayi = sayi / 10;
        }

        foreach (var s in sayiYigini)
        {
            Console.WriteLine(s);
        }
    }
}