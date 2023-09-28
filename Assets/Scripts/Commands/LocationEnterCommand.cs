using System;
using Databases.Enums;
using Naninovel;
using Services;

namespace Commands
{
    [CommandAlias("LocationEnter")]
    public class LocationEnterCommand:Command
    {
        public StringParameter LocationName;
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (!Assigned(LocationName))
                throw new Exception("[LocationEnterCommand] Missing parameter value");
            Enum.TryParse<ELocationName>(LocationName, out var locationName);
            Engine.GetService<QuestLineService>().OnLocationEnter(locationName);
            return UniTask.CompletedTask;
        }
    }
}