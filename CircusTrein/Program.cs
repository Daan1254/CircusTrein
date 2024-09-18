// See https://aka.ms/new-console-template for more information

using CircusTrein.Classes;

Console.WriteLine("Hello, World!");

Train train = new Train();

List<Animal> animals = new List<Animal>
{
    new Animal("Ape", AnimalSize.Medium, AnimalDiet.Herbivore),
    new Animal("Elephant", AnimalSize.Large, AnimalDiet.Carnivore),
    new Animal("Lion", AnimalSize.Large, AnimalDiet.Carnivore),
    new Animal("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
    new Animal("Giraffe", AnimalSize.Large, AnimalDiet.Herbivore),
    new Animal("Tiger", AnimalSize.Large, AnimalDiet.Carnivore),
    new Animal("Penguin", AnimalSize.Small, AnimalDiet.Carnivore),
    new Animal("Kangaroo", AnimalSize.Medium, AnimalDiet.Herbivore),
    new Animal("Gorilla", AnimalSize.Medium, AnimalDiet.Herbivore),
    new Animal("Rhino", AnimalSize.Large, AnimalDiet.Herbivore),
    new Animal("Hippo", AnimalSize.Large, AnimalDiet.Herbivore),
    new Animal("Panda", AnimalSize.Medium, AnimalDiet.Herbivore),
    new Animal("Koala", AnimalSize.Small, AnimalDiet.Herbivore),
    new Animal("Polar Bear", AnimalSize.Large, AnimalDiet.Carnivore),
    new Animal("Grizzly Bear", AnimalSize.Large, AnimalDiet.Carnivore),
};


train.FillTrain(animals);
train.PrintTrain();
