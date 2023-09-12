using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magical : MonoBehaviour
{
    public static bool magical = false;
    void OnMouseDown(){
        if(OpenSkins.magicOpen==true){
       Classic.classic = false;
       Black.blacki =false;
       Skeleton.skeleton =false;
       Blue.blue=false;
       Magical.magical=true;
       AO.ao=false;
       Fireball.fireball=false;
       Rainbow.rainbow=false;
       Smoke.smoke=false;
        }
    }
}