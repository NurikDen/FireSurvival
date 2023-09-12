using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject rectangle;
     private void OnMouseDown()
    {
         Player.onpause = true;
       
        
    }
    void Update(){
        if(Player.onpause==true)
    rectangle.SetActive(true);
    
    else {
        rectangle.SetActive(false);
    }
    }
 
    }
    

