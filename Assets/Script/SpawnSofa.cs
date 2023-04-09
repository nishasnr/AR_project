using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSofa : MonoBehaviour
{
    public GameObject sofaPrefab;
    public Transform spawnPoint;

    public void Spawn()
    {
        GameObject sofa = Instantiate(sofaPrefab, spawnPoint.position, spawnPoint.rotation);
        sofa.GetComponent<ChangeColor>().Change();
        // Raycast from the screen to the world
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // Spawn the sofa at the hit point
            Instantiate(sofaPrefab, hit.point, Quaternion.identity);
        }
    }
}