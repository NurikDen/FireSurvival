using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RussiaOpen : MonoBehaviour
{
    public  GameObject checking;
    public static bool russiaTown = false;
     private void OnMouseDown()
    {
       checking.transform.position = new Vector3(-1.6f,-0.5f,0);
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
