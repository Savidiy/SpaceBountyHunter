using UnityEngine;

namespace BountyHunter
{
    public sealed class ShelterGameState : IGameState
    {
        public void Enter()
        {
            Debug.Log("Show shelter window");

        }

        public void Exit()
        {
            Debug.Log("Hide shelter window");

        }

        public void Dispose()
        {
            
        }
    }
}