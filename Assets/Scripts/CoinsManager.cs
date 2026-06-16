using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{

    public ScoreManager sm;

    public Button Sniper;
    public Button Shotgun;
    public Button Pistol;
    public Button AK;

    public GameObject PistolEquip;
    public GameObject ShotgunEquip;
    public GameObject AKEquip;
    public GameObject SniperEquip;

    public void Update()
    {

        if (sm.coins > 2500)
        {

            Sniper.interactable = true;

        }
        else
        {

            Sniper.interactable = false;

        }

        if (sm.coins > 300)
        {

            Shotgun.interactable = true;

        }
        else
        {

            Shotgun.interactable = false;

        }

        if (sm.coins > 1000)
        {

            AK.interactable = true;

        }
        else
        {

            AK.interactable = false;

        }

        if (sm.shotgunbuyonce == 1)
        {

            Shotgun.interactable = true;

        }
        if (sm.akbuyonce == 1)
        {

            AK.interactable = true;

        }
        if (sm.sniperbuyonce == 1)
        {

            Sniper.interactable = true;

        }

        Pistol.onClick.AddListener(PistolF);
        Shotgun.onClick.AddListener(ShotgunF);
        AK.onClick.AddListener(AKF);
        Sniper.onClick.AddListener(SniperF);

        if (sm.lastpressedguns == 0)
        {

            PistolEquip.SetActive(true);
            ShotgunEquip.SetActive(false);
            AKEquip.SetActive(false);
            SniperEquip.SetActive(false);

        }
        else if (sm.lastpressedguns == 1)
        {

            PistolEquip.SetActive(false);
            ShotgunEquip.SetActive(true);
            AKEquip.SetActive(false);
            SniperEquip.SetActive(false);

        }
        else if (sm.lastpressedguns == 2)
        {

            PistolEquip.SetActive(false);
            ShotgunEquip.SetActive(false);
            AKEquip.SetActive(true);
            SniperEquip.SetActive(false);

        }
        else if (sm.lastpressedguns == 3)
        {

            PistolEquip.SetActive(false);
            ShotgunEquip.SetActive(false);
            AKEquip.SetActive(false);
            SniperEquip.SetActive(true);

        }

    }
    public void PistolF()
    {

        sm.lastpressedguns = 0;

    }
    public void ShotgunF()
    {

        sm.lastpressedguns = 1;
        if (sm.shotgunbuyonce == 0)
        {

            sm.coins = sm.coins - 300;
            sm.shotgunbuyonce = 1;

        }

    }
    public void AKF()
    {

        sm.lastpressedguns = 2;
        if (sm.akbuyonce == 0)
        {

            sm.coins = sm.coins - 1000;
            sm.akbuyonce = 1;

        }

    }
    public void SniperF()
    {

        sm.lastpressedguns = 3;
        if (sm.sniperbuyonce == 0)
        {

            sm.coins = sm.coins - 10000;
            sm.sniperbuyonce = 1;

        }

    }

}
