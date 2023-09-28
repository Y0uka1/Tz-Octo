using System;
using Databases.Enums;
using Naninovel;
using Services;

namespace Commands
{
    [CommandAlias("StartQuest")]
    public class StartQuestCommand:Command
    {
        public StringParameter QuestLineName;
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (!Assigned(QuestLineName))
                throw new Exception("[StartQuestCommand] Missing parameter value");
            Enum.TryParse<EQuestLineName>(QuestLineName, out var questLineName);
            Engine.GetService<QuestLineService>().AddQuestLine(questLineName);
            
            return UniTask.CompletedTask;
        }
    }
}