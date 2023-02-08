using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderScript : MonoBehaviour
{
    public GameObject thunder;
    void Start () {
        StartCoroutine (ReSpawn ());
    }
    IEnumerator ReSpawn () {
        while (!Player.lose) {
            Instantiate (thunder, new Vector2 (Random.Range (-3f,3f),9f), Quaternion.identity);
            yield return new WaitForSeconds (5f);
        }
    } 
}
