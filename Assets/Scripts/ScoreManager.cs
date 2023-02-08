using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMesh HighScoreText;
    [SerializeField] TextMesh ScoreText;

    public static float score = 0;
    int highscore; 
    void Start()
    {
        score = 0;
       StartCoroutine(textscript());
    }
     IEnumerator textscript () {
      while (!Player.lose ) {
            score++;
            yield return new WaitForSeconds (1f);  
            ScoreText.text = score.ToString(); 
        }
}
    
    void Update()
    {
        
        highscore = (int)score;
        ScoreText.text = highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
            PlayerPrefs.SetInt("score", highscore);

        HighScoreText.text = PlayerPrefs.GetInt("score").ToString();
    }
}
