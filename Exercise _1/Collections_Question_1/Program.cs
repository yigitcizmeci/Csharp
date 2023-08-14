using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
          Enter 20 positive numbers from the keyboard and separate them into two different lists: prime and non-prime. (Use the ArrayList class.)

        Prevent negative and non-numeric inputs.
        Display the elements of each list in descending order.
        Display the count and average of elements in both lists on the screen.
         */

        ArrayList list1 = new ArrayList();
        ArrayList list2 = new ArrayList();
        double avarage = 0;
        double avarage2 = 0;

        Console.WriteLine("Please enter 20 positive number");
        for (int i = 0; i < 5; i++)
        {
            Console.Write((i + 1) + ". number : ");
            while (true)
            {
                string input = Console.ReadLine();


                if (int.TryParse(input, out int number) && number > 0)
                {
                    bool IsPrime = true;

                    for (int k = 2; k < number - 1; k++)
                    {
                        if (number % k == 0)
                        {
                            list2.Add(number);
                            avarage2 += number;
                            IsPrime = false;
                            break;
                        }

                    }
                    if (IsPrime)
                    {
                        list1.Add(number);
                        avarage += number;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a positive number.");
                }
            }
        }
        avarage2 = avarage2 / list2.Count;
        avarage = avarage / list1.Count;

        list1.Sort();
        list2.Sort();
        list1.Reverse();
        list2.Reverse();

        Console.WriteLine("***** Prime Numbers *****");
        foreach (int item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("================== Total : " + list1.Count + " numbers " + "=====" + " Avarage : " + avarage + " ==================");
        Console.WriteLine("***** NonPrime Numbers *****");
        foreach (int item in list2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("================== Total : " + list2.Count + " numbers " + "=====" + " Avarage : " + avarage2 + " ==================");

        Console.ReadLine();
    }




}