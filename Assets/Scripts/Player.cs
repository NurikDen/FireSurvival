using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject restart;
    public AudioSource soundtrack;
    public static bool onpause = true;
    public GameObject firer;
    public GameObject waste;
    

    void Awake()
    {
        lose = false;
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "water")
        {
           firer.transform.localScale = new Vector3(firer.transform.localScale.x / 1.3f, firer.transform.localScale.y / 1.3f,
                firer.transform.localScale.z / 1.3f);
                transform.localScale = new Vector3(transform.localScale.x / 1.3f, transform.localScale.y / 1.3f,
                transform.localScale.z / 1.3f);
                if (transform.localScale.x <= 0.2f && transform.localScale.y <= 0.2f)
            {
                lose = true;
                restart.SetActive(true);
                soundtrack.Stop();
                Destroy(gameObject);
            }
            
        }
        else if (other.gameObject.tag == "spark")
        {
              firer.transform.localScale = new Vector3(firer.transform.localScale.x * 1.2f, firer.transform.localScale.y * 1.2f,
                firer.transform.localScale.z * 1.2f);

            transform.localScale = new Vector3(transform.localScale.x * 1.2f, transform.localScale.y * 1.2f,
                transform.localScale.z * 1.2f);
        }
        else if (other.gameObject.tag == "brunch"){
             firer.transform.localScale = new Vector3(firer.transform.localScale.x * 1.5f, firer.transform.localScale.y * 1.5f,
                firer.transform.localScale.z * 1.5f);

            transform.localScale = new Vector3(transform.localScale.x * 1.5f, transform.localScale.y * 1.5f,
                transform.localScale.z * 1.5f);
            other.gameObject.SetActive(false);
        
        }
         else if (other.gameObject.tag == "firer"){
             firer.transform.localScale = new Vector3(firer.transform.localScale.x / 3, firer.transform.localScale.y / 3,
                firer.transform.localScale.z / 3);

            transform.localScale = new Vector3(transform.localScale.x / 3, transform.localScale.y / 3,
                transform.localScale.z / 3);
                if (transform.localScale.x <= 0.2f && transform.localScale.y <= 0.2f)
            {
                lose = true;
                restart.SetActive(true);
                soundtrack.Stop();
                Destroy(gameObject);
            }
            
        }
        else if (other.gameObject.tag == "benzin")
        {
             firer.transform.localScale = new Vector3(firer.transform.localScale.x * 1.2f, firer.transform.localScale.y * 1.2f,
                firer.transform.localScale.z * 1.2f);

              transform.localScale = new Vector3(transform.localScale.x * 1.2f, transform.localScale.y * 1.2f,
                transform.localScale.z * 1.2f);
                
        }  
}
}