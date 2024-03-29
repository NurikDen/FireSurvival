using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderScript : MonoBehaviour
{
    public GameObject thunder;
    private List<GameObject> _tmpThunders;
    public static float secondtime = 5f;

    void Start()
    {
        _tmpThunders = new List<GameObject>();
        StartCoroutine(ReSpawn());
    }

    IEnumerator ReSpawn()
    {
        while (true)
        {
            if (Player.lose==true  || Player.onpause==true)
            {
                yield return null;
            }
            else
            {
                var tmpThunder = Instantiate(thunder, new Vector2(Random.Range(-3f, 3f), 9f), Quaternion.identity);
                _tmpThunders.Add(tmpThunder);
                yield return new WaitForSeconds(secondtime);
                var tmpThunders = new List<GameObject>(_tmpThunders);
                for (int i = 0; i < tmpThunders.Count; i++)
                {
                    Destroy(tmpThunders[i]);
                    _tmpThunders.RemoveAt(i);
                }
            }
        }
    }
}