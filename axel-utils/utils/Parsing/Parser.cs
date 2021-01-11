using System;
using System.Globalization;

namespace axelutils.Parsing
{
    public class Parser
    {
        /// <summary>
        /// Converts a string to double, respects diffrent culutre decimal deliminators
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double StringToDouble(in string input)
        {
            double number;
            CultureInfo culture;
            try
            {
                culture = CultureInfo.CreateSpecificCulture("sv-SE");
                number = double.Parse(input, culture);
                return number;
            }
            catch (FormatException)
            {
                culture = CultureInfo.CreateSpecificCulture("en-US");
                try
                {
                    number = double.Parse(input, culture);

                    return number;
                }
                catch (FormatException)
                {
                    throw new ArgumentException($"{culture.Name}: Unable to parse {input}");
                }
            }
        }

        /// <summary>
        /// Converts a string to decimal, respects diffrent culutre decimal deliminators
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal StringToDecimal(in string input)
        {
            decimal number;
            CultureInfo culture;
            try
            {
                culture = CultureInfo.CreateSpecificCulture("sv-SE");
                number = decimal.Parse(input, culture);
                return number;
            }
            catch (FormatException)
            {
                culture = CultureInfo.CreateSpecificCulture("en-US");
                try
                {
                    number = decimal.Parse(input, culture);
                    return number;
                }
                catch (FormatException)
                {
                    throw new ArgumentException($"{culture.Name}: Unable to parse {input}");
                }
            }
        }
    }
}