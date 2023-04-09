using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material[] materials;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    public void Change()
    {
        int index = Random.Range(0, materials.Length);
        renderer.material = materials[index];
    }
}