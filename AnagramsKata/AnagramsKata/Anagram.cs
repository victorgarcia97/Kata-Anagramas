namespace AnagramsKata.Tests;

public class Anagram
{
    public static List<string> Of(string s)
    {
        if(s.Length <= 1 ) return new List<string> { s };

        var anagrams = new List<string>();

        for (var i = 0; i < s.Length; i++)
        {
            var firstLetter = s.Substring(i, 1);
            var anagramsOfRest = Of(GetStringWithoutCharAt(s, i));
            foreach (var anagram in anagramsOfRest)
            {
                anagrams.Add(firstLetter + anagram);
            }
        }

        return anagrams;
    }

    private static string GetStringWithoutCharAt(string s, int index)
    {
        var beforeIndexString = s.Substring(0, index);
        var afterIndexString = s.Substring(index + 1, s.Length - (index + 1));

        return beforeIndexString + afterIndexString;
    }
}