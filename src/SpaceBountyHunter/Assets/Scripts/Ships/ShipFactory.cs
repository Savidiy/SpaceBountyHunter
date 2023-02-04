using UnityEngine;

namespace BountyHunter
{
    public class ShipFactory
    {
        private readonly Settings _settings;

        public ShipFactory(Settings settings)
        {
            _settings = settings;
        }

        public Ship CreateShip()
        {
            ShipHierarchy shipHierarchy = Object.Instantiate(_settings.ShipPrefab);

            var ship = new Ship(shipHierarchy, Vector2.right, 90);
            return ship;
        }
    }
}