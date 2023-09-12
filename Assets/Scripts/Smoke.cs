using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    public static bool smoke = false;
    void OnMouseDown(){
        if(OpenSkins.smokeOpen ==true){
       Classic.classic = false;
       Black.blacki =false;
       Skeleton.skeleton =false;
       Blue.blue=false;
       Magical.magical=false;
       AO.ao=false;
       Fireball.fireball=false;
       Rainbow.rainbow=false;
       Smoke.smoke=true;
        }
    }
}   
