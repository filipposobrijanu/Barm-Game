using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreManager : MonoBehaviour
{

    public ScoreManager sm;

    public Button LightSky;
    public Button NormalSky;
    public Button WhiteSky;
    public Button UltravioletSky;
    public Button SunshineSky;

    public GameObject LightSkyEquip;
    public GameObject NormalSkyEquip;
    public GameObject WhiteSkyEquip;
    public GameObject UltravioletSkyEquip;
    public GameObject SunshineSkyEquip;

    public void Update()
    {
        if(sm.score1 > 20)
        {

            NormalSky.interactable = true;

        }
        if (sm.score1 > 40)
        {

            WhiteSky.interactable = true;

        }
        if (sm.score1 > 75)
        {

            UltravioletSky.interactable = true;

        }
        if (sm.score1 > 100)
        {

            SunshineSky.interactable = true;

        }

        LightSky.onClick.AddListener(LightSkyF);
        NormalSky.onClick.AddListener(NormalSkyF);
        WhiteSky.onClick.AddListener(DarkSkyF);
        UltravioletSky.onClick.AddListener(UltravioletSkyF);
        SunshineSky.onClick.AddListener(SunshineSkyF);

        if (sm.lastpressedskies == 0)
        {

            LightSkyEquip.SetActive(true);
            NormalSkyEquip.SetActive(false);
            WhiteSkyEquip.SetActive(false);
            UltravioletSkyEquip.SetActive(false);
            SunshineSkyEquip.SetActive(false);

        }
        else if (sm.lastpressedskies == 1)
        {

            LightSkyEquip.SetActive(false);
            NormalSkyEquip.SetActive(true);
            WhiteSkyEquip.SetActive(false);
            UltravioletSkyEquip.SetActive(false);
            SunshineSkyEquip.SetActive(false);

        }
        else if (sm.lastpressedskies == 2)
        {

            LightSkyEquip.SetActive(false);
            NormalSkyEquip.SetActive(false);
            WhiteSkyEquip.SetActive(true);
            UltravioletSkyEquip.SetActive(false);
            SunshineSkyEquip.SetActive(false);

        }
        else if (sm.lastpressedskies == 3)
        {

            LightSkyEquip.SetActive(false);
            NormalSkyEquip.SetActive(false);
            WhiteSkyEquip.SetActive(false);
            UltravioletSkyEquip.SetActive(true);
            SunshineSkyEquip.SetActive(false);

        }
        else if (sm.lastpressedskies == 4)
        {

            LightSkyEquip.SetActive(false);
            NormalSkyEquip.SetActive(false);
            WhiteSkyEquip.SetActive(false);
            UltravioletSkyEquip.SetActive(false);
            SunshineSkyEquip.SetActive(true);

        }

    }
    public void LightSkyF()
    {

        sm.lastpressedskies = 0;

    }
    public void NormalSkyF()
    {

        sm.lastpressedskies = 1;

    }
    public void DarkSkyF()
    {

        sm.lastpressedskies = 2;

    }
    public void UltravioletSkyF()
    {

        sm.lastpressedskies = 3;

    }
    public void SunshineSkyF()
    {

        sm.lastpressedskies = 4;

    }
}
