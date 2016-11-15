using System;
using System.Collections.Generic;
namespace Kata_Roman_Numerals
{
    public class RomanNumeralConverter
    {
        private static Dictionary<char, int> _romanNumberLkup;

        static RomanNumeralConverter()
        {
            _romanNumberLkup = new Dictionary<char, int>();
            _romanNumberLkup.Add('I', 1);
            _romanNumberLkup.Add('V', 5);
            _romanNumberLkup.Add('X', 10);
            _romanNumberLkup.Add('L', 50);
            _romanNumberLkup.Add('C', 100);
            _romanNumberLkup.Add('D', 500);
            _romanNumberLkup.Add('M', 1000);
        }

        public int ConvertRomanNumeralToDecimal(string romanNumber)
        {
            int number = 0;
            var romanNumberInput = romanNumber.ToUpper();

            for (int i = 0; i < romanNumberInput.Length; i++)
            {
                if (i + 1 < romanNumberInput.Length &&
                    _romanNumberLkup[romanNumberInput[i]] < _romanNumberLkup[romanNumberInput[i + 1]])
                {
                    number -= _romanNumberLkup[romanNumberInput[i]];
                }
                else
                {
                    number += _romanNumberLkup[romanNumberInput[i]];
                }

            }

            return number;
        }

        public bool CheckIfTheRomanNumeralIsValid(string romanNumber)
        {
            return true;
        }
    }
}