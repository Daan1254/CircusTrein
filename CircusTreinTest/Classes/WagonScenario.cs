using CircusTrein.Classes;

namespace UnitTest.Classes;

public class WagonScenario(List<Animal> animalsInWagon, Animal animalToAdd)
{
    public List<Animal> AnimalsInWagon { get; set; } = animalsInWagon;

    public Animal AnimalToAdd { get; set; } = animalToAdd;
    
    public int OriginalAnimalCount = animalsInWagon.Count;
}