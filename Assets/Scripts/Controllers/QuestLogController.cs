using Databases.QuestLineDescriptions;
using Naninovel;
using Services;
using UnityEngine;
using Views.QuestLog;

namespace Controllers
{
    public class QuestLogController : MonoBehaviour
    {
        [SerializeField] private QuestLogView questLogView;
        [SerializeField] private QuestLineDescriptionDatabase questLineDescriptionDatabase;

        public void OnShow()
        {
            var questService = Engine.GetService<QuestLineService>();
            foreach (var quest in questService.ActiveQuests)
            {
                var descriptions = questLineDescriptionDatabase.GetByName(quest.Key);
                var itemView = questLogView.QuestLogItemCollection.Add();
                itemView.SetQuestName(descriptions.QuestLineNameDescription);
                foreach (var part in descriptions.parts)
                {
                    if(part.Order>quest.Value)
                        break;
                    var partItemView = itemView.PartItemCollection.Add();
                    partItemView.SetView(part.Description, quest.Value > part.Order);
                }
            }
        }

        public void OnHide()
        {
            questLogView.QuestLogItemCollection.Clear();
        }
    }
}