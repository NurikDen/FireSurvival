using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnglandOpen : MonoBehaviour
{
    public static bool englandTown = false;
     private void OnMouseDown()
    {
       ScoreManager.second = 50f;
       TokyoOpen.tokyoTown = false;
       ChinaOpen.chinaTown = false;
       IndiaOpen.indiaTown= false;
       RussiaOpen.russiaTown=false;
       ItalyOpen.italyTown=false;
       SpainOpen.spainTown=false;
       FranceOpen.franceTown=false;
       EnglandOpen.englandTown=true;
       USAOpen.usaTown = false;
    
    }
}
