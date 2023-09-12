using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokyoOpen : MonoBehaviour
{
   
    public static bool tokyoTown = false;
     private void OnMouseDown()
    {
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
