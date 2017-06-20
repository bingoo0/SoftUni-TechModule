namespace String_Encryption
{
    using System;
    class StringEncryption
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var character = char.Parse(Console.ReadLine());
                var encrypt = Encrypted(character);

                result += encrypt;
            }

            Console.WriteLine(result);
        }

        public static string Encrypted(char character)
        {
            var asciiCode = (int)character;
            var lastDigit = asciiCode % 10;
            var firstDigit = FindFirstDigit(asciiCode);
            var start = (char)(asciiCode + lastDigit);
            var end = (char)(asciiCode - firstDigit);

            var result = $"{start}{firstDigit}{lastDigit}{end}";

            return result;
        }

        public static int FindFirstDigit(int asciiCode)
        {
            var firstDigit = asciiCode;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            return firstDigit;
        }

        //public static void Encrypt(char character, int number)
        //{
        //    string result = string.Empty;
        //    for (int i = 0; i < number; i++)
        //    {
        //        character = char.Parse(Console.ReadLine());
        //        int asciiCode = character;
        //        int getLastDigit = character % 10;
        //        int getFirstDigit = character / 100 % 10;

        //        var start = (asciiCode + getFirstDigit);
        //        var end = (asciiCode + getLastDigit);

        //        char convertStartToChar = (char)start;
        //        char convertedEndToChar = (char)end;
        //        char convertedLastDigitToChar = (char)getLastDigit;
        //        char convertedFirstDigitToChar = (char)getFirstDigit;

        //        Console.WriteLine($"{convertStartToChar}{convertedFirstDigitToChar}" +
        //            $"{convertedLastDigitToChar}{convertedEndToChar}");

        //    }
    }
    }
