using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePlant : MonoBehaviour
{
    public GameObject objectPlant;
    private PlaceIndicator placeIndicator;
    private GameObject objectToPlace;
    // Start is called before the first frame update
    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }

     public void InstantiateObject()
    {
        Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
    }

    public void ClickToPlacePlant()
    {
        objectToPlace = objectPlant;
        InstantiateObject();
    }

}
