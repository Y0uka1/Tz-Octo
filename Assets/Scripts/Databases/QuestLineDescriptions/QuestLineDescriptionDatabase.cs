using System;
using System.Collections.Generic;
using Databases.Enums;
using UnityEngine;

namespace Databases.QuestLineDescriptions
{
    [CreateAssetMenu(menuName = "Databases/QuestLineDescriptionDatabase", fileName = "QuestLineDescriptionDatabase")]
    public class QuestLineDescriptionDatabase:ScriptableObject
    {
        [SerializeField] private List<QuestLineDescriptionVo> collection;

        public QuestLineDescriptionVo GetByName(EQuestLineName questLineName)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if(collection[i].QuestLineName!=questLineName)
                    continue;
                return collection[i];
            }
            throw new Exception($"[QuestLineDescriptionDatabase] Item with questLineName \"{questLineName}\" not found");
        }
    }
}