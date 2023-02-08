using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject starttext;
    void Start()
    {
        
        if(Input.GetMouseButtonDown(0)){
            starttext.SetActive(false);
            SceneManager.LoadScene("SampleScene");
        }
    }

    
}
