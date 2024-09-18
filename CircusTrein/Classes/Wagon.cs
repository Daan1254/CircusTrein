namespace CircusTrein.Classes;

public class Wagon
{
    private int _capacity;
    
    private List<Animal> _animals = new List<Animal>();
    
    public Wagon()
    {
        this._capacity = 10;
    }
    
    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
        
        _capacity -= (int) animal.Size;
    }

    private bool IsFull()
    {
        return _capacity < 1;
    }

    public int GetAnimalCount()
    {
        return _animals.Count;
    }

  

    private bool IsSpace(AnimalSize size)
    {
        return _capacity < (int) size;
    }
    
    public bool CanAddAnimal(Animal animal)
    {
        if (IsSpace(animal.Size))
        {
            return false;
        }
        
        foreach (Animal animalInWagon in _animals)
        {
            if (animalInWagon.IsCompatibleWith(animal))
            {
                return true;
            }
        }
       
        return false;
    }


    public void PrintWagon()
    {
        Console.WriteLine("Wagon with " + GetAnimalCount() + " animals. (Remaining capacity: " + _capacity + ")");
        
        foreach (Animal animal in _animals)
        {
            Console.WriteLine($" - {animal.Name} ({animal.Size}) ({animal.Diet})");
        }
    }
    
}