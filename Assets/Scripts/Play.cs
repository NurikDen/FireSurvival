using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Play : MonoBehaviour
{
   public GameObject textObjects; 
   public GameObject nameText;
   //public GameObject shopbutton;
   // public GameObject tablebutton;
    private void OnMouseDown()
    {
        Player.onpause = false;
        if (Player.onpause==false)
        {
            textObjects.SetActive(true);
            nameText.SetActive(false);
        //    shopbutton.SetActive(false);
        //    tablebutton.SetActive(false);
        }
    }
}
