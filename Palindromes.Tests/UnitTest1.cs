using System;
using Xunit;

namespace Palindromes.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PhraseIsNotPalindrome()
        {
            //Arrange
            var input = "was it a cat i saw";
            string phrase = input.Replace(" ", string.Empty);
            var palindrome = new Palindrome();

            //Act
            var result = palindrome.ReversePhrase(phrase);

            //Assert
            Assert.Equal(phrase, result.Characters);
        }
    }
}
