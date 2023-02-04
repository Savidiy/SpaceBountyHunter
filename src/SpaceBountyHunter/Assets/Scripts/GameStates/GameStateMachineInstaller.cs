using Zenject;

namespace BountyHunter
{
    public sealed class GameStateMachineInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MenuGameState>().AsSingle();
            Container.BindInterfacesAndSelfTo<ShelterGameState>().AsSingle();
            Container.BindInterfacesAndSelfTo<MissionGameState>().AsSingle();
            Container.Bind<GameStateMachine>().To<GameStateMachine>().AsSingle();
        }
    }
}