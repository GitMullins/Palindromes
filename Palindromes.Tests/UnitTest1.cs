using System;
using System.Text.RegularExpressions;
using Xunit;

namespace Palindromes.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void PhraseIsNotPalindrome()
        {
            //Arrange
            var input = "Stars";
            string phrase = input.Replace(" ", string.Empty);
            var palindrome = new Palindrome();

            //Act
            var result = palindrome.ReversePhrase(phrase);

            //Assert
            Assert.Equal(phrase, result.Characters);
        }

        [Fact]
        public void PhraseIsPalindrome()
        {
            //Arrange
            var input = "was it a cat i saw?";
            string withoutSpace = input.Replace(" ", string.Empty);
            var phrase = Regex.Replace(withoutSpace, @"[^0-9a-zA-Z]+", "");
            var palindrome = new Palindrome();

            //Act
            var result = palindrome.ReversePhrase(phrase);

            //Assert
            Assert.Equal(phrase, result.Characters);
        }

        [Fact]
        public void PhraseIsPalindrome2()
        {
            //Arrange
            var input = "Some men interpret nine memos";
            string phrase = input.Replace(" ", string.Empty).ToLower();
            var palindrome = new Palindrome();

            //Act
            var result = palindrome.ReversePhrase(phrase);

            //Assert
            Assert.Equal(phrase, result.Characters);
        }

    }
}
