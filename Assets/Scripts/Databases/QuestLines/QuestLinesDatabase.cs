using System;
using System.Collections.Generic;
using Databases.Enums;
using Naninovel;
using UnityEngine;

namespace Databases.QuestLines
{
    [CreateAssetMenu(menuName = "Databases/QuestLinesDatabase", fileName = "QuestLinesDatabase")]
    public class QuestLinesDatabase : ScriptableObject
    {
        [SerializeField] private List<QuestLineVo> questLinesCollection;

        public QuestLineVo GetQuestByName(EQuestLineName questLineName)
        {
            for (int i = 0; i < questLinesCollection.Count; i++)
            {
                if (questLinesCollection[i].questLineName != questLineName)
                    continue;
                return questLinesCollection[i];
            }

            throw new Exception($"[QuestLinesDatabase] Item with questLineName \"{questLineName}\" not found");
        }

        public Script GetScriptByQuestPart(EQuestLineName questLineName, int partOrder)
        {
            for (int i = 0; i < questLinesCollection.Count; i++)
            {
                if (questLinesCollection[i].questLineName != questLineName)
                    continue;
                for (int j = 0; j < questLinesCollection[i].questLineParts.Count; j++)
                {
                    if (questLinesCollection[i].questLineParts[j].Order != partOrder)
                        continue;
                    return questLinesCollection[i].questLineParts[j].naniScript;
                }

                throw new Exception(
                    $"[QuestLinesDatabase] Item with partOrder \"{partOrder}\" " +
                    $"not found in item with questLineName \"{questLineName}\"");
            }

            throw new Exception($"[QuestLinesDatabase] Item with questLineName \"{questLineName}\" not found");
        }
        
        public QuestLinePartVo GetQuestPart(EQuestLineName questLineName, int partOrder)
        {
            for (int i = 0; i < questLinesCollection.Count; i++)
            {
                if (questLinesCollection[i].questLineName != questLineName)
                    continue;
                for (int j = 0; j < questLinesCollection[i].questLineParts.Count; j++)
                {
                    if (questLinesCollection[i].questLineParts[j].Order != partOrder)
                        continue;
                    return questLinesCollection[i].questLineParts[j];
                }

                throw new Exception(
                    $"[QuestLinesDatabase] Item with partOrder \"{partOrder}\" " +
                    $"not found in item with questLineName \"{questLineName}\"");
            }

            throw new Exception($"[QuestLinesDatabase] Item with questLineName \"{questLineName}\" not found");
        }
    }
}