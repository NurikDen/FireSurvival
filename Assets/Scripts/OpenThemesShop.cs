using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenThemesShop : MonoBehaviour
{
     public GameObject skins;
    public GameObject themes;
    private void OnMouseDown()
    {
        themes.SetActive(true);
        skins.SetActive(false);
    }
}
