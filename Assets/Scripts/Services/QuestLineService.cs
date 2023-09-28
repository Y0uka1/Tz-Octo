using System.Collections.Generic;
using Databases;
using Databases.Enums;
using Databases.QuestLines;
using Naninovel;
using UnityEngine;

namespace Services
{
    [InitializeAtRuntime]
    public class QuestLineService : IEngineService
    {
        private IScriptPlayer scriptPlayer;
        private Dictionary<EQuestLineName, int> activeQuests = new Dictionary<EQuestLineName, int>();

        public Dictionary<EQuestLineName, int> ActiveQuests => activeQuests;

        private QuestLinesDatabase questLinesDatabase;

        public void UpdateQuestLine(EQuestLineName questLineName)
        {
            var currentQuestOrder = activeQuests[questLineName];
            var questLine = questLinesDatabase.GetQuestByName(questLineName);
            if (questLine.questLineParts[questLine.questLineParts.Count - 1].Order > currentQuestOrder)
            {
                activeQuests[questLineName]++;
                return;
            }

            activeQuests.Remove(questLineName);
        }

        public List<ELocationName> GetLocationsWithQuests()
        {
            var locationsList = new List<ELocationName>();
            foreach (var activeQuest in ActiveQuests)
            {
                locationsList.Add(questLinesDatabase.GetQuestPart(activeQuest.Key, activeQuest.Value).questLocation);
            }

            return locationsList;
        }

        public void AddQuestLine(EQuestLineName questLineName)
        {
            activeQuests.Add(questLineName, 1);
        }

        public void OnLocationEnter(ELocationName locationName)
        {
            foreach (var quest in activeQuests)
            {
                var questData = questLinesDatabase.GetQuestPart(quest.Key, quest.Value);
                if(questData.questLocation != locationName)
                    continue;
                scriptPlayer.Play(questData.naniScript);
            }
        }

        public UniTask InitializeServiceAsync()
        {
            questLinesDatabase = GameObject.FindObjectOfType<DatabasesHandler>().QuestLinesDatabase;
            scriptPlayer = Engine.GetService<IScriptPlayer>();
            return UniTask.CompletedTask;
        }

        public void ResetService()
        {
        }

        public void DestroyService()
        {
        }
    }
}