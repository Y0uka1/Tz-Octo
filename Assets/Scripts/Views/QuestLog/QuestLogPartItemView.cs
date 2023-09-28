using TMPro;
using UnityEngine;

namespace Views.QuestLog
{
    public class QuestLogPartItemView:MonoBehaviour
    {
        [SerializeField] private TMP_Text questDescription;
        [SerializeField] private GameObject checkMark;

        public void SetView(string description, bool isCompleted)
        {
            questDescription.text = description;
            checkMark.SetActive(isCompleted);
        }
    }
}