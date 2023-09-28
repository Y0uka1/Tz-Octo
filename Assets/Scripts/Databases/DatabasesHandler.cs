using Databases.QuestLines;
using UnityEngine;

namespace Databases
{
    public class DatabasesHandler:MonoBehaviour
    {
        [SerializeField] private QuestLinesDatabase questLinesDatabase;

        public QuestLinesDatabase QuestLinesDatabase => questLinesDatabase;
    }
}