using Xunit;
using axelutils.Parsing;
using System;
using System.Collections.Generic;
using System.Text;

namespace axelutils.Parsing.Tests
{
    public class ParserTests
    {
        [Theory]
        [InlineData("1,8", 1.8)]
        [InlineData("186", 186.0)]
        [InlineData("0,4", 0.4)]
        [InlineData("0.4", 0.4)]
        [InlineData("168541.41681", 168541.41681)]
        public void StringToDoubleTest(string input, double expected)
        {
            double output = Parser.StringToDouble(input);
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData("1,8", 1.8)]
        [InlineData("186", 186.0)]
        [InlineData("0,4", 0.4)]
        [InlineData("0.4", 0.4)]
        [InlineData("168541.41681", 168541.41681)]
        public void StringToDecimalTest(string input, decimal expected)
        {
            decimal output = Parser.StringToDecimal(input);
            Assert.Equal(expected, output);
        }
    }
}