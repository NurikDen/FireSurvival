using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iskrascript : MonoBehaviour
{
    [SerializeField]
    private float fallspeed;
    public GameObject iskra;
    void Update()
    {
         transform.position += new Vector3(0,fallspeed * Time.deltaTime ,0);
    }
    
}
