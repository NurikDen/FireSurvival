using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFly : MonoBehaviour
{
    public GameObject iskra;
    public GameObject thunder;
     void FixedUpdate () {
        perespawn();
     }
        void perespawn (){
if (thunder.transform.localScale.y >= 8.97f && thunder.transform.localScale.y <= 9f ){
            iskra = Instantiate(iskra, new Vector2(thunder.transform.position.x,-4f),Quaternion.identity);
             }
        }
    
     
     
}

