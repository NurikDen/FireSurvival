using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject restart;
    public static bool onpause = false;
    public GameObject firer;
    public GameObject waste;
    public static float waterheel=1.3f;
    public static float firerheel=3f;
    public static float brunchhp=1.5f;
    public static float benzinhp=1.2f;
    public static float sparkhp=1.2f;
//     public AudioSource audioSource1;
// public AudioSource audioSource2;
    

    void Awake()
    {
        lose = false;
        onpause = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {    if (other.gameObject.tag == "firer"){
             firer.transform.localScale = new Vector3(firer.transform.localScale.x / firerheel, firer.transform.localScale.y / firerheel,
                firer.transform.localScale.z / firerheel);

            transform.localScale = new Vector3(transform.localScale.x / firerheel, transform.localScale.y / firerheel,
                transform.localScale.z / firerheel);
                if (transform.localScale.x <= 0.2f && transform.localScale.y <= 0.2f)
            {
                lose = true;
                restart.SetActive(true);
                // audioSource1.Stop();
                // audioSource2.Stop();
                gameObject.SetActive(false);
            }
    }
        else if (other.gameObject.tag == "benzin")
        {
             firer.transform.localScale = new Vector3(firer.transform.localScale.x * benzinhp, firer.transform.localScale.y * benzinhp,
                firer.transform.localScale.z * benzinhp);

              transform.localScale = new Vector3(transform.localScale.x * benzinhp, transform.localScale.y * benzinhp,
                transform.localScale.z * benzinhp);
                 if (transform.localScale.x <= 0.2f && transform.localScale.y <= 0.2f)
            {
                lose = true;
                restart.SetActive(true);
                // audioSource1.Stop();
                // audioSource2.Stop();
                gameObject.SetActive(false);
                
            }
                
        } 
       else if (other.gameObject.tag == "spark")
        {
              firer.transform.localScale = new Vector3(firer.transform.localScale.x * sparkhp, firer.transform.localScale.y * sparkhp,
                firer.transform.localScale.z * sparkhp);

            transform.localScale = new Vector3(transform.localScale.x * sparkhp, transform.localScale.y * sparkhp,
                transform.localScale.z * sparkhp);
                 if (transform.localScale.x <= 0.2f && transform.localScale.y <= 0.2f)
            {
                lose = true;
                restart.SetActive(true);
                // audioSource1.Stop();
                // audioSource2.Stop();
                gameObject.SetActive(false);
                
            }
        }
        else if (other.gameObject.tag == "brunch"){
             firer.transform.localScale = new Vector3(firer.transform.localScale.x * brunchhp, firer.transform.localScale.y * brunchhp,
                firer.transform.localScale.z * brunchhp);

            transform.localScale = new Vector3(transform.localScale.x * brunchhp, transform.localScale.y * brunchhp,
                transform.localScale.z * brunchhp);
            other.gameObject.SetActive(false);
             if (transform.localScale.x <= 0.2f && transform.localScale.y <= 0.2f)
            {
                lose = true;
                restart.SetActive(true);
                // audioSource1.Stop();
                // audioSource2.Stop();
                gameObject.SetActive(false);
                
            }
        
        }
        
       
}
void OnTriggerExit2D(Collider2D other)
    {
if (other.gameObject.tag == "water")
        {
           firer.transform.localScale = new Vector3(firer.transform.localScale.x / waterheel, firer.transform.localScale.y / waterheel,
                firer.transform.localScale.z / waterheel);
                transform.localScale = new Vector3(transform.localScale.x / waterheel, transform.localScale.y / waterheel,
                transform.localScale.z / waterheel);  
                 if (transform.localScale.x <= 0.2f && transform.localScale.y <= 0.2f)
            {
                lose = true;
                restart.SetActive(true);
                // audioSource1.Stop();
                // audioSource2.Stop();
                gameObject.SetActive(false);
                
            }
        }
     }

}