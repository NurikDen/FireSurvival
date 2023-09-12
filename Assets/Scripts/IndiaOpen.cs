using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndiaOpen : MonoBehaviour
{
    public static bool indiaTown  = false;
     private void OnMouseDown()
    {
       ScoreManager.second = 4f;
       TokyoOpen.tokyoTown = false;
       ChinaOpen.chinaTown = false;
       IndiaOpen.indiaTown= true;
       RussiaOpen.russiaTown=false;
       ItalyOpen.italyTown=false;
       SpainOpen.spainTown=false;
       FranceOpen.franceTown=false;
       EnglandOpen.englandTown=false;
       USAOpen.usaTown = false;
    
    }
}
