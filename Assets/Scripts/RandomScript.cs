using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : MonoBehaviour
{
    public GameObject obj;
    public float space = 1f, moveSpeed = 3f , turnSpeed = 3f;
    
     void Update() {
        float h = Input.GetAxis ("Horizontal");
        float xPos = h * space;
        float c = Input.GetAxis("Vertical");
        float xPoc = c * space;
        obj.transform.position = new Vector3 (xPos,0,0);
        
        

//         if (Input.GetKey(KeyCode.UpArrow)){
// obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime );
//         }
           
//         if (Input.GetKey(KeyCode.DownArrow)){
// obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime );
//         }
//            
//         if (Input.GetKey(KeyCode.LeftArrow)){
//    obj.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime );
}
//            obj.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime );
//         if (Input.GetKey(KeyCode.RightArrow)){

//obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime );} 
//            obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime ); 
//     }



   
}
