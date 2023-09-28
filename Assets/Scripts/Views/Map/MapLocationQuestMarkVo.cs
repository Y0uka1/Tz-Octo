using System;
using Databases.Enums;
using UnityEngine.UI;

namespace Views.Map
{
    [Serializable]
    public class MapLocationQuestMarkVo
    {
        public ELocationName LocationName;
        public Image questMarkImage;
    }
}