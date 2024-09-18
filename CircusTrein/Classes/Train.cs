using System.Collections.ObjectModel;

namespace CircusTrein.Classes;

public class Train
{
    private List<Wagon> _wagons = new List<Wagon>();
    public ReadOnlyCollection<Wagon> Wagons => _wagons.AsReadOnly();
    public int TotalAnimalCount => _wagons.Sum(wagon => wagon.GetAnimalCount());
    

    public void FillTrain(List<Animal> animals)
    {
        List<Animal> sortedAnimals = animals
            .OrderByDescending(animal => animal.Size)
            .ThenBy(animal => animal.Diet) // Carnivores first.
            .ToList();

        foreach (Animal animal in sortedAnimals)
        {
            Wagon? suitableWagon = FindWagonForAnimal(animal);

            if (suitableWagon == null) 
            {
                Wagon newWagon = new Wagon();
                newWagon.AddAnimal(animal);
                _wagons.Add(newWagon);
            }
        }
    }

    private Wagon? FindWagonForAnimal(Animal animal)
    {
        foreach (var wagon in _wagons)
        {
            if (wagon.CanAddAnimal(animal))
            {
                wagon.AddAnimal(animal);
                return wagon;
            }
        }

        // No suitable wagon found.
        return null;
    }

    public void PrintTrain()
    {
        Console.WriteLine($"Train with {_wagons.Count} wagons and {TotalAnimalCount} animals.");

        foreach (var wagon in _wagons)
        {
            wagon.PrintWagon();
        }
    }
}