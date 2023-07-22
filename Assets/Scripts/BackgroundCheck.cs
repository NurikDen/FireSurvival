using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCheck : MonoBehaviour
{public  GameObject background;
public  Sprite tokyoBack;
public  Sprite chinaBack;
public  Sprite indiaBack;
public  Sprite russiaBack;
public  Sprite italyBack;
public  Sprite spainBack;
public  Sprite franceBack;
public  Sprite englandBack;
public  Sprite usaBack;
 private SpriteRenderer renderer;

    void Start()  
    {
        if(TokyoOpen.tokyoTown == true) {
          renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = tokyoBack;
       }
       else if(ChinaOpen.chinaTown == true) {
           renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = chinaBack;
       }
       else if(IndiaOpen.indiaTown == true) {
           renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = indiaBack;
       }
       else if(RussiaOpen.russiaTown == true) {
           renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = russiaBack;
       }
       else if(ItalyOpen.italyTown == true) {
           renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = italyBack;
       }
       else if(SpainOpen.spainTown == true) {
           renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = spainBack;
       }
      else  if(FranceOpen.franceTown == true) {
           renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = franceBack;
       }
      else  if(EnglandOpen.englandTown == true) {
           renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = englandBack;
       }
       else if(USAOpen.usaTown == true) {
           renderer = background.GetComponent<SpriteRenderer>();
           renderer.sprite = usaBack;
       }
       
    }

    
}
