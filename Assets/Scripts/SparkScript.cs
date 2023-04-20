using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkScript : MonoBehaviour
{
    [SerializeField] private float fallspeed;
    
    public GameObject spark;
    
    void Update()
    {
        transform.position += new Vector3(0, fallspeed * Time.deltaTime, 0);
        if (transform.position.y > 5)
        { 
            Destroy(gameObject);
        }
    }

    


}
