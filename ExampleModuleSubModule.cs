using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace BannerlordPlayground
{
    public class BannerlordPlaygroundSubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            InformationMessage message = new InformationMessage("Hello from BannerlordPlayground!");

            InitialStateOption initStateOpt = new InitialStateOption(
                "BannerlordPlayground",
                new TextObject("BannerlordPlayground", null),
                9990,
                () => InformationManager.DisplayMessage(message),
                false
            );

            Module.CurrentModule.AddInitialStateOption(initStateOpt);
        }
    }
}
