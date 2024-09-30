using CircusTrein.Classes;
using UnitTest.Classes;

namespace UnitTest;

public class AnimalTests
{
    
    
    List<AnimalScenario> scenarios = new List<AnimalScenario>
    {
       
    };

    // This method will serve as a source for TestCaseSource attribute
    public static IEnumerable<AnimalScenario> ScenarioSource()
    {
        return new List<AnimalScenario>
        {
            new AnimalScenario(),
        };
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test, TestCaseSource(nameof(ScenarioSource))]
    public void IsCompatibleWith_(AnimalScenario scenario) // dro.pm/av (https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
    {
        //arrange
        Animal animalOne = new Animal(scenario.SizeOne, scenario.DietOne);
        Animal animalTwo = new Animal(scenario.SizeTwo, scenario.DietTwo);
        
        //act
        bool result = animalOne.IsCompatibleWith(animalTwo);
        
        //assert
        Assert.That(result, Is.EqualTo(scenario.ExpectedResult));
    }
}