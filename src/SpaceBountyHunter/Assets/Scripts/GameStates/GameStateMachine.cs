using System.Collections.Generic;
using BountyHunter.Utils;

namespace BountyHunter
{
    public sealed class GameStateMachine : StateMachine<IGameState>
    {
        public GameStateMachine(List<IGameState> gameStates)
        {
            foreach (IGameState gameState in gameStates)
            {
                AddState(gameState);
            }
        }
    }
}