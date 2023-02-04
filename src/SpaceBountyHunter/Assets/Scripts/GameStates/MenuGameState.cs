using UnityEngine;

namespace BountyHunter
{
    public sealed class MenuGameState : IGameState
    {
        public void Enter()
        {
            Debug.Log("Show menu window");
        }

        public void Exit()
        {
            Debug.Log("Hide menu window");
        }

        public void Dispose()
        {
        }
    }
}