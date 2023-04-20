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

    void Awake()
    {
        lose = false;
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "water")
        {
            firer.transform.localScale = new Vector3(firer.transform.localScale.x / 1.5f, firer.transform.localScale.y / 1.5f,
                firer.transform.localScale.z / 1.5f);
            transform.localScale = new Vector3(transform.localScale.x / 1.5f, transform.localScale.y / 1.5f,
                transform.localScale.z / 1.5f);
            if (firer.transform.localScale.x <= 0.2f && firer.transform.localScale.y <= 0.2f)
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
        }
    }
}