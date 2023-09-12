using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FranceOpen : MonoBehaviour
{
    public static bool franceTown = false;
     private void OnMouseDown()
    {
       ScoreManager.second = 30f;
       TokyoOpen.tokyoTown = false;
       ChinaOpen.chinaTown = false;
       IndiaOpen.indiaTown= false;
       RussiaOpen.russiaTown=false;
       ItalyOpen.italyTown=false;
       SpainOpen.spainTown=false;
       FranceOpen.franceTown=true;
       EnglandOpen.englandTown=false;
       USAOpen.usaTown = false;
    
    }
}
