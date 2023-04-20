using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour{
    public GameObject water;

    private List<GameObject> _tmpWaters;
    
    void Start()
    {
        _tmpWaters = new List<GameObject>();
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn () {
        while (true) {
            if (Player.lose || Player.onpause)
            {
                yield return null;
            }
            else
            {
                var tmpWater = Instantiate (water, new Vector2 (Random.Range (-2.5f,2.5f),5.9f), Quaternion.identity);
                _tmpWaters.Add(tmpWater);
                yield return new WaitForSeconds (0.358f);
            }
        }
    }

     void FixedUpdate()
     {
         var tmpWaters = new List<GameObject>(_tmpWaters);
         for (int i = 0; i < tmpWaters.Count; i++)
         {
             if (tmpWaters[i].transform.position.y < -7)
             {
                 Destroy(tmpWaters[i]);
                 _tmpWaters.RemoveAt(i);
             }
         }
     }

}
