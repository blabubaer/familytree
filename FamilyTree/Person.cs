namespace FamilyTree
{
    public class Person
    {
        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public int BirthYear
        {
            get;
            set;
        }

        public int DeathYear
        {
            get;
            set;
        }


        public Person Mother
        {
            get;
            set;
        }


        public Person Father
        {
            get;
            set;
        }

        //Father = new Person() { Id = 23, FirstName = "Per" },
        //var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };


        public Person(int id, string firstname, string lastname, int birthyear, int deathyear, Person father, Person mother)
        {
            this.Father = father;
            this.Mother = mother;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Id = id;
            this.BirthYear = birthyear;
            this.DeathYear = deathyear;
        }

        public Person(int id, string firstname)
        {
            this.FirstName = firstname;
            this.Id = id;
        }

        public Person(){}
        //"Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)"
        public string GetDescription()
        {
            string returntext = "";
            if (FirstName != null)
            {
                returntext += CheckForSpaces(returntext);
                returntext += FirstName;
            }
            if (LastName != null)
            {
                returntext += CheckForSpaces(returntext);
                returntext += LastName;
            }
            if (Id != null)
            {
                returntext += CheckForSpaces(returntext);
                returntext += $"(Id={Id})";
            }
            if (BirthYear != 0)
            {
                returntext += CheckForSpaces(returntext);
                returntext += $"Født: {BirthYear}";
            }
            if (DeathYear != 0)
            {
                returntext += CheckForSpaces(returntext);
                returntext += $"Død: {DeathYear}";
            }
            if (Father != null)
            {
                returntext += CheckForSpaces(returntext);
                returntext += $"Far: {Father.FirstName} (Id={Father.Id})";
            }
            if (Mother != null)
            {
                returntext += CheckForSpaces(returntext);
                returntext += $"Mor: {Mother.FirstName} (Id={Mother.Id})";
            }

            return returntext;
        }


        private string CheckForSpaces(string text)
        {
            if (text.Length != 0)
            {
                return " ";
            }
            else return "";
        }
    }
}