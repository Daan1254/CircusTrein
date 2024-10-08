using CircusTrein.Classes;

namespace UnitTest.Classes;

public class AnimalScenario
{
    // Animal One
    public AnimalSize SizeOne { get; set; }
    public AnimalDiet DietOne { get; set; }
    
    // Animal Two
    public AnimalSize SizeTwo { get; set; }
    public AnimalDiet DietTwo { get; set; }
    
    
    // Expected Result
    public bool ExpectedResult { get; set; }


    public AnimalScenario(AnimalSize sizeOne, AnimalDiet dietOne, AnimalSize sizeTwo, AnimalDiet dietTwo, bool expectedResult)
    {
        SizeOne = sizeOne;
        DietOne = dietOne;
        SizeTwo = sizeTwo;
        DietTwo = dietTwo;
        ExpectedResult = expectedResult;
    }
}