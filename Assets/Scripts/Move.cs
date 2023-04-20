using System;
using UnityEngine;

public class Move : MonoBehaviour{
    public Transform player;
    public Animator animator;
    
    [SerializeField]
    private float speed = 10f;
    
      void FixedUpdate()
      { onMouseDrag(); }
    public void onMouseDrag (){ 
      if (!Player.lose && !Player.onpause){
Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.x = mousePos.x > 3f ? 3f : mousePos.x;
        mousePos.x = mousePos.x < -3f ? -3f : mousePos.x;
        player.position = Vector2.MoveTowards (player.position,
new Vector2 (mousePos.x, player.position.y),
speed * Time.deltaTime);
if (player.transform.position.x < 0){
  animator.SetFloat("Horizontalmove",2.5f);
}
else if (player.transform.position.x >0){
  animator.SetFloat("Horizontalmove",1.5f);
}
else{
  animator.SetFloat("Horizontalmove",-1f);
}
      }
     
      
    }
      }
  
    

