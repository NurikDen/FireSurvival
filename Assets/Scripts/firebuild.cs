using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebuild : MonoBehaviour
{
    
    void Start()
    {
       StartCoroutine(build()); 
    }
    IEnumerator build(){
        while(transform.localScale.x<2f && transform.localScale.y<2f){
        yield return new WaitForSeconds (10f);
          transform.localScale = new Vector3(transform.localScale.x*1.2f, transform.localScale.y*1.2f, transform.localScale.z*1.2f);
          
        }
        
}
    }

