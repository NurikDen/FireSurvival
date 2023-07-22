using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{           
    void Update()   
    {
        if(Input.GetMouseButtonDown(0)){
          SceneManager.LoadScene ("SampleScene");
        }
     }
}
