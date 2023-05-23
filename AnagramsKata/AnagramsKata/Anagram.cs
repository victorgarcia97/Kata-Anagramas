namespace AnagramsKata.Tests;

public class Anagram
{
    public static List<string> Of(string s)
    {
        if (s == "") return new List<string> { "" };

        if(s.Length == 1 ) return new List<string> { s };

        return new List<string> { s, s.Substring(1,1) + s.Substring(0,1) };
    }
}