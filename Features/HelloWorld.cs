using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace BannerlordPlayground.Features
{
    public class HelloWorld
    {
        public void OnSubModuleLoad()
        {
            InformationMessage message = new InformationMessage("Hello World from BannerlordPlayground!");

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