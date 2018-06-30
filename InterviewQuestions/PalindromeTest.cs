using System;
using Xunit;

namespace IntervieweQuestions
{
    public class PalindromeTest
    {
        [Fact]
        public void Is_Word_A_Palidrome()
        {
            Assert.True(IsPalindrome("Deleveled", "deleveled"));

            Assert.False(IsPalindrome("dads", "sdad"));
        }

        public static bool IsPalindrome(string word, string expected)
        {
            var output = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                output = output + word[i];
            }

            if (output.ToLower() == word.ToLower())
                return true;

            return false;
        }
    }
}