using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.MeshGeneration.Modifiers;
using Mapbox.Unity.Utilities;
using Mapbox.Unity.MeshGeneration.Filters;
using UnityEngine.UI;

/*public enum LocationPrefabCategories
{

    None = 0,
    AnyCategory = ~0,
    ArtsAndEntertainment = 1 << 0,
    Food = 1 << 1,
    Nightlife = 1 << 2,
    OutdoorsAndRecreation = 1 << 3,
    Services = 1 << 4,
    Shops = 1 << 5,
    Transportation = 1 << 6
}*/

namespace Mapbox.Unity.Map
{
    public class FilterPlaceType : MonoBehaviour
    {
        AbstractMap am;
        TapPlace tp;
        VectorLayerProperties vlp;

        GameObject filterScreenBtn;
        //GameObject isFilterFood;
        //GameObject isFilterArts;
        //GameObject POIArtsAndEntertainment;

        //public LocationPrefabCategories LPC;

        public Toggle artsToggle;
        public Toggle foodToggle;
        public Toggle nightlifeToggle;
        public Toggle outdoorToggle;
        public Toggle servicesToggle;
        public Toggle shopsToggle;
        public Toggle transportToggle;

        public GameObject POIArts;
        public GameObject POIFood;
        public GameObject POINightlife;
        public GameObject POIOutdoors;
        public GameObject POIServices;
        private GameObject POIShops = GameObject.Find("POIShops");
        public GameObject POITransport;

        /*int AnE = (int)LocationPrefabCategories.ArtsAndEntertainment;
        int Food = (int)LocationPrefabCategories.Food;
        int Nightlife = (int)LocationPrefabCategories.Nightlife;
        int Outdoor = (int)LocationPrefabCategories.OutdoorsAndRecreation;*/

        //bool FilterAnEToggle = false;

        //LocationPrefabCategoryOptions LPCO;

        //Mapbox Map

        //public LocationPrefabFindBy findByType = LocationPrefabFindBy.MapboxCategory;
        // Start is called before the first frame update
        void Start()
        {
            //am.GetComponent<AbstractMap>();
            //LPC = LocationPrefabCategories.AnyCategory;
            //LPC = LocationPrefabCategories.ArtsAndEntertainment;
            //LPC = LocationPrefabCategories.Food;
            //LPC = LocationPrefabCategories.Nightlife;
            //LPC = LocationPrefabCategories.OutdoorsAndRecreation;

            //filterScreenBtn = GameObject.Find("FilterScreenBtn");
            //foodToggle = foodToggle.GetComponent<Toggle>();  //USING THIS***
            //artsToggle = artsToggle.GetComponent<Toggle>();  //USING THIS***

            //POIArtsAndEntertainment = GameObject.Find("POIArts&Entertainment");
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void FilterArtsAndEntertainment()
        {
            /*if ((AnE) != (int)LocationPrefabCategories.None)
            {
                Debug.Log("Filter AnE Clicked");
                AnE = (int)LocationPrefabCategories.ArtsAndEntertainment;
                Food = (int)LocationPrefabCategories.None;
                Nightlife = (int)LocationPrefabCategories.None;
                Outdoor = (int)LocationPrefabCategories.None;
            }*/

            /*if (FilterAnEToggle == false)
            {
                POIArtsAndEntertainment.SetActive(false);
            }
            else if (FilterAnEToggle == true)
            {
                POIArtsAndEntertainment.SetActive(true);
            }
            */


            /*if (artsToggle.isOn == true)
            {
                LPC = LocationPrefabCategories.ArtsAndEntertainment;
                Debug.Log("Filter Arts Clicked");
            }
            else if (artsToggle.isOn == false)
            {
                LPC = LocationPrefabCategories.AnyCategory;
            }*/


        }

        public void FilterFood()
        {
            //Debug.Log("Filter Button Clicked!");
            //Destroy(gameObject);

            /*if ((Food) == (int)LocationPrefabCategories.None)
            {
                Debug.Log("Filter Food Clicked");
                //AnE = (int)LocationPrefabCategories.None;
                Food = (int)LocationPrefabCategories.Food;
                //Nightlife = (int)LocationPrefabCategories.None;
                //Outdoor = (int)LocationPrefabCategories.None;
            }*/

            //LPCO = LocationPrefabCategoryOptions.GetCategoryFromMakiTag;
            //LPCEnum = LocationPrefabCategories.ArtsAndEntertainment;
            //LocationPrefabCategories.ArtsAndEntertainment

            /*if (isFilterFood.GetComponent<Toggle>().isOn == true)
            {
                LPC = LocationPrefabCategories.Food;
                Debug.Log("Filter Food Clicked");
            }*/

            if (foodToggle.isOn == true)
            {
                //LPC = LocationPrefabCategories.Food;
                //am.GetComponent<AbstractMap>().

                //vlp.sourceOptions.Id = MapboxDefaultVector.GetParameters(VectorSourceType.None).Id;
                //vlp.GetType.FilterFood;

                //am.GetComponent<AbstractMap>().VectorData.SpawnPrefabByCategory(POIFood);
                //POIFood.SetActive(true);
                //am.GetComponent<AbstractMap>().VectorData.RemovePointsOfInterestSubLayerWithName("Food");

                /*if(am.GetComponent<AbstractMap>().VectorData.IsLayerActive == true)
                {
                    am.GetComponent<AbstractMap>().VectorData.RemovePointsOfInterestSubLayerWithName("Food");
                }*/

                //am.GetComponent<AbstractMap>().VectorData.AddPointsOfInterestSubLayer.
                //am.GetComponent<AbstractMap>().VectorData.FindPointsofInterestSubLayerWithName("Food");
                //am.GetComponent<AbstractMap>().VectorData.GetPointsOfInterestSubLayerAtIndex(1);
                am.GetComponent<AbstractMap>().VectorData.SpawnPrefabByCategory(POIFood);
                am.GetComponent<AbstractMap>().VectorData.SpawnPrefabByCategory(POIFood, LocationPrefabCategories.Food,  5);
                //am.GetComponent<AbstractMap>().MapVisualizer.ActiveTiles.
                    //LayerProperty.sourceType == VectorSourceType.



                //am.GetComponent<AbstractMap>().VectorData.AddPointsOfInterestSubLayer();
                //am.GetComponent<AbstractMap>().VectorData.points
                //am.GetComponent<AbstractMap>().VectorData.FindPointsofInterestSubLayerWithName.POIFood;
                //am.GetComponent<AbstractMap>().VectorData.GetPointsOfInterestSubLayerByQuery<POIFood>;


                //am.GetComponent<AbstractMap>().
                //am.GetComponent<AbstractMap>().VectorData.GetPointsOfInterestSubLayerAtIndex(1);
                //am.GetComponent<AbstractMap>().VectorData.

                //am.GetComponent<AbstractMap>().VectorData.SpawnPrefabByCategory();
                Debug.Log("Filter Food Clicked");
            }
            else if (foodToggle.isOn == false)
            {
                //am.GetComponent<AbstractMap>().VectorData.SpawnPrefabByCategory.FilterFood = false;
                //am.GetComponent<AbstractMap>().VectorData.GetAllPointsOfInterestSubLayers;
                //am.GetComponent<AbstractMap>().VectorData.SpawnPrefabByCategory(POIFood);

                //vlp.sourceOptions.Id = MapboxDefaultVector.GetParameters(VectorSourceType.None).Id;
                //LPC = LocationPrefabCategories.AnyCategory;

                //am.GetComponent<AbstractMap>().MapVisualizer
                //am.GetComponent<AbstractMap>().VectorData.FindPointsofInterestSubLayerWithName("Food");
            }
        }



        public void FilterNightlife()
        {
            if (nightlifeToggle.isOn == true)
            {
                am.GetComponent<AbstractMap>().VectorData.SpawnPrefabByCategory(POINightlife);

                Debug.Log("Filter Food Clicked");
            }
            else if (nightlifeToggle.isOn == false)
            {

            }
        }

        public void FilterShops()
        {
            if (shopsToggle.isOn == true)
            {
                am.GetComponent<AbstractMap>().VectorData.SpawnPrefabByCategory(POIShops);

                Debug.Log("Filter Food Clicked");
            }
            else if (shopsToggle.isOn == false)
            {

            }
        }
    }

    

    /*public void FilterOutdoor()
    {
        if ((Outdoor) != (int)LocationPrefabCategories.None)
        {
            Debug.Log("Filter AnE Clicked");
            AnE = (int)LocationPrefabCategories.None;
            Food = (int)LocationPrefabCategories.None;
            Nightlife = (int)LocationPrefabCategories.None;
            Outdoor = (int)LocationPrefabCategories.OutdoorsAndRecreation;
        }
    }*/
}

