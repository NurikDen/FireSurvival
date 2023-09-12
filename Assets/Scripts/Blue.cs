using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    public static bool blue = false;
    void OnMouseDown(){
        if(OpenSkins.blueOpen==true){
       Classic.classic = false;
       Black.blacki =false;
       Skeleton.skeleton =false;
       Blue.blue=true;
       Magical.magical=false;
       AO.ao=false;
       Fireball.fireball=false;
       Rainbow.rainbow=false;
       Smoke.smoke=false;
        }
    }
}
