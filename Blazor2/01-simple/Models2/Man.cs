namespace DSS.Models2
{
    public enum Gender={Male, Female};
    {

        public string LastName = "";

        public string FistName = "";

        public Gender Gender=Gender.Male;

        public string Nationality = "";

        public PostalAdress Adress = new PostalAdress(){
            Street = "";
            City = "";
            PosatlCode = "";
            State = "";
        }

    }
}