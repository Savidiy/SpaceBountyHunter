using UnityEngine;

namespace BountyHunter
{
    public class Ship
    {
        private readonly ShipHierarchy _view;

        private Vector2 _position;
        private float _angle;

        public Ship(ShipHierarchy view, Vector2 position, float angle)
        {
            _view = view;
            _position = position;
            _angle = angle;

            UpdateView();
        }


        public void Destroy()
        {
            Object.Destroy(_view.gameObject);
        }

        private void UpdateView()
        {
            _view.transform.position = _position;
            _view.transform.rotation = Quaternion.Euler(0, 0, _angle);
        }
    }
}