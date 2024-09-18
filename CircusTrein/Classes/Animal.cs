namespace CircusTrein.Classes;


public enum AnimalSize
{
    Small = 1,
    Medium = 3,
    Large = 5
}

public enum AnimalDiet
{
    Carnivore,
    Herbivore
}

public class Animal
{
    
    public string Name { get; private set; }
    public AnimalSize Size { get; private set; }
    public AnimalDiet Diet { get; private set; }

    
    
    public Animal(string name, AnimalSize size, AnimalDiet diet)
    {
        Name = name;
        Size = size;
        Diet = diet;
    }
    
    
    public bool IsCompatibleWith(Animal animal)
    {
        bool success = true;
        
        if (Diet == AnimalDiet.Carnivore && animal.Diet == AnimalDiet.Herbivore)
        {
            success = false;
        }
        
        if (Diet == AnimalDiet.Herbivore && animal.Diet == AnimalDiet.Carnivore)
        {
            success = false;
        }
        
        if (Size == AnimalSize.Small && animal.Size == AnimalSize.Large)
        {
            success = false;
        }
        
        if (Size == AnimalSize.Large && animal.Size == AnimalSize.Small)
        {
            success = false;
        }
        
        return success;
    }
}