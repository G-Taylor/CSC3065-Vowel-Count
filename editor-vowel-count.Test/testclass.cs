using Xunit;
using System;

public class testclass{
    
    [Fact]
    public void Vowel_Count_Equals_Three_Test(){
        var controller = new VowelCount();
        var threeVowelString = "tesati";

        int result = controller.NumberOfVowels(threeVowelString);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Vowel_Count_Equals_One_Test(){
        var controller = new VowelCount();
        var oneVowelString = "test";

        int result = controller.NumberOfVowels(oneVowelString);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Vowel_Count_Equals_Twenty_Test(){
        var controller = new VowelCount();
        var twentyVowelString = "This is a test of a twenty vowel string u elkfhi dsawetry qwerty uioa";

        int result = controller.NumberOfVowels(twentyVowelString);

        Assert.Equal(20, result);
    }
}