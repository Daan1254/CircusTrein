using UnitTest.Classes;
using CircusTrein.Classes;

namespace UnitTest;

public class TrainTests
{
    // This method will serve as a source for TestCaseSource attribute
    public static IEnumerable<TrainScenario> ScenarioSource()
    {
        return new List<TrainScenario>
        {
            new TrainScenario(1,0,0,0,3,2,2),
            new TrainScenario(1,0,0,5,2,1,2),
            new TrainScenario(1,1,1,1,1,1,4),
            new TrainScenario(1,1,2,1,5,1,5),
            new TrainScenario(1,0,0,1,1,2,2),
            new TrainScenario(3,0,0,0,2,3,3),
            new TrainScenario(7,3,3,0,5,6,13),
            new TrainScenario(0, 0, 0, 5, 3, 1, 2),
            new TrainScenario(1, 3, 2, 0, 0, 3, 6),
            new TrainScenario(2, 2, 2, 5, 5, 5, 8),
            new TrainScenario(0, 0, 0, 1, 3, 2, 2),
            new TrainScenario(1, 0, 0, 3, 2, 1, 2),
            new TrainScenario(2, 0, 0, 0, 2, 2, 2),
            new TrainScenario(2, 0, 0, 0, 6, 2, 3)
        };
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test, TestCaseSource(nameof(ScenarioSource))]
    public void TestAllTrainScenarios(TrainScenario trainScenario) // dro.pm/av (https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
    {
        //arrange
        Train train = new Train();
        List<Animal> animals = new List<Animal>();

        for (int i = 0; i < trainScenario.LargeCarnivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Large, AnimalDiet.Carnivore));
        }

        for (int i = 0; i < trainScenario.MediumCarnivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Medium, AnimalDiet.Carnivore));
        }

        for (int i = 0; i < trainScenario.SmallCarnivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Small, AnimalDiet.Carnivore));
        }

        for (int i = 0; i < trainScenario.LargeHerbivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Large, AnimalDiet.Herbivore));
        }

        for (int i = 0; i < trainScenario.MediumHerbivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Medium, AnimalDiet.Herbivore));
        }

        for (int i = 0; i < trainScenario.SmallHerbivoreCount; i++)
        {
            animals.Add(new Animal(AnimalSize.Small, AnimalDiet.Herbivore));
        }
        
        //act
        train.FillTrain(animals);
    
        //assert
        Assert.That(
            train.Wagons.Count,
            Is.EqualTo(trainScenario.ExpectedWagonCount),
            $"Scenario failed: Expected {trainScenario.ExpectedWagonCount} wagons but got {train.Wagons.Count}. " +
            $"Details - LargeCarnivores: {trainScenario.LargeCarnivoreCount}, MediumCarnivores: {trainScenario.MediumCarnivoreCount}, " +
            $"SmallCarnivores: {trainScenario.SmallCarnivoreCount}, LargeHerbivores: {trainScenario.LargeHerbivoreCount}, " +
            $"MediumHerbivores: {trainScenario.MediumHerbivoreCount}, SmallHerbivores: {trainScenario.SmallHerbivoreCount}."
        );
    }
}