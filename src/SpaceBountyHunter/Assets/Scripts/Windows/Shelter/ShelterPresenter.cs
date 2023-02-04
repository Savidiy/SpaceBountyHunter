using System;
using Object = UnityEngine.Object;

namespace BountyHunter
{
    public class ShelterPresenter : IDisposable
    {
        private readonly ShelterWindowView _shelterWindowView;
        private readonly GameProgressProvider _gameProgressProvider;
        private readonly GameStateMachine _gameStateMachine;

        public ShelterPresenter(GameProgressProvider gameProgressProvider, GameStateMachine gameStateMachine)
        {
            _gameProgressProvider = gameProgressProvider;
            _gameStateMachine = gameStateMachine;
            _shelterWindowView = Object.FindObjectOfType<ShelterWindowView>();
            _shelterWindowView.HideWindow();

            _shelterWindowView.MenuClicked += OnMenuClicked;
        }

        private void OnMenuClicked()
        {
            _gameProgressProvider.SaveProgress();
            _gameStateMachine.EnterToState<MenuGameState>();
        }

        public void ShowWindow()
        {
            _shelterWindowView.ShowWindow(_gameProgressProvider.Progress);
        }

        public void HideWindow()
        {
            _shelterWindowView.HideWindow();
        }

        public void Dispose()
        {
            _shelterWindowView.MenuClicked -= OnMenuClicked;
        }
    }
}