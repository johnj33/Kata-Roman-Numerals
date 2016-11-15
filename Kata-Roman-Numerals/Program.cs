﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a roman numeral to convert to decimal");
            var romanNumberInput = Console.ReadLine();

            Console.WriteLine("Decimal Equivalent is");
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            var decimalEquivalentOutput = romanNumeralConverter.ConvertRomanNumeralToDecimal(romanNumberInput);
            Console.WriteLine(decimalEquivalentOutput);
            Console.ReadKey();
        }
    }
}
