namespace Appdevhb25.LiaLouiseNatter.Aufgabe102;
public class StartDbReadIntoOOP()
{
    public static void start()
    {
        DbReadIntoOOP dbReadIntoOOP = new DbReadIntoOOP();
        dbReadIntoOOP.BookNames();
        dbReadIntoOOP.searchBooks("ZERO");
        dbReadIntoOOP.searchBooks("Die");
        dbReadIntoOOP.searchBooks("Es");
        dbReadIntoOOP.searchBooks("Harry");
        dbReadIntoOOP.searchBooks("Potter");
    }
}