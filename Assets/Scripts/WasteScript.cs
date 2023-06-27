using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteScript : MonoBehaviour{
    public GameObject waste;

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
                var tmpWastes = Instantiate (waste, new Vector2 (-5f,3f), Quaternion.identity);
                _tmpWaste.Add(tmpWastes);
                yield return new WaitForSeconds (Random.Range (5f,10f));
            }
        }
    }

     void FixedUpdate()
     {
         var tmpWaste = new List<GameObject>(_tmpWaste);
         for (int i = 0; i < tmpWaste.Count; i++)
         {
             if (tmpWaste[i].transform.position.x < -15f)
             {
                 Destroy(tmpWaste[i]);
                 _tmpWaste.RemoveAt(i);
             }
         }
     }

}
