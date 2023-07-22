using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopsRecord : MonoBehaviour
{
    [SerializeField] TextMesh HighScore;   
    void Update()
    {
        HighScore.text = PlayerPrefs.GetInt("score")+" Joules";
    }
}
