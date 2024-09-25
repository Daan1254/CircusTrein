using System.Collections.ObjectModel;

namespace CircusTrein.Classes
{
    public class Train
    {
        private List<Wagon> _wagons = new List<Wagon>();
        public ReadOnlyCollection<Wagon> Wagons => _wagons.AsReadOnly();
        private int TotalAnimalCount => _wagons.Sum(wagon => wagon.GetAnimalCount());

        public void FillTrain(List<Animal> animals)
        {
            List<Animal> carnivores = animals.Where(animal => animal.Diet == AnimalDiet.Carnivore).ToList();
            List<Animal> herbivores = animals.Where(animal => animal.Diet == AnimalDiet.Herbivore).ToList();

            List<Animal> carnivoresAscending = carnivores.OrderBy(a => a.Size).ToList();
            List<Animal> carnivoresDescending = carnivores.OrderByDescending(a => a.Size).ToList();

            List<Animal> herbivoresAscending = herbivores.OrderBy(a => a.Size).ToList();
            List<Animal> herbivoresDescending = herbivores.OrderByDescending(a => a.Size).ToList();

            List<Wagon> option1 = FillTrainWithAnimals(carnivoresAscending.Concat(herbivoresAscending).ToList());
            List<Wagon> option2 = FillTrainWithAnimals(carnivoresAscending.Concat(herbivoresDescending).ToList());
            List<Wagon> option3 = FillTrainWithAnimals(carnivoresDescending.Concat(herbivoresAscending).ToList());
            List<Wagon> option4 = FillTrainWithAnimals(carnivoresDescending.Concat(herbivoresDescending).ToList());

            _wagons = new List<List<Wagon>> { option1, option2, option3, option4 }
                .OrderBy(wagonList => wagonList.Count)
                .First();
        }

        private List<Wagon> FillTrainWithAnimals(List<Animal> sortedAnimals)
        {
            // Create a temporary list of wagons
            List<Wagon> tempWagons = [];

            foreach (Animal animal in sortedAnimals)
            {
                Wagon? suitableWagon = FindWagonForAnimal(animal, tempWagons);

                if (suitableWagon != null) continue;
                
                Wagon newWagon = new Wagon();
                newWagon.AddAnimal(animal);
                tempWagons.Add(newWagon);
            }

            return tempWagons;
        }

        private Wagon? FindWagonForAnimal(Animal animal, List<Wagon> wagons)
        {
            foreach (var wagon in wagons)
            {
                if (wagon.CanAddAnimal(animal))
                {
                    wagon.AddAnimal(animal);
                    return wagon;
                }
            }

            // No suitable wagon found
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
}