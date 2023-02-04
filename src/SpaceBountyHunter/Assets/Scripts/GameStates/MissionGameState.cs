using UnityEngine;

namespace BountyHunter
{
    public sealed class MissionGameState : IGameState
    {
        public void Enter()
        {
            Debug.Log("Show space window");

        }

        public void Exit()
        {
            Debug.Log("Hide space window");

        }

        public void Dispose()
        {
            
        }
    }
}