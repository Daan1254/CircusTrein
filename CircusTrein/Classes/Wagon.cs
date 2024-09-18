namespace CircusTrein.Classes;

public class Wagon
{
    private const int Capacity = 10; // Wagon's total capacity.
    private int _remainingCapacity = Capacity; // Tracks remaining space.
    private List<Animal> _animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        if (CanAddAnimal(animal))
        {
            _animals.Add(animal);
            _remainingCapacity -= (int)animal.Size;
        }
    }

    public int GetAnimalCount()
    {
        return _animals.Count;
    }

    public int GetRemainingCapacity()
    {
        return _remainingCapacity;
    }

    private bool HasEnoughSpace(Animal animal)
    {
        return _remainingCapacity >= (int)animal.Size;
    }

    public bool CanAddAnimal(Animal animal)
    {
        if (!HasEnoughSpace(animal)) return false;

        foreach (var animalInWagon in _animals)
        {
            if (!animalInWagon.IsCompatibleWith(animal))
            {
                return false; 
            }
        }

        return true;
    }

    public void PrintWagon()
    {
        Console.WriteLine($"Wagon with {GetAnimalCount()} animals. (Remaining capacity: {GetRemainingCapacity()})");

        foreach (var animal in _animals)
        {
            Console.WriteLine($" - {animal.Name} ({animal.Size}) ({animal.Diet})");
        }
    }
}