using System;
using System.Collections.Generic;
using Databases.Enums;

namespace Databases.QuestLineDescriptions
{
    [Serializable]
    public class QuestLineDescriptionVo
    {
        public EQuestLineName QuestLineName;
        public string QuestLineNameDescription;
        public List<QuestLinePartDescriptionVo> parts;
    }
}