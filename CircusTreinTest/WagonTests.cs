using CircusTrein.Classes;
using UnitTest.Classes;

namespace UnitTest;

public class WagonTests
{
    
    public List<WagonScenario> WagonScenarios = new List<WagonScenario>
    {
    };
    
    public static IEnumerable<WagonScenario> ScenarioSource()
    {
        return new List<WagonScenario>
        {
            new WagonScenario(new List<Animal>
            {
                new Animal(AnimalSize.Large, AnimalDiet.Herbivore),
            }, new Animal(AnimalSize.Large, AnimalDiet.Herbivore))
        };
    }
    
    [Test, TestCaseSource(nameof(ScenarioSource))]
    public void AddAnimalToWagonTests(WagonScenario wagonScenario)
    {
        //arrange
        Wagon wagon = new Wagon(wagonScenario.AnimalsInWagon);
        Animal animal = wagonScenario.AnimalToAdd;
        
        //act
        wagon.AddAnimal(animal);
        
        //assert
        Assert.That((wagonScenario.AnimalsInWagon.Count + 1), Is.EqualTo(wagon.GetAnimalCount()));
    }
}