using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Play : MonoBehaviour
{ 
    void Update()   
    {
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene ("SampleScene");
          

        }
     }
     

    
}
