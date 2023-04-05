using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceChair : MonoBehaviour
{   
    public GameObject objectChair;
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

    public void ClickToPlaceChair()
    {
        objectToPlace = objectChair;
        InstantiateObject();
    }
}