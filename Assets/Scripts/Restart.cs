using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{           public GameObject fire;
public GameObject firer;
    void Update()   
    {
        if(Input.GetMouseButtonDown(0)){
          Player.lose = false;
          fire.transform.localScale = new Vector3(0.3f, 0.3f,
                0.3f);
          firer.transform.localScale = new Vector3(0.3f, 0.3f,
                0.3f);
          fire.SetActive(true);
          firer.SetActive(true);
          gameObject.SetActive(false);

        }
     }
}
