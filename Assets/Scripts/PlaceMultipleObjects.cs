using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMultipleObjects : MonoBehaviour
{
    private PlaceIndicator placeIndicator;

    public GameObject objectChair;
    public GameObject objectSofa;
    public GameObject objectPlant;

    private GameObject objectToPlace;

    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }


    public void InstantiateObject()
    {
        Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
    }

    public void ClickToPlaceChair()
    {
        objectToPlace = objectChair;
        InstantiateObject();
    }

    public void ClickToPlaceSofa()
    {
        objectToPlace = objectSofa;
        InstantiateObject();
    }

    public void ClickToPlacePlant()
    {
        objectToPlace = objectPlant;
        InstantiateObject();
    }
}
