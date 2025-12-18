namespace Appdevhb25.LiaLouiseNatter.Zoo
{
    public static class Main
    {
        public static void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Zoo zoo = new Zoo("Tiergarten Dornbirn", 2022);

            Compound alpenwiese = new Compound("Alpenwiese");
            Compound ried = new Compound("Ried");
            Compound terrariumWarm = new Compound("Terrarium (warm)");

            Food heu = new Food("Heu", "kg", 0.5);
            FoodRequirements foodRequirements = new FoodRequirements(heu, 20);

            Food wasser = new Food("Wasser", "L", 0.02);
            FoodRequirements foodRequirements1 = new FoodRequirements(wasser, 100.05);

            alpenwiese.AddAnimal(new Animal("Rijska", "Kuh", foodRequirements));

            ried.AddAnimal(new Animal("Garmond", "Storch", foodRequirements));
            ried.AddAnimal(new Animal("Hugo", "Storch", foodRequirements1));
            ried.AddAnimal(new Animal("Idaxis", "Storch", foodRequirements1));

            zoo.AddCompound(alpenwiese);
            zoo.AddCompound(ried);
            zoo.AddCompound(terrariumWarm);
            zoo.UpdateFoodList();

            zoo.PrintZooStructure();
            zoo.PrintFoodCosts();
        }

    }
}