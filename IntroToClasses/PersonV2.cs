namespace IntroToClasses
{
    internal class PersonV2
    {
        private string _name;
        public int BirthYear { get; private set; }

        public PersonV2(string name, int birthYear)
        {
            _name = name;
            BirthYear = birthYear;
        }

        public PersonV2(int birthYear)
            : this("Hansen", birthYear)
        {
        }

        public PersonV2()
            : this(1975)
        {

        }

        public int GetBirthYear()
        {
            return BirthYear;
        }

        public void Show()
        {
            var age = GetAge();
            Console.WriteLine($"{_name} ({age})");
        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthYear;
        }
    }
}
