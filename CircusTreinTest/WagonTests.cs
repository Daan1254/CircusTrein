using CircusTrein.Classes;
using UnitTest.Classes;

namespace UnitTest;

public class WagonTests
{
    
    public List<WagonScenario> WagonScenarios = new List<WagonScenario>
{
        // Scenario 1: Large herbivore in the wagon, trying to add a large herbivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Herbivore)),

            // Scenario 2: Large herbivore in the wagon, trying to add a small carnivore (failure)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Small, AnimalDiet.Carnivore)),

            // Scenario 3: Small carnivore in the wagon, trying to add a medium herbivore (failure)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Carnivore),
            }, new Animal(AnimalSize.Medium, AnimalDiet.Herbivore)),

            // Scenario 4: Medium herbivore in the wagon, trying to add a large herbivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Medium, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Herbivore)),

            // Scenario 5: Large carnivore in the wagon, trying to add a small herbivore (failure)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Carnivore),
            }, new Animal(AnimalSize.Small, AnimalDiet.Herbivore)),

            // Scenario 6: Wagon is full, trying to add an animal (failure due to lack of space)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Herbivore),
                new Animal(AnimalSize.Medium, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Herbivore)),

            // Scenario 7: Wagon with small carnivore, adding another small carnivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Carnivore),
            }, new Animal(AnimalSize.Small, AnimalDiet.Carnivore)),

            // Scenario 8: Multiple small herbivores in the wagon, adding a medium herbivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Herbivore),
                new Animal(AnimalSize.Small, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Medium, AnimalDiet.Herbivore)),

            // Scenario 9: Small herbivore in the wagon, adding a large carnivore (failure)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Carnivore)),

            // Scenario 10: Wagon is empty, adding a large carnivore (success)
            new WagonScenario(new List<Animal>(), 
                new Animal(AnimalSize.Large, AnimalDiet.Carnivore)),

            // Scenario 11: Wagon with one small herbivore, adding another small herbivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Small, AnimalDiet.Herbivore)),
        };
    
    public static IEnumerable<WagonScenario> ScenarioSource()
    {
        return new List<WagonScenario>
        {
        // Scenario 1: Large herbivore in the wagon, trying to add a large herbivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Herbivore)),

            // Scenario 2: Large herbivore in the wagon, trying to add a small carnivore (failure)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Small, AnimalDiet.Carnivore)),

            // Scenario 3: Small carnivore in the wagon, trying to add a medium herbivore (failure)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Carnivore),
            }, new Animal(AnimalSize.Medium, AnimalDiet.Herbivore)),

            // Scenario 4: Medium herbivore in the wagon, trying to add a large herbivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Medium, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Herbivore)),

            // Scenario 5: Large carnivore in the wagon, trying to add a small herbivore (failure)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Carnivore),
            }, new Animal(AnimalSize.Small, AnimalDiet.Herbivore)),

            // Scenario 6: Wagon is full, trying to add an animal (failure due to lack of space)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Herbivore),
                new Animal(AnimalSize.Medium, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Herbivore)),

            // Scenario 7: Wagon with small carnivore, adding another small carnivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Carnivore),
            }, new Animal(AnimalSize.Small, AnimalDiet.Carnivore)),

            // Scenario 8: Multiple small herbivores in the wagon, adding a medium herbivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Herbivore),
                new Animal(AnimalSize.Small, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Medium, AnimalDiet.Herbivore)),

            // Scenario 9: Small herbivore in the wagon, adding a large carnivore (failure)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Carnivore)),

            // Scenario 10: Wagon is empty, adding a large carnivore (success)
            new WagonScenario(new List<Animal>(), 
                new Animal(AnimalSize.Large, AnimalDiet.Carnivore)),

            // Scenario 11: Wagon with one small herbivore, adding another small herbivore (success)
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Small, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Small, AnimalDiet.Herbivore)),
        };
    }
    
    [Test, TestCaseSource(nameof(ScenarioSource))]
    public void AddAnimalToWagonTests(WagonScenario wagonScenario)
    {
        // Arrange
        Wagon wagon = new Wagon(wagonScenario.AnimalsInWagon);
        Animal animal = wagonScenario.AnimalToAdd;

        // Act
        int initialAnimalCount = wagon.GetAnimalCount();
        bool canAdd = wagon.CanAddAnimal(animal);
        if (canAdd)
        {
            wagon.AddAnimal(animal);
        }

        // Assert
        int expectedAnimalCount = canAdd ? initialAnimalCount + 1 : initialAnimalCount;
        Assert.That(wagon.GetAnimalCount(), Is.EqualTo(expectedAnimalCount));
    }
}