using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour{
    public GameObject water;
    void Start () {
        StartCoroutine (Spawn ());
    }
    IEnumerator Spawn () {
        while (!Player.lose) {
            Instantiate (water, new Vector2 (Random.Range (-2.5f,2.5f),5.9f), Quaternion.identity);
            yield return new WaitForSeconds (2f);
        }
    } 
}
