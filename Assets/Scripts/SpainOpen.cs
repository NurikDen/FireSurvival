using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpainOpen : MonoBehaviour
{
    public static bool spainTown = false;
     private void OnMouseDown()
    {
       ScoreManager.second = 20f;
       TokyoOpen.tokyoTown = false;
       ChinaOpen.chinaTown = false;
       IndiaOpen.indiaTown= false;
       RussiaOpen.russiaTown=false;
       ItalyOpen.italyTown=false;
       SpainOpen.spainTown=true;
       FranceOpen.franceTown=false;
       EnglandOpen.englandTown=false;
       USAOpen.usaTown = false;
    
    }
}
