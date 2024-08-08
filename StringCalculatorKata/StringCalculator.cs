﻿namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            {

                if (string.IsNullOrEmpty(numbers))
                {
                    return 0;
                }

                string[] separators = { ",", "\n" };
                if (numbers.StartsWith("//"))
                {
                    var delimiterEndIndex = numbers.IndexOf('\n');
                    var customDelimiter = numbers[2..delimiterEndIndex];
                    separators = new[] { customDelimiter };
                    numbers = numbers[(delimiterEndIndex + 1)..];
                }

                var nums = numbers.Split(separators, StringSplitOptions.None);
                return nums.Select(int.Parse).Sum();


            }
        }
    }

}
