namespace ViceCity.Models.Players
{
    class MainPlayer : Player
    {
        private const string InitialName = "Tommy Vercetti";
        private const int InitialLifePoints = 100;

        public MainPlayer()
            : base(InitialName, InitialLifePoints)
        {
        }
    }
}
