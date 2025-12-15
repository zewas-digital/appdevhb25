namespace Appdevhb25.LiaLouiseNatter.Zoo
{
    public static class Main
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten Dornbirn", 2022);
            List<Compound> compoundList = new List<Compound>
            {
                new Compound("Alpenwiese"),
                new Compound("Ried"),
                new Compound("Terrarium (warm)"),
                
            };
            
            Compound compound1 = new Compound("Terrarium (kalt)");
            compoundList.Add(compound1);
            
            
            
            foreach(Compound compound in compoundList)
            {
                zoo.AddCompound(compound);
            }
            zoo.PrintZooStructure();
            zoo.DeleteCompound(compound1);
            zoo.PrintZooStructure();

        }
    }
}