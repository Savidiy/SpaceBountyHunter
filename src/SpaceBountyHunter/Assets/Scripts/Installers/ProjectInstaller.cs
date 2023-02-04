using Zenject;

namespace BountyHunter
{
    public sealed class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BootstrapInstaller.Install(Container);
            ProgressInstaller.Install(Container);
            GameStateMachineInstaller.Install(Container);
        }
    }
}