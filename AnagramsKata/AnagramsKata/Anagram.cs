namespace AnagramsKata.Tests;

public class Anagram
{
    public static List<string> Of(string s)
    {
        if(s.Length <= 1 ) return new List<string> { s };

        if(s.Length == 2 ) return new List<string> { s, s.Substring(1,1) + s.Substring(0,1) };

        var anagrams = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            anagrams.Add(s.Substring(i, 1) + Of(GetStringWithoutCharAt(s, i))[0]);
            anagrams.Add(s.Substring(i, 1) + Of(GetStringWithoutCharAt(s, i))[1]);
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