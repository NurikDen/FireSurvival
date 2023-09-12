using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : MonoBehaviour
{
     public static bool blacki = false;
     void OnMouseDown(){
        if(OpenSkins.blackOpen==true){
       Classic.classic = false;
       Black.blacki =true;
       Skeleton.skeleton =false;
       Blue.blue=false;
       Magical.magical=false;
       AO.ao=false;
       Fireball.fireball=false;
       Rainbow.rainbow=false;
       Smoke.smoke=false;
        }
    }
}



