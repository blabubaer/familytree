using System;

namespace FamilyTree
{
    public class FamilyApp
    {
        private Person[] family
        {
            get;
            set;
        }
        public FamilyApp(params Person[] family)
        {
            foreach (var person in family)
            {
                this.family = family;
            }
        }

        private static string welcomeMessage = "Hello Folkens til vår kjempekult slektstre-program!";

        public string WelcomeMessage
        {
            get { return welcomeMessage; }
        }

        private static string commandPrompt = "Please enter one of the following commands: hjelp , liste, vis<id>";

        public string CommandPrompt
        {
            get { return commandPrompt; }
        }
        public string HandleCommand(string command)
        {
            if (command == "hjelp")
            {
                return "hjelp => viser en hjelpetekst som forklarer alle kommandoene \n liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.\n vis<id> => viser en bestemt person med mor, far og barn(og id for disse, slik at man lett kan vise en av dem) ";
            }

            if (command == "liste")
            {
                string returntext = "";
                foreach (var person in family)
                {
                    returntext += person.GetDescription() + "\n";

                }

                return returntext;
            }

            if (command.Contains(" "))
            {
                var wordlist = command.Split(" ");
                int id;
                bool success = Int32.TryParse(wordlist[1], out id);
                if (wordlist[0] == "vis" && success && wordlist.Length == 2)
                {
                    foreach (var person in family)
                    {
                        if (person.Id == id) return person.GetDescription();
                        else return "Ingen familienmedlem med denne Id.";
                    }
                }
            }

            return "Wrong Command, please try again with: hjelp , liste  , vis <id>";
        }

    }
}