using Org.BouncyCastle.Tls;

namespace Appdevhb25.JulianMatt.JulianMatt;

public class Start
{
    public static void StartPrüfung()
    {
        CountriesAndRivers countryAndRivers = new CountriesAndRivers();
        countryAndRivers.GetDictionary();
        countryAndRivers.PrintInformation();

    }
}