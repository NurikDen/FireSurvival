using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateFly : MonoBehaviour
{
    public GameObject spark;
    public GameObject thunder;
    private List<GameObject> _tmpSpark;

    void FixedUpdate()
    {
        perespawn();
    }

    void perespawn()
    {
        if (thunder.transform.localScale.y >= 8.97f && thunder.transform.localScale.y <= 9f)
        {
            var tmpSpark = Instantiate(spark, new Vector2(thunder.transform.position.x, -4f), Quaternion.identity);
            tmpSpark.transform.localScale = Vector3.one / 2.5f;
        }
    }
}
        
        
        
    
     
     


