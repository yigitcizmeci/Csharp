using System.Collections;

internal class Program
{
    /*
     Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
    her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve 
    ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
    */
    private static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();

        Console.WriteLine("Please enter 20 number : ");
        for (int i = 0; i < 20; i++)
        {
            Console.Write((i + 1) + ". Number : ");
            while (true)
            {
                String numbers = Console.ReadLine();

                if (int.TryParse(numbers, out int number) && number > 0)
                {
                    arrayList.Add(number);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number only.");
                }
            }

        }
        double MinAvarage = 0;
        double MaxAvarage = 0;

        arrayList.Sort();
        ArrayList MinFirstThree = arrayList.GetRange(0, 3);
        Console.WriteLine("******* Minumum 3 Numbers ******");
        foreach (int i in MinFirstThree)
        {
            Console.WriteLine(i);
            MinAvarage += i;
        }
        MinAvarage = MinAvarage / MinFirstThree.Count;

        Console.WriteLine("===== Avarage : " + MinAvarage + " =====");
        arrayList.Reverse();
        ArrayList MaxFirstThree = arrayList.GetRange(0, 3);
        Console.WriteLine("******* Maximum 3 Numbers ******");
        foreach (int i in MaxFirstThree)
        {
            Console.WriteLine(i);
            MaxAvarage += i;
        }
        MaxAvarage = MaxAvarage / MaxFirstThree.Count;

        Console.WriteLine("===== Avarage : " + MaxAvarage + " =====");
        Console.WriteLine("=========== Sum of avarages : " + (MinAvarage + MaxAvarage) + " ===========");
        Console.ReadLine();

    }
}