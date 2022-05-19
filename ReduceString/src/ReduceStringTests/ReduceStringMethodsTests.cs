using ReduceStringExercise;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ReduceStringTests
{
    public class ReduceStringMethodsTests
    {
        private static readonly List<string> validStrings = new() { "abc", "aabc", "cabbac", "aa", "bb", "cc", "acbabcbbcbcbabacbcbbbbbbaaabadc", "bbcababccaababcacbbabca" };
        private static readonly List<string> invalidStrings = new() { "ab@c", "bc#a", "deq", "", "123", "lo&" };


        [Fact]
        public void Should_Return_False_Given_Invalid_String()
        {
            bool isValid = Program.StringIsValid(invalidStrings.FirstOrDefault());

            Assert.False(isValid);
        }

        [Fact]
        public void Should_Return_True_Given_Valid_String()
        {
            bool isValid = Program.StringIsValid(validStrings.FirstOrDefault());

            Assert.True(isValid);
        }

        [Fact]
        public void Should_Not_Return_Valid_Strings()
        {
            var validStrings = Program.GetValidStrings(invalidStrings);

            Assert.Empty(validStrings);
        }

        [Fact]
        public void Should_Return_All_Valid_Strings()
        {
            var strings = Program.GetValidStrings(validStrings);

            Assert.Equal(validStrings.Count, strings.Count);
            Assert.Equal(validStrings, strings);
        }

        [Fact]
        public void Should_Return_The_Different_Char()
        {
            char differentChar = Program.GetDifferentChar('a', 'b');
            Assert.Equal('c', differentChar);

            differentChar = Program.GetDifferentChar('a', 'c');
            Assert.Equal('b', differentChar);

            differentChar = Program.GetDifferentChar('b', 'c');
            Assert.Equal('a', differentChar);
        }

        [Fact]
        public void Should_Return_True_When_Has_Chars_To_Reduce()
        {
            var charList = new List<char>() { 'a', 'b' };

            bool canReduce = Program.CanReduce(charList);

            Assert.True(canReduce);
        }

        [Fact]
        public void Should_Return_False_When_Has_No_Chars_To_Reduce()
        {
            var charList = new List<char>() { 'a', 'a' };

            bool canReduce = Program.CanReduce(charList);

            Assert.False(canReduce);

            charList.Clear();

            charList.AddRange(new[] { 'b' });

            canReduce = Program.CanReduce(charList);

            Assert.False(canReduce);
        }

        [Fact]
        public void Should_Match_Results()
        {
            string[] expectedResults = new[] { "cc", "a", "cc", "aa", "bb", "cc", "a", "b" };
            int index = 0;

            foreach (var expectedString in expectedResults)
            {
                Assert.Equal(expectedString, Program.ReduceMethod(validStrings[index]));
                index++;
            }
        }
    }
}