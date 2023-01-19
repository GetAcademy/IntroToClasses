namespace IntroToClasses
{
    internal class Clicker
    {
        private int _points;
        private int _upgrades;
        public char Character { get; }

        public Clicker(char character)
        {
            Character = character;
            _points = 0;
            _upgrades = 1;
        }

        public void Click()
        {
            _points += _upgrades;
        }

        public void BuyUpgrade()
        {
            if (_points < 10) return;
            _points -= 10;
            _upgrades++;
        }

        public void Show()
        {
            Console.WriteLine($"Klikker {Character} - poeng: {_points}");
        }
    }
}
