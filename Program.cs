using FinalCircusTrain;

Animal Cat = new Animal("Cat", AnimalSize.Small, AnimalDiet.Carnivore);
Animal Lion = new Animal("Lion", AnimalSize.Medium, AnimalDiet.Carnivore);
Animal BigMonkey = new Animal("BigMonkey", AnimalSize.Large, AnimalDiet.Carnivore);

Animal Bunny = new Animal("Bunny", AnimalSize.Small, AnimalDiet.Herbivore);
Animal Cow = new Animal("Cow", AnimalSize.Medium, AnimalDiet.Herbivore);
Animal Elephant = new Animal("Elephant", AnimalSize.Large, AnimalDiet.Herbivore);

List<Animal> test_case_1 = new() { Cat, Cow, Cow, Cow, Elephant, Elephant };
List<Animal> test_case_2 = new() { Elephant, Cow, Cow, Bunny, Bunny, Bunny, Bunny, Bunny, Cat };
List<Animal> test_case_3 = new() { Elephant, BigMonkey, Cow, Lion, Bunny, Cat };
List<Animal> test_case_4 = new() { Elephant, BigMonkey, Cow, Cow, Cow, Cow, Cow, Lion, Bunny, Cat, Cat };
List<Animal> test_case_5 = new() { Elephant, Elephant, Cow, Bunny, Cat };
List<Animal> test_case_6 = new() { Cat, Cat, Cat, Cow, Cow, Elephant, Elephant, Elephant };
List<Animal> test_case_7 = new() { Elephant, Elephant, Elephant, Elephant, Elephant, Elephant, BigMonkey, BigMonkey, BigMonkey, Cow, Cow, Cow, Cow, Cow, Lion, Lion, Lion, Cat, Cat, Cat, Cat, Cat, Cat, Cat };


Wagon wagon = new Wagon(test_case_1);