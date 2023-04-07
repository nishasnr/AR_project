using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
using TMPro;

public class PrefabLoader : MonoBehaviour
{
    //prefabs
    [SerializeField] private GameObject[] chairPrefabs;

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

    //select a chair (UI)
    public void SelectChair(int index)
    {
        //change selected prefab
        selectedPrefab = chairPrefabs[index];
        //notify AR placement interactable script of change
        AR_Interactable.placementPrefab = selectedPrefab;
        //update selected text
        selectedText.text = "Current Selection:\n" + selectedPrefab.name;
    }
}
