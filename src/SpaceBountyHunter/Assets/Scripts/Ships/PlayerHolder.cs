namespace BountyHunter
{
    public class PlayerHolder
    {
        private readonly ShipFactory _shipFactory;

        public bool HasPlayerShip { get; private set; }
        public Ship PlayerShip { get; private set; }

        public PlayerHolder(ShipFactory shipFactory)
        {
            _shipFactory = shipFactory;
        }

        public void CreatePlayer()
        {
            HasPlayerShip = true;
            Ship ship = _shipFactory.CreateShip();
            PlayerShip = ship;
        }

        public void DestroyPlayer()
        {
            PlayerShip.Destroy();
            PlayerShip = null;
            HasPlayerShip = false;
        }
    }
}