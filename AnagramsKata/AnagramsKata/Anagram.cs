namespace AnagramsKata.Tests;

public class Anagram
{
    public static List<string> Of(string s)
    {
        if(s.Length <= 1 ) return new List<string> { s };

        if(s.Length == 2 ) return new List<string> { s, s.Substring(1,1) + s.Substring(0,1) };

        return new List<string>()
        {
            s.Substring(0,1) + Of(GetStringWithoutCharAt(s, 0))[0],
            s.Substring(0,1) + Of(GetStringWithoutCharAt(s, 0))[1],
            s.Substring(1,1) + Of(GetStringWithoutCharAt(s, 1))[0],
            s.Substring(1,1) + Of(GetStringWithoutCharAt(s, 1))[1],
            s.Substring(2,1) + Of(GetStringWithoutCharAt(s, 2))[0],
            s.Substring(2,1) + Of(GetStringWithoutCharAt(s, 2))[1]
        };
    }

    private static string GetStringWithoutCharAt(string s, int index)
    {
        var beforeIndexString = s.Substring(0, index);
        var afterIndexString = s.Substring(index + 1, s.Length - (index + 1));

        return beforeIndexString + afterIndexString;
    }
}