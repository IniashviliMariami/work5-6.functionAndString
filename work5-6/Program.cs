using System.ComponentModel.Design;

namespace work5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //davaleba 1

            Console.WriteLine("Enter text");
            string newString = Console.ReadLine();
            int lengthNumber = MyChar(newString);
            Console.WriteLine(lengthNumber);

            //davaleba2
            int[] array = [1, 1, 1, 1, 1, 1, 1, 1, 1];
            int sum = ArraySumNumber(array);
            Console.WriteLine(sum);

            //davaleba3
            int[] arrayOdd = [1, 2, 1, 2, 1, 2, 2, 1, 1];
            int odd = ArrayoddNumber(arrayOdd);
            Console.WriteLine(odd);

            //davaleba 4

            int firstNumber = 80;
            int secondNumber = 30;
            Console.WriteLine(NumbersSum(firstNumber, secondNumber));

            //davaleba 5

            int[] arrayNumbers = [1, 10, 4, 6, 2, 9];
            Console.WriteLine(MaxNumber(arrayNumbers));

            //davaleba 6


            Console.Write("enter number (1-10): ");
            int[] cosArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int myNum = int.Parse(Console.ReadLine());

            Console.WriteLine(MyNumber(cosArray, myNum));

            //davaleba 7

            int[] arraySort = [10, 2, 5, 7, 8, 3, 4, 6, 9, 1];

            int[] newArraySort = SortArray(arraySort);
            for (int i = 0; i < arraySort.Length; i++)
            {
                Console.WriteLine(newArraySort[i]);
            }

            //davaleba 8

            string text = "Hello world";
            char myCar = 'H';

            bool result1 = Contains(text, myCar);

            Console.WriteLine(result1);

            //davaleba9

            string text3 = "mmmm";
            char newChar = 'w';

            bool result2 = All(text3, newChar);
            Console.WriteLine(result2);


            // work 6 /1

            Console.WriteLine("Please enter your text:");
            string input = Console.ReadLine();

            string output = Uppercase(input);
            
            Console.WriteLine(output);


        }
        static int MyChar(string newString)
        {
                int number = newString.Length;
                return number;
        }
        static int ArraySumNumber(int[] array)
        {
            int sum=0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }return sum;
        }

        static int ArrayoddNumber(int[] arrayOdd)
        {
            int odd = 0;
            for (int i = 0; i < arrayOdd.Length; i++)
            {
                if (arrayOdd[i] %2 != 0)
                {
                    odd += arrayOdd[i];
                }
            }
            return odd;
        }

        static int NumbersSum(int x, int y)
        {
            return x + y;
        }

        static int MaxNumber(int[] array)
        {
            int max = 0;
            for(int i = 0;i < array.Length;i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }return max;
        }

        static int MyNumber(int[] array, int number)
        {
            int enterNumber = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    enterNumber = number;
                }
            }
            return enterNumber;
        }

        static int[] SortArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }

        static bool Contains(string text, char myChar)
        {
            return text.IndexOf(myChar) >= 0;
        }

        static  bool All(string text, char newChar)
        {
            for (int i = 0;i < text.Length;i++)
            {
                if (!text[i].Equals(newChar))
                {
                    return false;
                }
            }return true;
        }


        static string Uppercase(string text)
        {
            char[] specialChar = { '.', '!', '?' };
            string[] sentences = text.Split(specialChar, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
                if (sentences[i].Length > 0)
                {
                    sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
                }
            }
            return string.Join(". ", sentences).Trim() + (text.EndsWith(".") ? "." : "");
        }


    }
}
