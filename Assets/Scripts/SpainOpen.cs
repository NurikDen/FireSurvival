using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpainOpen : MonoBehaviour
{
    public  GameObject checking;
    public static bool spainTown = false;
     private void OnMouseDown()
    {
       checking.transform.position = new Vector3(1.6f,-0.5f,0);
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
