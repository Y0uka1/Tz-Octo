using System;
using System.Collections.Generic;
using Databases.Enums;
using UnityEngine;

namespace Databases.QuestLines
{
    [Serializable]
    public class QuestLineVo
    {
        [SerializeField] public EQuestLineName questLineName;
        [SerializeField] public List<QuestLinePartVo> questLineParts;
    }
}