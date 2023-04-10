
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageButton : MonoBehaviour
{
    public GameObject DelBut;
    // Start is called before the first frame update
    void Start()
    {
        DelBut.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        bool flag = false;
        foreach (GameObject gameObj in GameObject.FindGameObjectsWithTag("DeleteOption"))
        {
            if (gameObj.activeSelf)
            {
                flag = true;
            }


        }

        if (flag)
        {
            DelBut.SetActive(true);
        }
        else
        {
            DelBut.SetActive(false);
        }

    }

    public void OnButtonPress()
    {
        foreach (GameObject gameObj in GameObject.FindGameObjectsWithTag("DeleteOption"))
        {
            if (gameObj.activeSelf)
            {
                Destroy(gameObj.transform.parent.gameObject);
            }


        }
    }
}

