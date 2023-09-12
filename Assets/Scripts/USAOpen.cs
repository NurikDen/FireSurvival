using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USAOpen : MonoBehaviour
{
    public static bool usaTown = false;
     private void OnMouseDown()
    {
       ScoreManager.second = 100f;
       TokyoOpen.tokyoTown = false;
       ChinaOpen.chinaTown = false;
       IndiaOpen.indiaTown= false;
       RussiaOpen.russiaTown=false;
       ItalyOpen.italyTown=false;
       SpainOpen.spainTown=false;
       FranceOpen.franceTown=false;
       EnglandOpen.englandTown=false;
       USAOpen.usaTown = true;
    
    }
}
