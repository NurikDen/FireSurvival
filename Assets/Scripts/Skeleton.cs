using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public static bool skeleton = false;
    void OnMouseDown(){
        if(OpenSkins.skeletonOpen==true){
       Classic.classic = false;
       Black.blacki =false;
       Skeleton.skeleton =true;
       Blue.blue=false;
       Magical.magical=false;
       AO.ao=false;
       Fireball.fireball=false;
       Rainbow.rainbow=false;
       Smoke.smoke=false;
        }
    }
}
