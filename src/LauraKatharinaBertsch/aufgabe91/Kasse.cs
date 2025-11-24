using System.ComponentModel;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe91
{
    public class Kasse
    {

        public static decimal dailyTurnover1 = 0m;
        public static decimal dailyTurnover2 = 0m;
        public static decimal dailyTurnover3 = 0m;

        public static void DailyTurnoverCheckout1(decimal cart)
        {
            dailyTurnover1 = dailyTurnover1 + cart;
        }
        public static void DailyTurnoverCheckout2(decimal cart)
        {
            
            dailyTurnover2 = dailyTurnover2 + cart;
        }
        public static void DailyTurnoverCheckout3(decimal cart)
        {

            dailyTurnover3 = dailyTurnover3 + cart;
        }
        public static decimal DailyTurnOver1()
        {
            return dailyTurnover1;
        }
        public static decimal DailyTurnOver2()
        {
            return dailyTurnover2;
        }
        public static decimal DailyTurnOver3()
        {
            return dailyTurnover3;
        }
    }
}