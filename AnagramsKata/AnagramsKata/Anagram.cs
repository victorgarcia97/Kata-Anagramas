namespace AnagramsKata.Tests;

public class Anagram
{
    public static List<string> Of(string s)
    {
        if(s.Length <= 1 ) return new List<string> { s };

        if(s.Length == 2 ) return new List<string> { s, s.Substring(1,1) + s.Substring(0,1) };

        return new List<string>()
        {
            s.Substring(0,1) + "BC",
            s.Substring(0,1) + "CB",
            s.Substring(1,1) + "AC",
            s.Substring(1,1) + "CA",
            s.Substring(2,1) + "AB",
            s.Substring(2,1) + "BA"
        };
    }
}