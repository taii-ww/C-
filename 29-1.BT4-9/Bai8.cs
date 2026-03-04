using System;

public class Bai8
{
    public string TimTuDaiNhat(string s)
    {
        if (s == null)
            return null;

        s = s.Trim();
        if (s == "")
            return null;

        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string maxWord = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > maxWord.Length)
                maxWord = words[i];
        }

        return maxWord;
    }
}

