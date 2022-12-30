using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    public static bool lose = false;
    public GameObject restart;
    void Awake() {
        lose = false;
    }
     void OnTriggerEnter2D(Collider2D other) {
     if (other.gameObject.tag == "water"){
        lose = true;   
        restart.SetActive(true);
        


     }
            
    }  
}
