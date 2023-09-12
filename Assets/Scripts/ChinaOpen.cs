using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChinaOpen : MonoBehaviour
{  
    public static bool chinaTown = false;
     private void OnMouseDown()
    {
       ScoreManager.second = 2f;
       TokyoOpen.tokyoTown = false;
       ChinaOpen.chinaTown = true;
       IndiaOpen.indiaTown= false;
       RussiaOpen.russiaTown=false;
       ItalyOpen.italyTown=false;
       SpainOpen.spainTown=false;
       FranceOpen.franceTown=false;
       EnglandOpen.englandTown=false;
       USAOpen.usaTown = false;
    
    }
}
