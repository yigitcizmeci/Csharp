internal class Program
{
    //Write a program that stores the vowel letters in an array from the sentence entered from the keyboard and sorts the elements of the array.
    private static void Main(string[] args)
    {
        while (true)
        {
            List<char> Vowel = new List<char>(); 

            Console.WriteLine("Write your sentence: ");
            string sentence = Console.ReadLine().ToLower();

            if (!string.IsNullOrWhiteSpace(sentence)) // Checking the sentence if there is only space or something else
            {
                if (!int.TryParse(sentence, out _)) // Prevent entering numbers
                {
                    foreach (char letter in sentence) // Searching vowel letters in the sentence and adding them to the vowel list
                    {
                        if (IsVowel(letter) && !Vowel.Contains(letter))
                        {
                            Vowel.Add(letter);
                        }
                    }

                    Vowel.Sort();

                    Console.WriteLine("********* Vowel letters in the sentence *********");
                    foreach (char letter in Vowel)
                    {
                        Console.WriteLine($"{letter}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }
            else
            {
                Console.WriteLine("Please write sentence only");
            }
        }

        static bool IsVowel(char letter)
        {
            return "aeıioöuü".Contains(letter);
        }


    }
}