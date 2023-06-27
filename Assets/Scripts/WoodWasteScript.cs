using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodWasteScript : MonoBehaviour{
    public GameObject waste;
    public static float rand; 
    public static float x;
    private List<GameObject> _tmpWaste;
    
    void Start()
    {
        _tmpWaste = new List<GameObject>();
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
                x=5f;
                var tmpWastes = Instantiate (waste, new Vector2 (x,3f), Quaternion.identity);
                _tmpWaste.Add(tmpWastes);
                yield return new WaitForSeconds (Random.Range (5f,9f));
                x=-5f;
                var TmpWastes = Instantiate (waste, new Vector2 (x,3f), Quaternion.identity);
                _tmpWaste.Add(TmpWastes);
                yield return new WaitForSeconds (Random.Range (5f,9f));
            }
        }
    }

     void FixedUpdate()
     {
         var tmpWaste = new List<GameObject>(_tmpWaste);
         for (int i = 0; i < tmpWaste.Count; i++)
         {
             if (tmpWaste[i].transform.position.y > 4f)
             {
                 Destroy(tmpWaste[i]);
                 _tmpWaste.RemoveAt(i);
             }
         }
     }

}
