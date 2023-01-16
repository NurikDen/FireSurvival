using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    public static bool lose = false;
    public GameObject restart;
    public AudioSource soundtrack;
    void Awake() {
        lose = false;
    }
     void OnTriggerEnter2D(Collider2D other) {
     if (other.gameObject.tag == "water"){
        transform.localScale = new Vector3(transform.localScale.x/1.5f, transform.localScale.y/1.5f, transform.localScale.z/1.5f);
    if (transform.localScale.x <= 0.2f && transform.localScale.y <= 0.08f ){
        lose = true;
        restart.SetActive(true);
        soundtrack.Stop();
        Destroy(gameObject);
    }
     }           
    }  
    
}



