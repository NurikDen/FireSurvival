using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireload : MonoBehaviour

{public GameObject fire;
    void Start()
    {
        StartCoroutine(firer());
    }

    IEnumerator firer () {
        yield return new WaitForSeconds (5f);
        fire.SetActive(true);
    }

}
