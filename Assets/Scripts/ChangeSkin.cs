using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeSkin : MonoBehaviour {
  public ParticleSystem particleSystem;
public bool Black;

void Start()
{
        var main = particleSystem.main;
        var col = particleSystem.colorOverLifetime;
        col.enabled = true;
        Gradient gradient = new Gradient();

        if(Classic.classic == true){
        gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.yellow, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
        col.color = gradient;
        ThunderScript.secondtime = 5f;
      BenzinScript.secondtime = 3f;
      Player.waterheel=1.3f;
      Player.firerheel=3f;
      Player.brunchhp=1.5f;
      Player.benzinhp=1.2f;
      Player.sparkhp=1.2f;
        }
        else if( Classic.classic == false && Skeleton.skeleton == false && Blue.blue == false && Magical.magical == false && AO.ao == false && Fireball.fireball == false && Rainbow.rainbow == false && Smoke.smoke == false ){
    gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.black, 0.0f), new GradientColorKey(Color.white, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
col.color = gradient;
ThunderScript.secondtime = 5f;
      BenzinScript.secondtime = 3f;
      Player.waterheel=1.2f;
      Player.firerheel=2.5f;
      Player.brunchhp=1.6f;
      Player.benzinhp=1.3f;
      Player.sparkhp=1.3f;
}
else if(Skeleton.skeleton == true){
    gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(new Color(0f,1f,0.9607844f,1), 0.0f), new GradientColorKey(Color.black, 0.94f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
col.color = gradient;
ThunderScript.secondtime = 5f;
      BenzinScript.secondtime = 3f;
      Player.waterheel=1.1f;
      Player.firerheel=3f;
      Player.brunchhp=2f;
      Player.benzinhp=1.2f;
      Player.sparkhp=1.2f;
}
else if(Blue.blue == true){
    gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.white, 0.0f), new GradientColorKey(Color.blue, 0.5f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
col.color = gradient;
ThunderScript.secondtime = 5f;
      BenzinScript.secondtime = 1f;
      Player.waterheel=1.3f;
      Player.firerheel=2f;
      Player.brunchhp=1.5f;
      Player.benzinhp=1.2f;
      Player.sparkhp=1.2f;
}
 else if(Magical.magical == true){
    gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
col.color = gradient;
ThunderScript.secondtime = 3f;
      BenzinScript.secondtime = 3f;
      Player.waterheel=1.1f;
      Player.firerheel=3f;
      Player.brunchhp=1.5f;
      Player.benzinhp=1.2f;
      Player.sparkhp=1.2f;
 }
else if(AO.ao == true){
gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.black, 0.0f), new GradientColorKey(Color.green, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
col.color = gradient;
ThunderScript.secondtime = 5f;
      BenzinScript.secondtime = 3f;
      Player.waterheel=1.3f;
      Player.firerheel=1f;
      Player.brunchhp=1.5f;
      Player.benzinhp=1.2f;
      Player.sparkhp=1.2f;
} 
else if(Fireball.fireball == true){
gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.white, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
col.color = gradient;
ThunderScript.secondtime = 5f;
      BenzinScript.secondtime = 3f;
      Player.waterheel=1.1f;
      Player.firerheel=10f;
      Player.brunchhp=1.3f;
      Player.benzinhp=1.1f;
      Player.sparkhp=1.8f;
}
else if(Rainbow.rainbow == true){
    gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(new Color(1f,0.6064059f,0f,1f), 0.124f),new GradientColorKey(Color.yellow, 0.347f),new GradientColorKey(Color.green, 0.506f), new GradientColorKey(new Color(0.03921566f,0.7452546f,0.8980392f,1f), 0.0677f),new GradientColorKey(Color.blue, 0.834f),new GradientColorKey(new Color(0.638876f,0f,1f,1f), 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f),new GradientAlphaKey(1.0f, 0.124f),new GradientAlphaKey(1.0f, 0.347f),new GradientAlphaKey(1.0f, 0.506f),new GradientAlphaKey(1.0f, 0.677f),new GradientAlphaKey(1.0f, 0.834f), new GradientAlphaKey(0.0f, 1.0f) });
col.color = gradient;
ThunderScript.secondtime = 5f;
      BenzinScript.secondtime = 3f;
      Player.waterheel=0.9f;
      Player.firerheel=0.5f;
      Player.brunchhp=0.5f;
      Player.benzinhp=0.8f;
      Player.sparkhp=0.8f;
}
 else if(Smoke.smoke == true){
    gradient.SetKeys( new GradientColorKey[] { new GradientColorKey(new Color(0.245283f,0.23487f,0.23487f,0.02f), 0.0f), new GradientColorKey(new Color(0.3018868f,0.2833749f,0.2833749f,0.02f), 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(0.05f, 0.05f), new GradientAlphaKey(0.05f, 0.05f) });
col.color = gradient;
ThunderScript.secondtime = 5f;
      BenzinScript.secondtime = 3f;
      Player.waterheel=1f;
      Player.firerheel=1f;
      Player.brunchhp=1f;
      Player.benzinhp=1f;
      Player.sparkhp=1f;
ScoreManager.second = 1f;
 }

        
    
}
}
//     ParticleSystem ps = GetComponent<ParticleSystem>();
//     void Start() {
        
//         var col = ps.colorOverLifetime;
//         Gradient grad = new Gradient();
//         col.enabled = true;
//     if(Classic.classic == true){
//         grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );
//         col.color = grad;
//     }
//     if(Black.black ==true){
//     if(Black.black ==true){
//     if(Black.black ==true){
//         grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );
//         col.color = grad;
//     }
//     
//         grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );
//         col.color = grad;
//     }
//     if(Blue.blue == true){
//         grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );  
//         col.color = grad;
//     }
//     if(AO.ao == true){
//         grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );
//         col.color = grad;
//     }
//     if(Fireball.fireball == true){
//         grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );       
//         col.color = grad;
//     }
//     if(Rainbow.rainbow == true){
//         grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );       
//         col.color = grad;
//     }
//     if(Smoke.smoke == true){
//         grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.red, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );       
//         col.color = grad;
//     }

// }

