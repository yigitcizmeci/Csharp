internal class Program
{
    /*
    Create a console application that prompts the user to enter a positive number (n).
    Then, ask the user to input n words.
    Finally, print the words entered by the user in reverse order to the console.
     */
    private static void Main(string[] args)
    {
        int n = 0;
        Console.Write("Please enter a positive number for array length: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Please enter a valid positive number: ");
        }
        String[] strings = new String[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine((i + 1) + ". Word : ");
            string words = Console.ReadLine();
            strings[i] = words;
        }

        Console.WriteLine("**** Listed words **** ");
        foreach (String words in strings)
        {
            Console.WriteLine(words);
        }
        Console.WriteLine("**** Reversed list ****");
        Array.Reverse(strings);
        foreach (String words in strings)
        {
            Console.WriteLine(words);
        }


    }
}