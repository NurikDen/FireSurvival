using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirerMoveLeft : MonoBehaviour
{
    private float speed = 4.0f; // Скорость движения объекта
    private float startXPos; // Начальная позиция объекта по оси X
    private float endXPos=-2f; // Конечная позиция объекта по оси X
    private float moveDelay = 2.0f; // Задержка перед обратным движением
    private bool movingForward = true; // Флаг направления движения
    public GameObject o;

    private void Start()
    {
        startXPos = o.transform.position.x; // Получаем начальную позицию объекта по оси X
    }

    public void Update()
    {
         if(FirerScript.x == -5f){
            endXPos=-2.5f;
        if (movingForward)
        {
             if(Player.lose == false && Player.onpause == false){
            o.transform.Translate(Vector3.right * speed * Time.deltaTime);
             }
            if (o.transform.position.x >= endXPos)
            {
                movingForward = false;
                Invoke("StartMovingBackward", moveDelay);
            }
        }
        else
        {
             if(Player.lose == false && Player.onpause == false){
            o.transform.Translate(Vector3.left * speed * Time.deltaTime);
             }
            if (o.transform.position.x <= startXPos-10)
            {
                movingForward = true;
                Invoke("StartMovingForward", moveDelay);
            }
        }
    }
    }

    private void StartMovingForward()
    {
        movingForward = true;
    }

    private void StartMovingBackward()
    {
        movingForward = false;
    }
    
     }


