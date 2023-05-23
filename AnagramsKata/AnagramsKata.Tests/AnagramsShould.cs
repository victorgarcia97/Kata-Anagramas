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
    }
}