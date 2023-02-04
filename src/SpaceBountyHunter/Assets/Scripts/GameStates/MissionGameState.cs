namespace BountyHunter
{
    public sealed class MissionGameState : IGameState
    {
        private readonly PlayerHolder _playerHolder;

        public MissionGameState(PlayerHolder playerHolder)
        {
            _playerHolder = playerHolder;
        }

        public void Enter()
        {
            CreatePlayerShip();
            // ActivatePlayerControls();
            // JoinCameraToPlayerShip();
        }

        private void CreatePlayerShip()
        {
            _playerHolder.CreatePlayer();
        }

        public void Exit()
        {
            DestroyPlayerShip();
            // DeactivatePlayerControls();
            // UnjoinCamera();
        }

        private void DestroyPlayerShip()
        {
            _playerHolder.DestroyPlayer();
        }

        public void Dispose()
        {
        }
    }
}