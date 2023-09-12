using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public static bool fireball = false;
    void OnMouseDown(){
        if(OpenSkins.fireballOpen==true){
       Classic.classic = false;
       Black.blacki =false;
       Skeleton.skeleton =false;
       Blue.blue=false;
       Magical.magical=false;
       AO.ao=false;
       Fireball.fireball=true;
       Rainbow.rainbow=false;
       Smoke.smoke=false;
        }
    }
}
