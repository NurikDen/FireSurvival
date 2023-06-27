using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenzinScript : MonoBehaviour{
    public GameObject benzin;

    private List<GameObject> _tmpBenzins;
    
    void Start()
    {
        _tmpBenzins = new List<GameObject>();
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
                var tmpBenzin = Instantiate (benzin, new Vector2 (Random.Range (-2.5f,2.5f),5.9f), Quaternion.identity);
                _tmpBenzins.Add(tmpBenzin);
                yield return new WaitForSeconds (3f);
            }
        }
    }

     void FixedUpdate()
     {
         var tmpBenzins = new List<GameObject>(_tmpBenzins);
         for (int i = 0; i < tmpBenzins.Count; i++)
         {   
             if (tmpBenzins[i].transform.position.y < -7)
             {
                 Destroy(tmpBenzins[i]);
                 _tmpBenzins.RemoveAt(i);
             }
         }
     }
}
      
 
        


     


