namespace AnagramsKata.Tests;

public class Anagram
{
    public static List<string> Of(string s)
    {
        if(s.Length <= 1 ) return new List<string> { s };

        if(s.Length == 2 ) return new List<string> { s, s.Substring(1,1) + s.Substring(0,1) };

        return new List<string>()
        {
            s.Substring(0,1) + Of("BC")[0],
            s.Substring(0,1) + Of("BC")[1],
            s.Substring(1,1) + Of("AC")[0],
            s.Substring(1,1) + Of("AC")[1],
            s.Substring(2,1) + Of("AB")[0],
            s.Substring(2,1) + Of("AB")[1]
        };
    }
}