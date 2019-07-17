using System;
using System.Text;

namespace AHCB_CapitalizeEveryOtherLetter
{
    class Program
    {
        public static string AcceptUserInput()
        {
            Console.WriteLine("Enter any text.");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string CapitalizeEveryOtherLetter(string userInput)
        {
            StringBuilder capitalizeEveryOtherLetter = new StringBuilder();

            for (int i = 0; i < userInput.Length; i++)
            {
                if(!(Char.IsLetter(userInput[i])))
                {
                    capitalizeEveryOtherLetter.Append(userInput[i].ToString());
                    continue;
                }

                if(i % 2 == 0)
                {
                    string lowercaseLetter = userInput[i].ToString().ToLower();
                    capitalizeEveryOtherLetter.Append(lowercaseLetter);
                }
                else
                {
                    string capitalizeLetter = userInput[i].ToString().ToUpper();
                    capitalizeEveryOtherLetter.Append(capitalizeLetter);
                }
            }

            return capitalizeEveryOtherLetter.ToString();
        }

        static void Main(string[] args)
        {
            string userInput = AcceptUserInput();
            Console.WriteLine($"This is what you entered: {userInput}");

            string spongebobMeme = CapitalizeEveryOtherLetter(userInput);
            Console.WriteLine($"This is what you entered, but sarcastic: {spongebobMeme}");
        }
    }
}