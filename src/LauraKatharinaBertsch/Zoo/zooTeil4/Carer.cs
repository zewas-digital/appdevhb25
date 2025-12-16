namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil4
{
    public class Carer
    {
        public string CarerName{get; private set;}
        
        public Carer (string carerName)
        {
            CarerName = carerName;
        }
        public override string ToString()
        {
            return $"{CarerName}, Gehege: ";
        }
    }
}