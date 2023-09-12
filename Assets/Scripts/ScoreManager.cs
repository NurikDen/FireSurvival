using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMesh HighScoreText;
    [SerializeField] TextMesh ScoreText;
  
public static float second = 1f;
    public static float score = 0;
    public static int highscore; 
    void Start()
    { 
       StartCoroutine(textscript());
    }
     IEnumerator textscript () {
      while (true) {
          if (Player.onpause)
          {
              yield return null;
          }
              else
          {
              score+=second;
              yield return new WaitForSeconds(1f);
              ScoreText.text = score.ToString();
              
          }
      }
     
}
    
    void Update()
    {
        if(Player.lose==true){
                score = 0;
              }
        highscore = (int)score;
        ScoreText.text = highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
            PlayerPrefs.SetInt("score", highscore);
        HighScoreText.text = PlayerPrefs.GetInt("score")+" Joules";
    }
    

}
