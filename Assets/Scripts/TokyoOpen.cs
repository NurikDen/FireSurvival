using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokyoOpen : MonoBehaviour
{
     public  GameObject checking;
    public static bool tokyoTown = false;
     private void OnMouseDown()
    {
       checking.transform.position = new Vector3(-1.6f,2f,0);
       tokyoTown = true;
       ChinaOpen.chinaTown = false;
       IndiaOpen.indiaTown= false;
       RussiaOpen.russiaTown=false;
       ItalyOpen.italyTown=false;
       SpainOpen.spainTown=false;
       FranceOpen.franceTown=false;
       EnglandOpen.englandTown=false;
       USAOpen.usaTown = false;
    }
}
