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

    public Animal( AnimalSize size, AnimalDiet diet) : this("Animal", size, diet)
    {
    }
    

    public bool IsCompatibleWith(Animal otherAnimal)
    {
        if (this.Diet == AnimalDiet.Carnivore && otherAnimal.Diet == AnimalDiet.Herbivore && this.Size >= otherAnimal.Size)
        {
            return false;
        }

        if (this.Diet == AnimalDiet.Herbivore && otherAnimal.Diet == AnimalDiet.Carnivore && this.Size <= otherAnimal.Size)
        {
            return false;
        }

        if ((this.Diet == AnimalDiet.Carnivore && this.Size >= otherAnimal.Size) ||
            (otherAnimal.Diet == AnimalDiet.Carnivore && otherAnimal.Size >= this.Size))
        {
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        return $"{Name} ({Size}) ({Diet})";
    }
}