// See https://aka.ms/new-console-template for more information

using CircusTrein.Classes;

Train train = new Train();

List<Animal> animals = new List<Animal>
{
    new Animal("Lion", AnimalSize.Large, AnimalDiet.Carnivore),
    new Animal("Tiger", AnimalSize.Large, AnimalDiet.Carnivore),
    new Animal("Polar Bear", AnimalSize.Large, AnimalDiet.Carnivore),

    // Medium Carnivore
    new Animal("Penguin", AnimalSize.Medium, AnimalDiet.Carnivore),

    // Large Herbivores
    new Animal("Elephant", AnimalSize.Large, AnimalDiet.Herbivore),
    new Animal("Rhino", AnimalSize.Large, AnimalDiet.Herbivore),
    new Animal("Giraffe", AnimalSize.Large, AnimalDiet.Herbivore),
    
    // Medium Herbivores
    new Animal("Ape", AnimalSize.Medium, AnimalDiet.Herbivore),
    new Animal("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
    new Animal("Panda", AnimalSize.Medium, AnimalDiet.Herbivore),

    // Small Herbivores
    new Animal("Koala", AnimalSize.Small, AnimalDiet.Herbivore),

    // Large Carnivore
    new Animal("Grizzly Bear", AnimalSize.Large, AnimalDiet.Carnivore)
};


train.FillTrain(animals);
train.PrintTrain();
