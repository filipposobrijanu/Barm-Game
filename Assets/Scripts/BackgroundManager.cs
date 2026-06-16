using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackgroundManager : MonoBehaviour
{
    public ScoreManager sm;

    public GameObject LightSky;
    public GameObject NormalSky;
    public GameObject WhiteSky;
    public GameObject UVSky;
    public GameObject SunshineSky;

    public TextMeshProUGUI bulletstext;

    public TextMeshProUGUI fpstext;
    public TextMeshProUGUI copytext;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI coinstext;

    public GameObject coinblack;
    public GameObject coinwhite;

    public GameObject resumeblack;
    public GameObject resumewhite;
    public GameObject menublack;
    public GameObject menuwhite;
    public GameObject quitblack;
    public GameObject quitwhite;


    public void Start()
    {
        if(sm.lastpressedskies == 0)
        {

            LightSky.SetActive(true);
            NormalSky.SetActive(false);
            WhiteSky.SetActive(false);
            UVSky.SetActive(false);
            SunshineSky.SetActive(false);

            bulletstext.color = new Color32(0, 167, 253, 100);

            fpstext.color = new Color32(0, 0, 0, 150);
            copytext.color = new Color32(0, 0, 0, 150);
            scoretext.color = new Color32(0, 0, 0, 255);
            coinstext.color = new Color32(0, 0, 0, 255);

            coinblack.SetActive(true);
            coinwhite.SetActive(false);

            resumeblack.SetActive(true);
            resumewhite.SetActive(false);
            menublack.SetActive(true);
            menuwhite.SetActive(false);
            quitblack.SetActive(true);
            quitwhite.SetActive(false);

        }
        else if (sm.lastpressedskies == 1)
        {

            LightSky.SetActive(false);
            NormalSky.SetActive(true);
            WhiteSky.SetActive(false);
            UVSky.SetActive(false);
            SunshineSky.SetActive(false);

            bulletstext.color = new Color32(0, 74, 169, 130);

            fpstext.color = new Color32(255, 255, 255, 150);
            copytext.color = new Color32(255, 255, 255, 150);
            scoretext.color = new Color32(255, 255, 255, 255);
            coinstext.color = new Color32(255, 255, 255, 255);

            coinblack.SetActive(false);
            coinwhite.SetActive(true);

            resumeblack.SetActive(false);
            resumewhite.SetActive(true);
            menublack.SetActive(false);
            menuwhite.SetActive(true);
            quitblack.SetActive(false);
            quitwhite.SetActive(true);

        }
        else if (sm.lastpressedskies == 2)
        {

            LightSky.SetActive(false);
            NormalSky.SetActive(false);
            WhiteSky.SetActive(true);
            UVSky.SetActive(false);
            SunshineSky.SetActive(false);

            bulletstext.color = new Color32(148, 159, 210, 130);
            fpstext.color = new Color32(0, 0, 0, 150);
            copytext.color = new Color32(0, 0, 0, 150);
            scoretext.color = new Color32(0, 0, 0, 255);
            coinstext.color = new Color32(0, 0, 0, 255);

            coinblack.SetActive(true);
            coinwhite.SetActive(false);

            resumeblack.SetActive(true);
            resumewhite.SetActive(false);
            menublack.SetActive(true);
            menuwhite.SetActive(false);
            quitblack.SetActive(true);
            quitwhite.SetActive(false);

        }
        else if (sm.lastpressedskies == 3)
        {

            LightSky.SetActive(false);
            NormalSky.SetActive(false);
            WhiteSky.SetActive(false);
            UVSky.SetActive(true);
            SunshineSky.SetActive(false);

            bulletstext.color = new Color32(30, 69, 157, 130);

            fpstext.color = new Color32(255, 255, 255, 150);
            copytext.color = new Color32(255, 255, 255, 150);
            scoretext.color = new Color32(255, 255, 255, 255);
            coinstext.color = new Color32(255, 255, 255, 255);

            coinblack.SetActive(false);
            coinwhite.SetActive(true);

            resumeblack.SetActive(false);
            resumewhite.SetActive(true);
            menublack.SetActive(false);
            menuwhite.SetActive(true);
            quitblack.SetActive(false);
            quitwhite.SetActive(true);

        }
        else if (sm.lastpressedskies == 4)
        {

            LightSky.SetActive(false);
            NormalSky.SetActive(false);
            WhiteSky.SetActive(false);
            UVSky.SetActive(false);
            SunshineSky.SetActive(true);

            bulletstext.color = new Color32(236, 60, 89, 130);

            fpstext.color = new Color32(0, 0, 0, 150);
            copytext.color = new Color32(0, 0, 0, 150);
            scoretext.color = new Color32(0, 0, 0, 255);
            coinstext.color = new Color32(0, 0, 0, 255);

            coinblack.SetActive(true);
            coinwhite.SetActive(false);

            resumeblack.SetActive(true);
            resumewhite.SetActive(false);
            menublack.SetActive(true);
            menuwhite.SetActive(false);
            quitblack.SetActive(true);
            quitwhite.SetActive(false);

        }
    }
}
