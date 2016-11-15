using Kata_Roman_Numerals;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RomanNumeralConverterTests
    {
        private RomanNumeralConverter _romanNumeralConverter;

        [OneTimeSetUp]
        public void GivenARomanNumeralConverter_WhenARomanNumeralIsConverted()
        {
            _romanNumeralConverter = new RomanNumeralConverter();
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]         
        public void ThenTheRomanNumeralIsConvertedToDecimalCorrectly(string romanNumeral, int expectedCalculatedValue)
        {
            var actualCalculatedValue = _romanNumeralConverter.ConvertRomanNumeralToDecimal(romanNumeral);

            Assert.That(actualCalculatedValue, Is.EqualTo(expectedCalculatedValue));
        }

        [TestCase("VV",false)]        
        public void WhenTheRomanNumeralEnteredIsInvalid(string romanNumeral, bool isValid)
        {
            var actualValue = _romanNumeralConverter.CheckIfTheRomanNumeralIsValid(romanNumeral);
            var expectedValue = isValid;

            Assert.That(actualValue, Is.EqualTo(expectedValue));
        }
    }
}
