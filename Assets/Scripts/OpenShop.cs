using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
     void OnMouseDown() {
         SceneManager.LoadScene ("Shop");
     }

}
