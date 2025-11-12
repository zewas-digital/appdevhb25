
namespace Appdevhb25.LiaLouiseNatter.Aufgabe76
{
    public class GroupStarter()
    {
        public static void Start()
        {
            PersonInGruppe person1 = new PersonInGruppe();
            person1.age = 20;
            person1.height = 180;
            person1.weight = 90;
            person1.name = "Rambo";

            PersonInGruppe person2 = new PersonInGruppe();
            person2.age = 24;
            person2.height = 150;
            person2.weight = 90;
            person2.name = "Ramon";
            

            PersonInGruppe person3 = new PersonInGruppe();
            person3.age = 14;
            person3.height = 120;
            person3.weight = 190;
            person3.name = "Rainer";

            PersonInGruppe person4 = new PersonInGruppe();
            person4.age = 40;
            person4.height = 170;
            person4.weight = 60;
            person4.name = "Jessica";

            PersonInGruppe person5 = new PersonInGruppe();
            person5.age = 50;
            person5.height = 150;
            person5.weight = 50;
            person5.name = "Chantal";

            Gruppe group = new Gruppe();
            group.neuePerson(person1);
            group.neuePerson(person2);
            group.neuePerson(person3);
            group.neuePerson(person4);
            group.neuePerson(person5);

            group.Smallest();
            group.Biggest();
            group.Average();


            System.Console.WriteLine("-----------------Sort by Age ASC---------------");
            group.SortByAge(true);
            
            System.Console.WriteLine("-----------------Sort by Age DESC---------------");
            group.SortByAge(false);

            System.Console.WriteLine("-----------------Sort by Height---------------");
            group.SortByHeight(true);
            
            System.Console.WriteLine("-----------------Sort by Weight---------------");
            group.SortByWeight(true);
            
            System.Console.WriteLine("-----------------Sort by Name---------------");
            group.SortByName(true);



        }
    }
}