using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private void OnMouseDown()
    {
         SceneManager.LoadScene ("SampleScene");
    }
}