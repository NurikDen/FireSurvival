using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSkins : MonoBehaviour
{
   public static bool  blackOpen=false;
    public GameObject blackClose;
    public GameObject textblack;
    

    public static bool  skeletonOpen=false;
    public GameObject skeletonClose;
    public GameObject textskeleton;

    public static bool  blueOpen=false;
    public GameObject blueClose;
    public GameObject textblue;

    public static bool magicOpen=false;
    public GameObject magicClose;
    public GameObject textmagic;

    public static bool  aoOpen=false;
    public GameObject aoClose;
    public GameObject textao;

    public static bool  rainbowOpen=false;
    public GameObject rainbowClose;
    public GameObject textrainbow;

    public static bool  fireballOpen=false;
    public GameObject fireballClose;
    public GameObject textfireball;

    public static bool  smokeOpen=false;
    public GameObject smokeClose;
    public GameObject textsmoke;
    public GameObject prize;
    
    void Start()
    {
        if (PlayerPrefs.GetInt("score")>=50){
        
      blackClose.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5803922f,0.07843138f,0.8862746f,1);
      blackOpen = true;
      textblack.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
      if (PlayerPrefs.GetInt("score")>=100){
      skeletonClose.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5803922f,0.07843138f,0.8862746f,1);
       skeletonOpen = true;
      textskeleton.SetActive(false);
      prize.transform.position += new Vector3(-3.2f,-2.6f,0);
    }
     if (PlayerPrefs.GetInt("score")>=200){
      blueClose.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5803922f,0.07843138f,0.8862746f,1);
      blueOpen  = true;
      textblue.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
     if (PlayerPrefs.GetInt("score")>=400){
      magicClose.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5803922f,0.07843138f,0.8862746f,1);
      magicOpen = true;
      textmagic.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
    if (PlayerPrefs.GetInt("score")>=500){
      aoClose.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5803922f,0.07843138f,0.8862746f,1);
      aoOpen  = true;
      textao.SetActive(false);
      prize.transform.position += new Vector3(-3.2f,-2.6f,0);
    }
    if (PlayerPrefs.GetInt("score")>=800){
     rainbowClose.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5803922f,0.07843138f,0.8862746f,1);
     rainbowOpen  = true;
     textrainbow.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
    if (PlayerPrefs.GetInt("score")>=1000){//1000
      fireballClose.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5803922f,0.07843138f,0.8862746f,1);
       fireballOpen = true;
      textfireball.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
    if (PlayerPrefs.GetInt("score")>=1500){//1500
      smokeClose.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5803922f,0.07843138f,0.8862746f,1);
       smokeOpen = true;
      textsmoke.SetActive(false);
      Destroy(prize);
    }
    
    }
}
