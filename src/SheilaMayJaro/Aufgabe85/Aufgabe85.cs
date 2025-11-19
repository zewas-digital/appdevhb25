namespace Appdevhb25.SheilaMayJaro.Aufgabe85
{
    public class Aufgabe85
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 85)");
            Contact phoneNumberList = new Contact();
            phoneNumberList.AddContact(new Contact("Miriam","Diaz", "004356846548745"));
            phoneNumberList.AddContact(new Contact("Schmidt","004915646541564"));
            phoneNumberList.AddContact(new Contact("Peter","004356745414574"));

            phoneNumberList.PrintContacts();
            phoneNumberList.ModifyContact();
            phoneNumberList.PrintContacts();
            phoneNumberList.DeleteContact(); 
            phoneNumberList.PrintContacts();
            phoneNumberList.FindContact();
        }
    }
}