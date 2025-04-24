using System.Security.Cryptography.X509Certificates;

namespace Class_Exercise__Complete_
{
    internal class Program
    {
        //Class Exercise 1
        public static string text_reversal(string user_input)
        {
            string reversed_text = String.Empty;

            char[] unreversed_chars = user_input.ToCharArray();

            //
            Console.WriteLine("Unreversed Text Array:");

            foreach (var character in unreversed_chars)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine("\nReversed Text Array: ");

            int count = unreversed_chars.Length - 1;

            while (count > -1)
            {
                Console.WriteLine(unreversed_chars[count]);
                count--;
            }
            //

            for (int i = unreversed_chars.Length - 1; i >= 0; i--)
            {
                reversed_text += unreversed_chars[i];
            }
            return reversed_text;
        }

        //Class Exercise 2
        public static bool palindrome_eval(string user_input)
        {
            string reversed_string = string.Empty;
            for (int i = user_input.Length - 1; i >= 0; i--)
            {
                reversed_string += user_input[i];
            }
            return user_input == reversed_string;
        }

        //Class Exercise 3
        public static bool odd_status(int[] user_input)
        {
            for (int i = 0; i < user_input.Length; i++)
            {
                if ((user_input[i] % 2) == 1)
                {
                    return true;
                }
            }
            return false;
        }

        //Class Exercise 4
        public static string vowel_remover(string user_input)
        {
            char[] user_string = user_input.ToCharArray();
            char[] tempArray = new char[user_string.Length];
            int tempIndex = 0;
            char[] vowels_upper = { 'A', 'E', 'I', 'O', 'U' };
            char[] vowels_lower = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < user_string.Length; i++)
            {
                bool isVowel = false;

                for (int j = 0; j < vowels_lower.Length; j++)
                {
                    if (user_string[i] == vowels_lower[j] || user_string[i] == vowels_upper[j])
                    {
                        isVowel = true;
                        break;
                    }
                }
              
                if (!isVowel)
                {
                    tempArray[tempIndex] = user_string[i];
                    tempIndex++;
                }
            }

            char[] mod_user_char = new char[tempIndex];
            Array.Copy(tempArray, mod_user_char, tempIndex);

            return new string(mod_user_char);
        }

        //Class Exercise 5
        public static void int_count(int[] user_input) //Use a class, as opposed to a void method to return more than 1 value
        {
            int pos_int_count = 0;
            int neg_int_count = 0;

            for (int i = 0; i < user_input.Length; i++)
            {
                if ((user_input[i] > 0) && (user_input[i] != 0))
                {
                    pos_int_count++;
                }
                if ((user_input[i] < 0) && (user_input[i] != 0))
                {
                    neg_int_count++;
                }
            }
            Console.WriteLine($"Total Positive: {pos_int_count}\nTotal Negative: {neg_int_count}");
        }
        
        //Class Exercise 6
        public static double five_num_avg(int[] user_input)
        {
            int sum = 0;
            for (int i = 0; i < user_input.Length; i++)
            {
                sum += user_input[i];
            }
            double average = sum / user_input.Length;
            return average;
        }

        //Class Exercise 7
        public static string longest_word(string user_input)
        {
            if (string.IsNullOrWhiteSpace(user_input))
            {
                return "Input is empty";
            }

            string[] words = user_input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string longest_Word = string.Empty;

            foreach (string word in words)
            {
                if (word.Length > longest_Word.Length)
                {
                    longest_Word = word;
                }
            }
            return longest_Word;
        }

        static void Main(string[] args)
        {
            //Menu (Class Exercise Selection)
            Console.WriteLine("Which exercise would you like to run");
            Console.WriteLine("Enter The NUMBER from the options below");
            Console.WriteLine("1: Text Reversal\n" +
                              "2: Palindrome Evaluation\n" +
                              "3: Determine whether an odd number exists in an array\n" +
                              "4: Remove Vowels from a given text\n" +
                              "5: Display the number of positive and negative integers in an array\n" +
                              "6: Calculate the average of 5 numbers\n" +
                              "7: Determine the longest word in a sentence");

            int menu_options = 0;

            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                menu_options = Int32.Parse(input);
            }
            else
            {
                Console.WriteLine("Invalid input. Exiting program.");
                return;
            }

            switch (menu_options)
            {
                case 1:
                    Console.WriteLine("Please enter a string to reverse: ");
                    string? user_input_1 = Console.ReadLine();
                    if (user_input_1 != null)
                    {
                        string reversed_text = text_reversal(user_input_1);
                        Console.WriteLine($"Reversed Text: {reversed_text}");
                    }
                    else
                    {
                        Console.WriteLine("No input provided.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Please enter a string to evaluate its' palindrome status: ");
                    string? user_input_2 = Console.ReadLine();
                    if (user_input_2 != null)
                    {
                        bool palindrome_status = palindrome_eval(user_input_2);
                        Console.WriteLine($"This is a palindrome?: {palindrome_status}");
                    }
                    else
                    {
                        Console.WriteLine("No input provided.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Please enter the length of the array to evaluate whether it contains an odd number: ");
                    int arr_len_1 = 0;
                    int arr_user_val_1 = 0;
                    arr_len_1 = Int32.Parse(Console.ReadLine());
                    int [] user_input_array_3 = new int[arr_len_1];

                    for (int i = 0; i < user_input_array_3.Length; i++)
                    {
                        Console.WriteLine("Please enter an integer value to populate the array: ");
                        arr_user_val_1 = Int32.Parse(Console.ReadLine());
                        user_input_array_3[i] = arr_user_val_1;
                    }

                    if (user_input_array_3 != null)
                    {
                        bool odd_eval = odd_status(user_input_array_3);
                        Console.WriteLine($"There is an ODD number present?: {odd_eval}");
                    }
                    else
                    {
                        Console.WriteLine("No input provided.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Please enter a string which you would like the vowels to be removed from:");
                    string? user_input_4 = Console.ReadLine();
                    if (user_input_4 != null)
                    {
                        string vowel_removed_txt = vowel_remover(user_input_4);
                        Console.WriteLine($"{user_input_4} --> {vowel_removed_txt}");
                    }
                    else
                    {
                        Console.WriteLine("No input provided.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Please enter the length of the array");
                    int arr_len_2 = 0;
                    int arr_user_val_2 = 0;
                    arr_len_2 = Int32.Parse(Console.ReadLine());
                    int[] user_input_array_5 = new int[arr_len_2];

                    for (int i = 0; i < user_input_array_5.Length; i++)
                    {
                        Console.WriteLine("Please enter an integer value to populate the array: ");
                        arr_user_val_2 = Int32.Parse(Console.ReadLine());
                        user_input_array_5[i] = arr_user_val_2;
                    }

                    if (user_input_array_5 != null)
                    {
                        int_count(user_input_array_5);
                    }
                    else
                    {
                        Console.WriteLine("No input provided.");
                    }
                    break;
                case 6:
                    int[] user_input_array_6 = new int[5];

                    for (int i = 0; i < user_input_array_6.Length; i++)
                    {
                        Console.WriteLine("Please enter a value to populate the array: ");
                        arr_user_val_2 = int.Parse(Console.ReadLine()); //Convert.ToDouble()
                        user_input_array_6[i] = arr_user_val_2;
                    }

                    if (user_input_array_6 != null)
                    {
                        double average = five_num_avg(user_input_array_6);
                        Console.WriteLine($"The average of the five numbers are: {average}");
                    }
                    else
                    {
                        Console.WriteLine("No input provided.");
                    }
                    break;
                case 7:
                    Console.WriteLine("Please enter a string which you would like to find the longest word in:");
                    string? user_input_7 = Console.ReadLine();
                    if (user_input_7 != null)
                    {
                        string longest_Word = longest_word(user_input_7);
                        Console.WriteLine($"\"{user_input_7}\" --> The longest word is \"{longest_Word}\"");
                    }
                    else
                    {
                        Console.WriteLine("No input provided.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
}
