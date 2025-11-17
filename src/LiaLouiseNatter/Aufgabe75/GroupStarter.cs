
namespace Appdevhb25.LiaLouiseNatter.Aufgabe75
{
    public class GroupStarter()
    {
        public static void Start()
        {
            PersonInGruppe person1 = new PersonInGruppe();
            person1.age = 20;
            person1.height = 180;
            person1.weight = 90;

            PersonInGruppe person2 = new PersonInGruppe();
            person2.age = 24;
            person2.height = 150;
            person2.weight = 90;

            PersonInGruppe person3 = new PersonInGruppe();
            person3.age = 14;
            person3.height = 120;
            person3.weight = 190;

            PersonInGruppe person4 = new PersonInGruppe();
            person4.age = 40;
            person4.height = 170;
            person4.weight = 60;

            PersonInGruppe person5 = new PersonInGruppe();
            person5.age = 50;
            person5.height = 150;
            person5.weight = 50;

            Gruppe group = new Gruppe();
            group.neuePerson(person1);
            group.neuePerson(person2);
            group.neuePerson(person3);
            group.neuePerson(person4);
            group.neuePerson(person5);

            group.Smallest();
            group.Biggest();
            group.Average();


        }
    }
}