using UnityEngine;
using UnityEngine.UI;

public class DisplayMenu : MonoBehaviour
{
    public GameObject panelToHide;

    public void ShowPanel()
    {
        if (panelToHide != null)
        {
            bool isActive = panelToHide.activeSelf;
            panelToHide.SetActive(!isActive);
        }
    }
}
