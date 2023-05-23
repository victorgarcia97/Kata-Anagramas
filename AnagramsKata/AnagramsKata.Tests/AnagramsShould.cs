using FluentAssertions;

namespace AnagramsKata.Tests
{
    public class AnagramsShould
    {
        [Test]
        public void ReturnEmptyStringWhenInputIsEmpty()
        {
            var result = Anagram.GetAnagrams("");

            var expectedAnagrams = new List<string>() { "" };
            result.Should().BeEquivalentTo(expectedAnagrams);
        }

        [Test]
        public void ReturnAnagramOfJustOneWord()
        {
            var result = Anagram.GetAnagrams("A");

            var expectedAnagrams = new List<string>() { "A" };
            result.Should().BeEquivalentTo(expectedAnagrams);
        }
    }
}