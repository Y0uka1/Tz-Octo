using UnityEngine;

namespace Views.QuestLog
{
    public class QuestLogView:MonoBehaviour
    {
        [SerializeField] private QuestLogItemCollection questLogItemCollection;

        public QuestLogItemCollection QuestLogItemCollection => questLogItemCollection;
    }
}