using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    private void OnMouseDown()
    {
         SceneManager.LoadScene ("Shop");
    }
}
