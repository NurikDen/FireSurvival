using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using System;
public class OpenRec : MonoBehaviour
{  
    public const string leaderboard="CgkIkarQgbETEAIQAQ";

    void OnMouseDown(){
        OnAddScoreToLeaderBorad ();
        OnShowLeaderBoard ();
    }
    void Start ()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate ();
    }

    public void LogIn ()
    {
        Social.localUser.Authenticate ((bool success) =>
        {
            if (success) {
                Debug.Log ("Login Sucess");
            } else {
                Debug.Log ("Login failed");
            }
        });
    }
    public void OnShowLeaderBoard ()
    {
         PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIkarQgbETEAIQAQ");
    }
    public void OnAddScoreToLeaderBorad ()
    {
        if (Social.localUser.authenticated) {
            Social.ReportScore (ScoreManager.highscore, leaderboard, (bool success) =>
            {
                if (success) {
                    Debug.Log ("Update Score Success");
                    
                } else {
                    Debug.Log ("Update Score Fail");
                }
            });
        }
    }
}

