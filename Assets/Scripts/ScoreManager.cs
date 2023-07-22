using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMesh HighScoreText;
    [SerializeField] TextMesh ScoreText;
  
public static float second = 1f;
    public static float score = 0;
    public static int highscore; 
    void Start()
    { 
        score = 0;
       StartCoroutine(textscript());
    }
     IEnumerator textscript () {
      while (true) {
          if (Player.lose  || Player.onpause)
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
        highscore = (int)score;
        ScoreText.text = highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
            PlayerPrefs.SetInt("score", highscore);

        HighScoreText.text = PlayerPrefs.GetInt("score")+" Joules";
    }
}
