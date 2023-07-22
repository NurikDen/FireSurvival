using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirerScript : MonoBehaviour{
    public GameObject firerleft;
     public GameObject firerright;
    public static float x;
    private List<GameObject> _tmpFirers;
    
    void Start()
    {
        _tmpFirers = new List<GameObject>();
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
                yield return new WaitForSeconds (Random.Range (10f,20f));
                 x=5f;
                var tmpFires = Instantiate (firerright, new Vector2 (x,-2.5f), Quaternion.identity);
                _tmpFirers.Add(tmpFires);
                yield return new WaitForSeconds (Random.Range (10f,20f));
                x=-5f;
                var TmpFires = Instantiate (firerleft, new Vector2 (x,-2.5f), Quaternion.identity);
                _tmpFirers.Add(TmpFires);
            }
        }
    }

     void FixedUpdate()
     {
         var tmpFirers = new List<GameObject>(_tmpFirers);
         for (int i = 0; i < tmpFirers.Count; i++)
         {
             if (tmpFirers[i].transform.position.x > 5 || tmpFirers[i].transform.position.x < -5 )
             {
                 Destroy(tmpFirers[i]);
                 _tmpFirers.RemoveAt(i);
             }
         }
     }

}
