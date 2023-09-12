using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteDown : MonoBehaviour
{
private float fallspeed=0;
public GameObject gameObject;
    void Update() {
          if(WoodWasteScript.x == 5f && gameObject.transform.position.y > -3.5f){
   fallspeed= Random.Range(1f,3.5f);
    if(Player.lose == false && Player.onpause == false){
  transform.position -= new Vector3(fallspeed * Time.deltaTime, fallspeed* Time.deltaTime,0);
    }
  transform.Rotate(0, 0, 0.5f);
  StartCoroutine(Fly());
      }
      else if (WoodWasteScript.x==-5f && gameObject.transform.position.y > -3.5f){
         fallspeed= Random.Range(1f,3.5f);
          if(Player.lose == false && Player.onpause == false){
  transform.position -= new Vector3(-fallspeed * Time.deltaTime, fallspeed* Time.deltaTime,0);
          }
  transform.Rotate(0, 0, -0.5f);
  StartCoroutine(Fly());
      }
    }
    IEnumerator Fly () {
        yield  return new WaitForSeconds (3f);
        transform.position += new Vector3(-fallspeed * Time.deltaTime, fallspeed* Time.deltaTime,0);
    }

    
    }
    
    //  public int randomWithTwoNumber(int first, int second)
    // {
    //     int[] arr = new int[2] { first, second};
    //     int rand = Random.Range(0, 2);
 
    //     return arr[rand];
    // }

