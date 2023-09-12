using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AO : MonoBehaviour
{
    public static bool ao = false;
    void OnMouseDown(){
        if(OpenSkins.aoOpen==true){
       Classic.classic = false;
       Black.blacki =false;
       Skeleton.skeleton =false;
       Blue.blue=false;
       Magical.magical=false;
       AO.ao=true;
       Fireball.fireball=false;
       Rainbow.rainbow=false;
       Smoke.smoke=false;
        }
    }
}
