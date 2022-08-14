internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** while examples ******");
        Console.WriteLine("Lutfen Ortalamasini Istediginiz Sayiyi Giriniz: ");
        int sayi = int.Parse(Console.ReadLine().Trim());
        int sayac =1; //1'den baslayarak girilen sayiya kadar olan sayilarin ortalamasi icin
        int toplam =0;
        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }
        Console.WriteLine("Girdiginiz sayinin ortalamasi: "+toplam/sayi);

        char chr = 'a';
        while (chr <= 'z')
        {
            Console.Write(chr);
            chr++;
        }

        string[] cars = {"BMW","Audi","Volkswagen","Mercedes"};
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

    }
}