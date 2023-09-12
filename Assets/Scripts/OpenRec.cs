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
      #region PUBLIC_VAR
    public const string leaderboard="CgkIkarQgbETEAIQAQ";
    #endregion
    #region DEFAULT_UNITY_CALLBACKS
 void OnMouseDown() {
    LogIn ();
    OnShowLeaderBoard ();
    
}

    void Start ()
    {
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate ();
    }
void Update(){
    OnAddScoreToLeaderBorad ();
}
    #endregion
    #region BUTTON_CALLBACKS
    /// <summary>
    /// Login In Into Your Google+ Account
    /// </summary>
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
    /// <summary>
    /// Shows All Available Leaderborad
    /// </summary>
    public void OnShowLeaderBoard ()
    {
//        Social.ShowLeaderboardUI (); // Show all leaderboard
        ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI (leaderboard); // Show current (Active) leaderboard
    }
    /// <summary>
    /// Adds Score To leader board
    /// </summary>
    public void OnAddScoreToLeaderBorad ()
    {
        if (Social.localUser.authenticated) {
            Social.ReportScore (100, leaderboard, (bool success) =>
            {
                if (success) {
                    Debug.Log ("Update Score Success");
                    
                } else {
                    Debug.Log ("Update Score Fail");
                }
            });
        }
    }
    /// <summary>
    /// On Logout of your Google+ Account
    /// </summary>
    #endregion
}

