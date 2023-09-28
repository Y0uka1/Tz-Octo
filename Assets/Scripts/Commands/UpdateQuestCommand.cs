using System;
using Databases.Enums;
using Naninovel;
using Services;

namespace Commands
{
    [CommandAlias("UpdateQuest")]
    public class UpdateQuestCommand:Command
    {
        public StringParameter QuestLineName;
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (!Assigned(QuestLineName))
                throw new Exception("[UpdateQuestCommand] Missing parameter value");
            Engine.GetService<QuestLineService>().UpdateQuestLine(EQuestLineName.MainQuest1);
            return UniTask.CompletedTask;
        }
    }
}