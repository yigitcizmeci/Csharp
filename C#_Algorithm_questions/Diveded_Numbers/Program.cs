internal class Program
{
    /*
     Create a console application that prompts the user to enter two positive numbers (n, m).
     Then, ask the user to input n positive numbers.
     Print the numbers from the user's input that are either equal to m or divisible by m on the console.
     */
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 2 integer (n,m) : ");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter " + (i + 1) + ". number : ");
            int input = int.Parse(Console.ReadLine());
            arr[i] = input;
        }
        Console.WriteLine("====== Can divided by " + m + " =======");

        foreach (int numbers in arr)
        {
            if (numbers % m == 0 || numbers == m)
            {
                Console.WriteLine(numbers);
            }
        }


    }
}