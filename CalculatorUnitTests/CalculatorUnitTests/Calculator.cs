using System;
using System.Globalization;

namespace CalculatorUnitTests
{
    public static class Calculator
    {
        public static object Add(string numbers)
        {
            return string.IsNullOrEmpty(numbers) ? 0 : GetSum(numbers);
        }

        private static int GetSum(string numbers)
        {
            char? charDelimiter = null;

            if (numbers.StartsWith("//") && numbers.Contains("\n"))
            {
                charDelimiter = numbers[2];
                numbers = numbers.Split('\n')[1];
            }

            if (numbers.Contains(",") || numbers.Contains("\n"))
            {
                string[] array;

                if (charDelimiter != null)
                    array = numbers.Split((char)charDelimiter);
                else
                    array = numbers.Split(new Char[] { ',', '\n' });

                int sommeDesValeurs = 0;

                for(int i = 0; i < array.Length; i++)
                {
                    if (int.Parse(array[i]) < 0)
                        throw new ArgumentException();
                    else if (int.Parse(array[i]) < 1001)
                        sommeDesValeurs += int.Parse(array[i]);

                }

                return sommeDesValeurs;
            }
            
            return int.Parse(numbers);
        }
    }
}