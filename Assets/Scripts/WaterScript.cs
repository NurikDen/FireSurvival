using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour{
    public GameObject water;
    private float secondtime = 0.358f;
    private List<GameObject> _tmpWaters;
    private int counter;
    
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
                var tmpWater = Instantiate (water, new Vector2 (Random.Range (-3f,3f),5.9f), Quaternion.identity);
                _tmpWaters.Add(tmpWater);
                yield return new WaitForSeconds (secondtime);
                StartCoroutine(IncrementCounter());
    
            }
        }
    }
IEnumerator IncrementCounter() {
            yield return new WaitForSeconds(50f);
                secondtime = 0.05f;
            yield return new WaitForSeconds(5f);
            secondtime = 0.358f;
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
