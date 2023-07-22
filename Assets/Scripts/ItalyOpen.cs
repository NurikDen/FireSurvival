using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItalyOpen : MonoBehaviour
{
    public  GameObject checking;
    public static bool italyTown = false;
     private void OnMouseDown()
    {
       checking.transform.position = new Vector3(0,-0.5f,0);
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
