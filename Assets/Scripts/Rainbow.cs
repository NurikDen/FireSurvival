using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    public static bool rainbow = false;
    void OnMouseDown(){
        if(OpenSkins.rainbowOpen==true){
       Classic.classic = false;
       Black.blacki =false;
       Skeleton.skeleton =false;
       Blue.blue=false;
       Magical.magical=false;
       AO.ao=false;
       Fireball.fireball=false;
       Rainbow.rainbow=true;
       Smoke.smoke=false;
        }
    }
}
