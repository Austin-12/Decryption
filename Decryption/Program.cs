using System;
class Program
{
    //method to decrypt the encrypted code by reversing the encryption scheme
    static void Solve(int code)
    {
        //grab the individual digits in the integer
        int firstDigit = (code / 1000) % 10;
        int secondDigit = (code / 100) % 10;
        int thirdDigit = (code / 10) % 10;
        int fourthDigit = code % 10;

        //subtract 7 and add 10 to each digit
        firstDigit = (firstDigit - 7 + 10) % 10;
        secondDigit = (secondDigit - 7 + 10) % 10;
        thirdDigit = (thirdDigit - 7 + 10) % 10;
        fourthDigit = (fourthDigit - 7 + 10) % 10;

        int decryptedCode = (thirdDigit * 1000) + (fourthDigit * 100) + (firstDigit * 10) + secondDigit;

        Console.WriteLine($"this is the decrypted code: {decryptedCode:D4}");
    }
    static void Main(string[] args)
    {
        int counter = 0;
        while (counter == 0)
        {

            Console.Write("Enter 4 digit encrypted code: ");
            String input = Console.ReadLine();
            int code;
            bool success = int.TryParse(input, out code); //returns true if parsed false if not stores int in code

            if (input.Length == 4 && success)
            {
                counter++;
                Solve(code);
            }
            else
            {
                Console.WriteLine("Invalid encrypted code");
            }
        }
    }
}