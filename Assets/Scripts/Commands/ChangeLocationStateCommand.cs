using System;
using Databases.Enums;
using Naninovel;
using Services;

namespace Commands
{
    [CommandAlias("LocationState")]
    public class ChangeLocationStateCommand:Command
    {
        public StringParameter LocationName;
        public BooleanParameter IsActive;
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (!Assigned(LocationName))
                throw new Exception("[LocationEnterCommand] Missing parameter value");
            Enum.TryParse<ELocationName>(LocationName, out var locationName);
            Engine.GetService<CityMapService>().ChangeLocationState(locationName, IsActive);
            return UniTask.CompletedTask;
        }
    }
}