using DateTime = System.DateTime;

namespace IntroToClasses
{
    internal class Person
    {
        private string _name;
        private int _birthYear;

        public Person(string name, int birthYear)
        {
            _name = name;
            _birthYear = birthYear;
        }

        public Person(int birthYear)
            : this("Hansen", birthYear)
        {
        }

        public Person()
            : this(1975)
        {
            
        }

        public void Show()
        {
            var age = GetAge();
            Console.WriteLine($"{_name} ({age})");
        }

        public int GetAge()
        {
            return DateTime.Now.Year - _birthYear;
        }


        //public void Init(string name, int birthYear)
        //{
        //    _name = name;
        //    _birthYear = birthYear;
        //}
    }
}
