using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenzinDown : MonoBehaviour
{
[SerializeField] private float fallspeed;
public GameObject gameObject;

    void Update() {
         if(Player.lose == false && Player.onpause == false){
    transform.position -= new Vector3(0,fallspeed * Time.deltaTime ,0);
         }
       
    }
    
 
}
