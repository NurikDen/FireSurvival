using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
[SerializeField]
private float fallspeed = 3f;
public GameObject gameObject;
    void Update() {
                
            
        transform.position -= new Vector3(0,fallspeed * Time.deltaTime ,0);
        
    }
            
 
 
}
