using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource1; // ссылка на первый компонент AudioSource
    public AudioSource audioSource2; // ссылка на второй компонент AudioSource

    void Start()
    {
        // получаем компоненты AudioSource из объектов на сцене
        audioSource1 = GameObject.Find("AudioSource1").GetComponent<AudioSource>();
        audioSource2 = GameObject.Find("AudioSource2").GetComponent<AudioSource>();

        // запускаем первую музыку
        audioSource1.Play();
    }

    void Update()
    {
        if(Player.onpause == true){
  audioSource1.volume = 0.5f;
  audioSource2.volume = 0.5f;
        }
       else if(Player.onpause == false){
  audioSource1.volume = 1f;
  audioSource2.volume = 1f;
        }
         if(Player.lose == true){
                audioSource1.Stop();
                audioSource2.Stop();
            }
        // если первая музыка закончилась, запускаем вторую
        if (!audioSource1.isPlaying && !audioSource2.isPlaying)
        {
             audioSource2.Play();   
        }
        // если вторая музыка закончилась, запускаем первую
        else if (!audioSource2.isPlaying && !audioSource1.isPlaying)
        {
            audioSource1.Play();          
        }
        
    }
}