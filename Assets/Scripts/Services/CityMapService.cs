using Databases.Enums;
using Naninovel;
using UnityEngine;
using Views.Map;

namespace Services
{
    [InitializeAtRuntime]
    public class CityMapService:IEngineService
    {
        private MapView mapView;
        
        public UniTask InitializeServiceAsync()
        {
            mapView = GameObject.FindObjectOfType<MapView>();
            return UniTask.CompletedTask;
        }

        public void ChangeLocationState(ELocationName locationName, bool isActive)
        {
            //Bruh
            if (mapView == null)
                mapView = GameObject.FindObjectOfType<MapView>();
            
            switch (locationName)
            {
                case ELocationName.Restaurant:
                    mapView.RestaurantButton.interactable = isActive;
                    break;
                case ELocationName.ShoppingDistrict:
                    mapView.ShoppingDistrictButton.interactable = isActive;
                    break;
                case ELocationName.ResidentialArea:
                    mapView.ResidentialAreaButton.interactable = isActive;
                    break;
                default:
                    Debug.LogError($"Location with name \"{locationName}\" does not exist");
                    break;
            }
        }

        public void ResetService()
        { }

        public void DestroyService()
        { }
    }
}