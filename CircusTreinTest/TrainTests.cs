using UnitTest.Classes;
using CircusTrein.Classes;

namespace UnitTest;

public class TrainTests
{
    // List of scenarios
    List<Scenario> scenarios = new List<Scenario>
    {
        new Scenario(1,0,0,0,3,2,2),
        new Scenario(1,0,0,5,2,1,2),
        new Scenario(1,1,1,1,1,1,4),
        new Scenario(1,1,2,1,5,1,5),
        new Scenario(1,0,0,1,1,2,2),
        new Scenario(3,0,0,0,2,3,3),
        new Scenario(7,3,3,0,5,6,13),
        new Scenario(0, 0, 0, 5, 3, 1, 2),
        new Scenario(1, 3, 2, 0, 0, 3, 6),
        new Scenario(2, 2, 2, 5, 5, 5, 8),
        new Scenario(0, 0, 0, 1, 3, 2, 2),
        new Scenario(1, 0, 0, 3, 2, 1, 2),
        new Scenario(2, 0, 0, 0, 2, 2, 2),
        new Scenario(2, 0, 0, 0, 6, 2, 3)
    };

    // This method will serve as a source for TestCaseSource attribute
    public static IEnumerable<Scenario> ScenarioSource()
    {
        return new List<Scenario>
        {
            new Scenario(1,0,0,0,3,2,2),
            new Scenario(1,0,0,5,2,1,2),
            new Scenario(1,1,1,1,1,1,4),
            new Scenario(1,1,2,1,5,1,5),
            new Scenario(1,0,0,1,1,2,2),
            new Scenario(3,0,0,0,2,3,3),
            new Scenario(7,3,3,0,5,6,13),
            new Scenario(0, 0, 0, 5, 3, 1, 2),
            new Scenario(1, 3, 2, 0, 0, 3, 6),
            new Scenario(2, 2, 2, 5, 5, 5, 8),
            new Scenario(0, 0, 0, 1, 3, 2, 2),
            new Scenario(1, 0, 0, 3, 2, 1, 2),
            new Scenario(2, 0, 0, 0, 2, 2, 2),
            new Scenario(2, 0, 0, 0, 6, 2, 3)
        };
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test, TestCaseSource(nameof(ScenarioSource))]
    public void FillTrain_(Scenario scenario) // dro.pm/av (https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
    {
        //arrange
        Train train = new Train();
        List<Animal> animals = new List<Animal>();

        for (int i = 0; i < scenario.LargeCarnivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Large, AnimalDiet.Carnivore));
        }

        for (int i = 0; i < scenario.MediumCarnivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Medium, AnimalDiet.Carnivore));
        }

        for (int i = 0; i < scenario.SmallCarnivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Small, AnimalDiet.Carnivore));
        }

        for (int i = 0; i < scenario.LargeHerbivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Large, AnimalDiet.Herbivore));
        }

        for (int i = 0; i < scenario.MediumHerbivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Medium, AnimalDiet.Herbivore));
        }

        for (int i = 0; i < scenario.SmallHerbivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Small, AnimalDiet.Herbivore));
        }
        
        //act
        train.FillTrain(animals);
    
        //assert
        Assert.That(
            train.Wagons.Count,
            Is.EqualTo(scenario.ExpectedWagonCount),
            $"Scenario failed: Expected {scenario.ExpectedWagonCount} wagons but got {train.Wagons.Count}. " +
            $"Details - LargeCarnivores: {scenario.LargeCarnivoreCount}, MediumCarnivores: {scenario.MediumCarnivoreCount}, " +
            $"SmallCarnivores: {scenario.SmallCarnivoreCount}, LargeHerbivores: {scenario.LargeHerbivoreCount}, " +
            $"MediumHerbivores: {scenario.MediumHerbivoreCount}, SmallHerbivores: {scenario.SmallHerbivoreCount}."
        );
    }
}