using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] sentence = { "tumgeneral", "tuggeneral", "korgeneral", "orgeneral" };
            //string word = "Genelkurmay baskanligi";
            //Elements(ref sentence, word);

            Console.WriteLine("Enter any sentence: ");
            string sentence = Console.ReadLine();
            //Console.WriteLine(CheckedTF(sentence));
            //Checked(sentence);
            //FirstWord(sentence);
            Console.WriteLine(whiteSpaceX(sentence));

        }

        static string Checked(string sentence)
        {
            string[] words = sentence.Split();

            if (words.Length == 2)
            {
                Console.WriteLine("This sentence have two senetence");
                foreach (string word in words)
                {
                    if (char.IsUpper(word[0]))
                    {
                        Console.WriteLine("Words first letter is upper");
                    }
                    else
                    {
                        Console.WriteLine("Words first letter isn't upper.First letter must be upper");
                    }
                }
            }

            return sentence;
        }

        static string whiteSpaceX(string sentenc)
        {
            int count = 0;
            for(int i = 0;i < sentenc.Length; i++)
            {
                if(sentenc[i] == ' ')
                {
                    count++;
                    if(count > 1)
                    {
                        int firstIndex = sentenc.IndexOf(' ');
                        int lastIndex = sentenc.LastIndexOf(' ');
                        int difference = lastIndex - firstIndex;
                        sentenc = sentenc.Remove(firstIndex, difference);
                    }
                }
            }
            return sentenc;
        }
        static bool CheckedTF(string word)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            foreach (char letters in word)
            {
                if (char.IsDigit(letters))
                {
                    hasDigit = true;
                    continue;
                }
                if (char.IsUpper(letters))
                {
                    hasUpper = true;
                    continue;
                }
                if (char.IsLower(letters))
                {
                    hasLower = true;
                }
            }
            bool result = hasDigit && hasUpper && hasLower;
            return result;
        }

        static void Elements(ref string[] array, string word)
        {
            string[] arr = new string[array.Length + 1];
            arr[array.Length] = word;

            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            array = arr;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static string FirstWord(string word)
        {
            string[] words = word.Split();
            Console.WriteLine(words[0]);
            return word;
        }
    }
}
