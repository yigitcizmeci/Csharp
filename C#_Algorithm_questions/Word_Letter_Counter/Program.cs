internal class Program
{
    /*
     Ask a console computer user to write a sentence. 
    Print the total words and letters in the sentence to the console.
     */
    private static void Main(string[] args)
    {
        Console.WriteLine("Write a sentence please : ");
        String sentence = Console.ReadLine();

        int letters = sentence.Length;
        string[] space = sentence.Split(' ');
        int letters2 = letters - (space.Length - 1);
        Console.WriteLine("Total Words " + space.Length + " Total Letters: " + letters2);
    }
}