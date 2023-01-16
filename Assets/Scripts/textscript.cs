using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class textscript : MonoBehaviour
{
    public TextMesh timertext;
    private int c = 0;
    void Start()
    {
      StartCoroutine(textscriptt());
    }
     IEnumerator textscriptt () {
      while (!Player.lose) {
            c++;
            yield return new WaitForSeconds (1f);  
            timertext.text = c.ToString(); 
        }
}}
