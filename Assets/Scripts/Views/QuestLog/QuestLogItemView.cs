using TMPro;
using UnityEngine;

namespace Views.QuestLog
{
    public class QuestLogItemView:MonoBehaviour
    {
        [SerializeField] private TMP_Text questNameText;
        [SerializeField] private QuestLogPartItemCollection partItemCollection;

        public QuestLogPartItemCollection PartItemCollection => partItemCollection;

        public void SetQuestName(string name)
        {
            questNameText.text = name;
        }
    }
}