using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int coins;

    public int score1;

    public int bullets;

    public int lastpressedskies;

    public int lastpressedguns;

    public int shotgunbuyonce;
    public int akbuyonce;
    public int sniperbuyonce;

    public PlayerData (ScoreManager sc)
    {

        coins = sc.coins;
        score1 = sc.score1;
        lastpressedskies = sc.lastpressedskies;
        lastpressedguns = sc.lastpressedguns;

        shotgunbuyonce = sc.shotgunbuyonce;
        akbuyonce = sc.akbuyonce;
        sniperbuyonce = sc.sniperbuyonce;

    }

}

