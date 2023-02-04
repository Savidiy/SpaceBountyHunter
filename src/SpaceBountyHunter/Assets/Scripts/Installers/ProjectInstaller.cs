using Zenject;

namespace BountyHunter
{
    public sealed class ProjectInstaller : MonoInstaller
    {
        public Settings Settings;
        
        public override void InstallBindings()
        {
            BootstrapInstaller.Install(Container);
            ProgressInstaller.Install(Container);
            GameStateMachineInstaller.Install(Container);
            MissionInstaller.Install(Container);

            Container.BindInterfacesAndSelfTo<TickInvoker>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerInput>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerShipSettings>().AsSingle();
            Container.BindInterfacesAndSelfTo<ShipMover>().AsSingle();
            Container.Bind<Settings>().FromInstance(Settings).AsSingle();
        }
    }
}