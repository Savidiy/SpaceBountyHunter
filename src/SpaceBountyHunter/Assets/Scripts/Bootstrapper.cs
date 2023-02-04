using UnityEngine;
using Zenject;

namespace BountyHunter
{
    internal sealed class Bootstrapper : IInitializable
    {
        private readonly GameStateMachine _gameStateMachine;

        public Bootstrapper(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        public void Initialize()
        {
            Debug.Log("Bootstrapper start");
            _gameStateMachine.EnterToState<MenuGameState>();
        }
    }
}