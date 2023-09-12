using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItalyOpen : MonoBehaviour
{
    public static bool italyTown = false;
     private void OnMouseDown()
    {
       ScoreManager.second = 15f;
       TokyoOpen.tokyoTown = false;
       ChinaOpen.chinaTown = false;
       IndiaOpen.indiaTown= false;
       RussiaOpen.russiaTown=false;
       ItalyOpen.italyTown=true;
       SpainOpen.spainTown=false;
       FranceOpen.franceTown=false;
       EnglandOpen.englandTown=false;
       USAOpen.usaTown = false;
    
    }
}
