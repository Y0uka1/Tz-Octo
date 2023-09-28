using System.Collections.Generic;
using Naninovel;
using Services;
using UnityEngine;
using UnityEngine.UI;

namespace Views.Map
{
    public class MapView:MonoBehaviour
    {
        [SerializeField] private Button restaurantButton;
        [SerializeField] private Button shoppingDistrictButton;
        [SerializeField] private Button residentialAreaButton;
        [SerializeField] private List<MapLocationQuestMarkVo> locationsQuestMarks;

        public Button RestaurantButton => restaurantButton;

        public Button ShoppingDistrictButton => shoppingDistrictButton;

        public Button ResidentialAreaButton => residentialAreaButton;

        public void OnShow()
        {
            var activeQuests = Engine.GetService<QuestLineService>().GetLocationsWithQuests();
            foreach (var item in locationsQuestMarks)
            {
                item.questMarkImage.enabled = activeQuests.Contains(item.LocationName);
            }
        }

        public void OnHide()
        {
            foreach (var item in locationsQuestMarks)
                item.questMarkImage.enabled = false;
        }
    }
}