namespace CircusTrein.Classes;

public class Train
{
    private List<Wagon> _wagons = new List<Wagon>();
    
    public void AddWagon(List<Animal> animals)
    {
        
    } 
    
    
    public void RemoveWagon()
    {
        
    }
    
    
    public int TotalCapacity()
    {
        return 0;
    }
    
    public int TotalAnimalCount()
    {
        int total = 0;
        foreach (Wagon wagon in _wagons)
        {
            total += wagon.GetAnimalCount();
        }
        return total;
    }

    public void FillTrain(List<Animal> animals)
    {
        List<Animal> sortedAnimals = animals
            .OrderBy(animal => animal.Diet)
            .ThenBy(animal => animal.Size)
            .ToList();
        
        
        foreach (Animal animal in sortedAnimals)
        {
            bool foundSpace = false;
            foreach (Wagon wagon in _wagons)
            {
                if (wagon.CanAddAnimal(animal))
                {
                    wagon.AddAnimal(animal);
                    foundSpace = true;
                }
            }

            if (!foundSpace)
            {
                Wagon newWagon = new Wagon();
                newWagon.AddAnimal(animal);
                _wagons.Add(newWagon);
            }
        }
    }
    
    public void PrintTrain()
    {
        // Print the Train with all wagons in a string
        Console.WriteLine($"Train with {_wagons.Count} wagons and {TotalAnimalCount()} animals.");
        
        foreach (Wagon wagon in _wagons)
        {
            wagon.PrintWagon();
        }
    }
}