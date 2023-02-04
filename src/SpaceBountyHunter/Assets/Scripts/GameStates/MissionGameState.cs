namespace BountyHunter
{
    public sealed class MissionGameState : IGameState
    {
        private readonly PlayerHolder _playerHolder;
        private readonly PlayerInput _playerInput;
        private readonly ShipMover _shipMover;

        public MissionGameState(PlayerHolder playerHolder, PlayerInput playerInput, ShipMover shipMover)
        {
            _playerHolder = playerHolder;
            _playerInput = playerInput;
            _shipMover = shipMover;
        }

        public void Enter()
        {
            _playerHolder.CreatePlayer();
            _playerInput.Activate();
            _shipMover.Activate();
            // JoinCameraToPlayerShip();
        }

        public void Exit()
        {
            // UnjoinCamera();
            _shipMover.Deactivate();
            _playerInput.Deactivate();
            _playerHolder.DestroyPlayer();
        }

        public void Dispose()
        {
        }
    }
}