using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RussiaOpen : MonoBehaviour
{
    public static bool russiaTown = false;
     private void OnMouseDown()
    {
       ScoreManager.second = 10f;
        TokyoOpen.tokyoTown = false;
       ChinaOpen.chinaTown = false;
       IndiaOpen.indiaTown= false;
       RussiaOpen.russiaTown=true;
       ItalyOpen.italyTown=false;
       SpainOpen.spainTown=false;
       FranceOpen.franceTown=false;
       EnglandOpen.englandTown=false;
       USAOpen.usaTown = false;
    
    }
}
