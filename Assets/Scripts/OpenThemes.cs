using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenThemes : MonoBehaviour
{
    public GameObject chinaOpen;
    public GameObject chinaClose;
    public GameObject textChina;

    public GameObject indiaOpen;
    public GameObject indiaClose;
    public GameObject textIndia;

    public GameObject russiaOpen;
    public GameObject russiaClose;
    public GameObject textRussia;

    public GameObject italyOpen;
    public GameObject italyClose;
    public GameObject textItaly;

    public GameObject spainOpen;
    public GameObject spainClose;
    public GameObject textSpain;

    public GameObject franceOpen;
    public GameObject franceClose;
    public GameObject textFrance;

    public GameObject englandOpen;
    public GameObject englandClose;
    public GameObject textEngland;

    public GameObject usaOpen;
    public GameObject usaClose;
    public GameObject textUsa;
    public GameObject prize;
    
    void Start()
    {
        if (PlayerPrefs.GetInt("score")>=100){
      chinaOpen.SetActive(true);
      chinaClose.SetActive(false);
      textChina.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
      if (PlayerPrefs.GetInt("score")>=100){
      indiaOpen.SetActive(true);
      indiaClose.SetActive(false);
      textIndia.SetActive(false);
      prize.transform.position += new Vector3(-3.2f,-2.6f,0);
    }
     if (PlayerPrefs.GetInt("score")>=100){
      russiaOpen.SetActive(true);
      russiaClose.SetActive(false);
      textRussia.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
     if (PlayerPrefs.GetInt("score")>=100){
      italyOpen.SetActive(true);
      italyClose.SetActive(false);
      textItaly.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
    if (PlayerPrefs.GetInt("score")>=100){
      spainOpen.SetActive(true);
      spainClose.SetActive(false);
      textSpain.SetActive(false);
      prize.transform.position += new Vector3(-3.2f,-2.6f,0);
    }
    if (PlayerPrefs.GetInt("score")>=100){
     franceOpen.SetActive(true);
     franceClose.SetActive(false);
     textFrance.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
    if (PlayerPrefs.GetInt("score")>=100){
      englandOpen.SetActive(true);
      englandClose.SetActive(false);
      textEngland.SetActive(false);
      prize.transform.position += new Vector3(1.6f,0,0);
    }
    if (PlayerPrefs.GetInt("score")>=100){
      usaOpen.SetActive(true);
      usaClose.SetActive(false);
      textUsa.SetActive(false);
      Destroy(prize);
    }
    
    }

    
}
