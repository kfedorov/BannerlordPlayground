using BannerlordPlayground.Features;
using TaleWorlds.MountAndBlade;

namespace BannerlordPlayground
{
    public class BannerlordPlaygroundSubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            var helloWorld = new HelloWorld();
            helloWorld.OnSubModuleLoad();
        }
    }
}
