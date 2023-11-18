namespace DSS.Models2
{
    public class Actor: Man, IVanity
    {

        public int NumberOfOscars = 0;
        public int NumberOfBafars = 0;
        public double ImdbMark = 5;
        public string Bragging(){
            return "I, " + LastName + " " + FirstName + " am the best actor!!!";
        }

    }
}