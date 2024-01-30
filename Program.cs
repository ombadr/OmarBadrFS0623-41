using System.Windows.Markup;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Omar", "Barreto", 25);
        person.GetAll();
    }

    class Person
    {
        private string _name = "";
        private string _lastName = "";
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 50)
                {

                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Il nome deve essere compreso da 2 a 50 caratteri");
                }
            }
        }


        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 50)
                {

                    _lastName = value;
                }
                else
                {
                    throw new ArgumentException("Il cognome deve essere compreso da 2 a 50 caratteri");
                }
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {

                    _age = value;
                }
                else
                {
                    throw new ArgumentException("L'eta deve essere compresa tra 0 e 120 anni");
                }
            }
        }

        public Person(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }

        public void GetName()
        {
            Console.WriteLine("Nome: " + Name);
        }

        public void GetLastName()
        {
            Console.WriteLine("Cognome: " + LastName);
        }

        public void GetAge()
        {
            Console.WriteLine("Eta: " + Age);
        }

        public void GetAll()
        {
            GetName();
            GetLastName();
            GetAge();
        }




    }
}

// controllo su lunghezza
// formattazione testo
// controllo eta maggiore di 0
// 