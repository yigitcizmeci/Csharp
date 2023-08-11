internal class Program
{
    /*
         In a console application, ask the user to enter a positive number (n).
         Then, ask the user to enter n positive numbers. 
         Print out the even numbers among the numbers entered by the user to the console
        */
    static void Main(string[] args)
    {
        Console.Write("Please enter your lenght of intergers : ");
        int n = int.Parse(Console.ReadLine());

        int[] Arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter your " + (i + 1) + ". number");
            int input = int.Parse(Console.ReadLine());
            Arr[i] = input;
        }
        Console.Write("Even numbers : ");

        foreach (int numbers in Arr)
        {
            if (numbers % 2 == 0)
            {
                Console.WriteLine(numbers);
            }
        }

    }
}