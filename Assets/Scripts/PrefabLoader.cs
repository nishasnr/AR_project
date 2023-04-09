using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
using TMPro;

public class PrefabLoader : MonoBehaviour
{
    //prefabs
    [SerializeField] private GameObject[] bathPrefabs;
    [SerializeField] private GameObject[] bedPrefabs;
    [SerializeField] private GameObject[] cabinetPrefabs;
    [SerializeField] private GameObject[] chairPrefabs;
    [SerializeField] private GameObject[] floorPrefabs;
    [SerializeField] private GameObject[] kitchenPrefabs;
    [SerializeField] private GameObject[] lightPrefabs;
    [SerializeField] private GameObject[] electronicPrefabs;
    [SerializeField] private GameObject[] mirrorPrefabs;
    [SerializeField] private GameObject[] plantPrefabs;
    [SerializeField] private GameObject[] sofaPrefabs;
    [SerializeField] private GameObject[] tablePrefabs;
    [SerializeField] private GameObject[] wallartPrefabs;

    //AR Placement Interactable reference
    private ARPlacementInteractable AR_Interactable;

    //Selected prefab
    public GameObject selectedPrefab;
    public TMP_Text selectedText;


    //Awake
    private void Awake()
    {
        AR_Interactable = this.gameObject.GetComponent<ARPlacementInteractable>();
    }

    private void Update()
    {
        
    }

    //to keep track of selection menu state
    public void MenuOpen(bool open)
    {
        AR_Interactable.enabled = !open;
    }

    #region prefab selection events
    //select a bath prefab
    public void SelectBath(int index)
    {
        //change selected prefab
        selectedPrefab = bathPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a bed prefab
    public void SelectBed(int index)
    {
        //change selected prefab
        selectedPrefab = bedPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a cabinet/rack prefab
    public void SelectCabinet(int index)
    {
        //change selected prefab
        selectedPrefab = cabinetPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a chair prefab
    public void SelectChair(int index)
    {
        //change selected prefab
        selectedPrefab = chairPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a floor prefab
    public void SelectFloor(int index)
    {
        //change selected prefab
        selectedPrefab = floorPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a kitchen prefab
    public void SelectKitchen(int index)
    {
        //change selected prefab
        selectedPrefab = kitchenPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a light prefab
    public void SelectLight(int index)
    {
        //change selected prefab
        selectedPrefab = lightPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a electronic prefab
    public void SelectElectronic(int index)
    {
        //change selected prefab
        selectedPrefab = electronicPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a mirror prefab
    public void SelectMirror(int index)
    {
        //change selected prefab
        selectedPrefab = mirrorPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a plant prefab
    public void SelectPlant(int index)
    {
        //change selected prefab
        selectedPrefab = plantPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a sofa prefab
    public void SelectSofa(int index)
    {
        //change selected prefab
        selectedPrefab = sofaPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a table prefab
    public void SelectTable(int index)
    {
        //change selected prefab
        selectedPrefab = tablePrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }

    //select a wall art prefab
    public void SelectWallArt(int index)
    {
        //change selected prefab
        selectedPrefab = wallartPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }
    #endregion
}
