using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    public TextMeshProUGUI cointext;

    public int score1;

    public int score;

    public int coins;

    public int bullets;

    public TextMeshProUGUI highscorretext;

    public TextMeshProUGUI highscorretext1;

    public int lastpressedskies;

    public int lastpressedguns;

    public int shotgunbuyonce;
    public int akbuyonce;
    public int sniperbuyonce;

    public void Awake()
    {
        
        LoadPlayer();

    }

    public void AddScore()
    {

        score++;

    }

    public void AddCoin()
    {

        coins = coins + 100;

    }

    public void AddCoinBIG()
    {

        coins = coins + 500;

    }

    public void FixedUpdate()
    {

        SavePlayer();

        //coins += 1000;
        //score += 100;

        scoretext.text = "SCORE " + score.ToString();

        cointext.text = coins.ToString();

        highscorretext.text = score1 + " HS";

        highscorretext1.text = score1 + " HS";

        if (score > score1)
        {

            score1 = score;

        }

    }

    public void SavePlayer()
    {

        SaveSystem.SavePlayer(this);

    }

    public void LoadPlayer()
    {

        PlayerData data = SaveSystem.LoadPlayer();

        coins = data.coins;
        score1 = data.score1;
        lastpressedskies = data.lastpressedskies;
        lastpressedguns = data.lastpressedguns;

        shotgunbuyonce = data.shotgunbuyonce;
        akbuyonce = data.akbuyonce;
        sniperbuyonce = data.sniperbuyonce;

    }

}
