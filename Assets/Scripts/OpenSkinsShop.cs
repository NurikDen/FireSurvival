using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSkinsShop : MonoBehaviour
{
    public GameObject skins;
    public GameObject themes;
    private void OnMouseDown()
    {
        themes.SetActive(false);
        skins.SetActive(true);
    }
}
