using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Textscript : MonoBehaviour
{
    [SerializeField]private TextMesh timertext; 
    private int c = 0;
    
    void Start(){
        StartCoroutine(textscriptt());
    }
     IEnumerator textscriptt () {
      while (true) {
          if (!Player.lose || !Player.onpause)
          {
              c++;
              yield return new WaitForSeconds(1f);
              timertext.text = c.ToString();
          }
          else
          {
              yield return null;
          }
      }
}
   
}
