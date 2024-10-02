using CircusTrein.Classes;
using UnitTest.Classes;

namespace UnitTest;

public class AnimalTests
{
    
    
    List<AnimalScenario> scenarios = new List<AnimalScenario>
    {
        // Both animals are herbivores
        new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Herbivore, true),

    // Animal One is Carnivore, Animal Two is Herbivore
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Herbivore, false),

    // Animal One is Herbivore, Animal Two is Carnivore
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Carnivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Carnivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Carnivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Carnivore, false),

    // Both animals are carnivores (Updated this section)
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Carnivore, true),   // Same size, coexist
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Carnivore, false), // Medium eats small (changed to false)
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Carnivore, false),  // Large eats small (changed to false)
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Carnivore, true),  // Medium is larger and will eat small
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Carnivore, true), // Same size, coexist
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Carnivore, false), // Large eats medium (changed to false)
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Carnivore, true),   // Large eats small
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Carnivore, true),  // Large eats medium
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Carnivore, true),   // Same size, coexist
    };

    // This method will serve as a source for TestCaseSource attribute
    public static IEnumerable<AnimalScenario> ScenarioSource()
    {
     return new List<AnimalScenario>
     {
            // Both animals are herbivores
            new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Herbivore, true),

    // Animal One is Carnivore, Animal Two is Herbivore
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Herbivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Herbivore, false),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Herbivore, false),

    // Animal One is Herbivore, Animal Two is Carnivore
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Carnivore, true),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Carnivore, false),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Small, AnimalDiet.Carnivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Medium, AnimalDiet.Carnivore, true),
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Herbivore, AnimalSize.Large, AnimalDiet.Carnivore, false),

    // Both animals are carnivores (Updated this section)
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Carnivore, false),   // Same size, coexist
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Carnivore, false), // Medium eats small (changed to false)
    new AnimalScenario(AnimalSize.Small, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Carnivore, false),  // Large eats small (changed to false)
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Carnivore, false),  // Medium is larger and will eat small
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Carnivore, false), // Same size, coexist
    new AnimalScenario(AnimalSize.Medium, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Carnivore, false), // Large eats medium (changed to false)
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Small, AnimalDiet.Carnivore, false),   // Large eats small
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Medium, AnimalDiet.Carnivore, false),  // Large eats medium
    new AnimalScenario(AnimalSize.Large, AnimalDiet.Carnivore, AnimalSize.Large, AnimalDiet.Carnivore, false),   // Same size, coexist
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
        Assert.That(result, Is.EqualTo(scenario.ExpectedResult),
            $"Scenario failed: Expected {scenario.ExpectedResult} outcome but got {result}. " +
            $"Details - Animal One Diet: {animalOne.Diet}" +
            $"Details - Animal One Size: {animalOne.Size}" +
            $"Details - Animal Two Diet: {animalTwo.Diet}" +
            $"Details - Animal One Size: {animalTwo.Size}");
    }
}