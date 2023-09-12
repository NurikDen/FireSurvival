using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
[SerializeField] private float fallspeed;
public GameObject gameObject;

    void Update() {
        if(Player.lose == false && Player.onpause == false){
 transform.position -= new Vector3(0,fallspeed * Time.deltaTime ,0);
        }
   
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            gameObject.SetActive(false);       
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            gameObject.SetActive(false);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            gameObject.SetActive(false);

        }
    }
    
 
}
