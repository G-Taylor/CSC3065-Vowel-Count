using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class VowelCount{
    public int NumberOfVowels(string inputText){        
        if (inputText == null) return 0;
        return Regex.Matches(inputText, "[aeiou]", RegexOptions.IgnoreCase).Count;
    }
}