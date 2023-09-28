using System;
using Databases.Enums;
using Naninovel;
using UnityEngine;

namespace Databases.QuestLines
{
    [Serializable]
    public class QuestLinePartVo
    {
        [SerializeField] public int Order;
        [SerializeField] public ELocationName questLocation;
        [SerializeField] public Script naniScript;
    }
}