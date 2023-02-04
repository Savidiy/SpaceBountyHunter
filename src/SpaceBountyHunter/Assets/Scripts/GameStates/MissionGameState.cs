namespace BountyHunter
{
    public sealed class MissionGameState : IGameState
    {
        private readonly PlayerHolder _playerHolder;
        private readonly PlayerInput _playerInput;
        private readonly ShipMover _shipMover;
        private CameraMover _cameraMover;

        public MissionGameState(PlayerHolder playerHolder, PlayerInput playerInput, ShipMover shipMover, CameraMover cameraMover)
        {
            _cameraMover = cameraMover;
            _playerHolder = playerHolder;
            _playerInput = playerInput;
            _shipMover = shipMover;
        }

        public void Enter()
        {
            _playerHolder.CreatePlayer();
            _playerInput.Activate();
            _shipMover.Activate();
            _cameraMover.Activate();
        }

        public void Exit()
        {
            _cameraMover.Deactivate();
            _shipMover.Deactivate();
            _playerInput.Deactivate();
            _playerHolder.DestroyPlayer();
        }

        public void Dispose()
        {
        }
    }
}