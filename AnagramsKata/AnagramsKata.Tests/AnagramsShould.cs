using FluentAssertions;

namespace AnagramsKata.Tests
{
    public class AnagramsShould
    {
        [Test]
        public void ReturnEmptyStringWhenInputIsEmpty()
        {
            var result = Anagram.Of("");

            var expectedAnagrams = new List<string>() { "" };
            result.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Test]
        public void ReturnAnagramOfJustOneLetter()
        {
            var result = Anagram.Of("A");

            var expectedAnagrams = new List<string>() { "A" };
            result.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Test]
        public void ReturnAnagramOfTwoLetters()
        {
            var result = Anagram.Of("AB");

            var expectedAnagrams = new List<string>() { "AB", "BA" };
            result.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Test]
        public void ReturnAnagramOfThreeLetters()
        {
            var result = Anagram.Of("ABC");

            var expectedAnagrams = new List<string>() { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
            result.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Test]
        public void ReturnAnagramOfFourLetters()
        {
            var result = Anagram.Of("ABCD");

            var expectedAnagrams = new List<string>() { 
                "ABCD", "ABDC", "ACDB", "ACBD", "ADBC", "ADCB",
                "BCDA", "BCAD", "BDAC", "BDCA", "BACD", "BADC",
                "CDAB", "CDBA", "CABD", "CADB", "CBAD", "CBDA",
                "DBAC", "DBCA", "DCBA", "DCAB", "DABC", "DACB"
            };
            result.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Test]
        public void HaveTheSameNumberOfElementsAsExpectedWithFiveLetters()
        {
            var result = Anagram.Of("ABCDE");

            result.Count.Should().Be(120);

        }
    }
}

  
  
  
  
  
  