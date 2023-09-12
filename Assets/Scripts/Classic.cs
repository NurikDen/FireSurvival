using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classic : MonoBehaviour
{
     public static bool classic = false;
     private void OnMouseDown()
    {
       Classic.classic = true;
       Black.blacki = false;
       Blue.blue=false;
       Skeleton.skeleton= false;
       Magical.magical=false;
       AO.ao=false;
       Rainbow.rainbow=false;
       Fireball.fireball=false;
       Smoke.smoke = false;
    }
}
