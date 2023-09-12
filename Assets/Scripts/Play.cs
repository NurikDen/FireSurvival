using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Play : MonoBehaviour
{
   public GameObject textObjects; 
   public GameObject shopbutton;
   public GameObject tablebutton;
   public GameObject pause;
    private void OnMouseDown()
    {
        Player.onpause = false;
        if (Player.onpause==false)
        {
            textObjects.SetActive(true);
           shopbutton.SetActive(false);
           tablebutton.SetActive(false);
           pause.SetActive(true);
        }
    }
}
