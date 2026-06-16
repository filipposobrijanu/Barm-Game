using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public TextMeshProUGUI bulletUI;

    public AudioSource pistolshotsfx;

    public AudioSource pistolreloadsfx;

    public AudioSource pistolnoammosfx;

    public AudioSource bigcoinsfx;

    public AudioSource coinsfx;

    public Rigidbody2D rb;

    public BulletSpawner bs;

    public float shotforce;

    public FPSCounter fps;

    public GameObject player;

    public Restart rs;

    public PlayerMovement pm;

    public pistolshotanim psa;

    public CineMShake cms;

    public ScoreManager sm;

    private Animator anim;

    public AudioClip pistolshot;
    public AudioClip shotgunshot;
    public AudioClip akshot;
    public AudioClip snipershot;

    public AudioClip pistolreload;
    public AudioClip shotgunreload;
    public AudioClip akreload;
    public AudioClip sniperreload;

    public AudioClip pistolnoammo;
    public AudioClip shotgunnoammo;
    public AudioClip aknoammo;
    public AudioClip snipernoammo;

    public AudioClip pistolequip;
    public AudioClip shotgunequip;
    public AudioClip akequip;
    public AudioClip sniperequip;

    private void Awake()
    {

        anim = GetComponent<Animator>();
        fps.SaveFPS();          
        //bullets = 1;

    }

    public void Start()
    {
        if(sm.lastpressedguns == 0)
        {

            pistolshotsfx.clip = pistolshot;
            pistolreloadsfx.clip = pistolreload;
            pistolnoammosfx.clip = pistolnoammo;
            rs.pistolequip.clip = pistolequip;
            sm.bullets = 3;

        }
        else if (sm.lastpressedguns == 1)
        {

            pistolshotsfx.clip = shotgunshot;
            pistolreloadsfx.clip = shotgunreload;
            pistolnoammosfx.clip = shotgunnoammo;
            rs.pistolequip.clip = shotgunequip;

            sm.bullets = 5;

        }
        else if (sm.lastpressedguns == 2)
        {

            pistolshotsfx.clip = akshot;
            pistolreloadsfx.clip = akreload;
            pistolnoammosfx.clip = aknoammo;
            rs.pistolequip.clip = akequip;

            sm.bullets = 10;

        }
        else if (sm.lastpressedguns == 3)
        {

            pistolshotsfx.clip = snipershot;
            pistolreloadsfx.clip = sniperreload;
            pistolnoammosfx.clip = snipernoammo;
            rs.pistolequip.clip = sniperequip;

            sm.bullets = 25;

        }

        rs.pistolequip.Play();
        bs.SpawnRandBullet();

        bulletUI.text = sm.bullets.ToString();

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (sm.bullets >= 1)
            {
                cms.ShakeCamera(0.35f, .125f);
                psa.PistolShotAnim();
                pm.CreateDust();
                pistolshotsfx.Play();
                sm.bullets = sm.bullets - 1;
                bulletUI.text = sm.bullets.ToString();
                Shoot();

            }

            if (sm.bullets < 1)
            {

                pistolnoammosfx.Play();

            }

        }

    }

    void Shoot()
    {

        rb.velocity = new Vector3(PlayerMovement.mousepos.x * -1, PlayerMovement.mousepos.y * -1) * shotforce;

    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("DeathGround"))
        {

            fps.SaveFPS();
            player.gameObject.SetActive(false);
            rs.RestartGame();
            GameObject.Find("UI MENU").GetComponent<PauseMenu>().enabled = false;

        }

        if (other.gameObject.CompareTag("Bullet"))
        {

            sm.AddScore();
            pistolreloadsfx.Play();
            sm.bullets++;
            bulletUI.text = sm.bullets.ToString();
            bs.SpawnRandBullet();

        }

        if (other.gameObject.CompareTag("Enemy"))
        {

            fps.SaveFPS();
            player.gameObject.SetActive(false);
            rs.RestartGame();       

        }

        if (other.gameObject.CompareTag("Coin"))
        {

            coinsfx.Play();
            sm.AddCoin();
            anim.SetTrigger("coinplayer");

        }

        if (other.gameObject.CompareTag("BIGCoin"))
        {

            bigcoinsfx.Play();
            sm.AddCoinBIG();
            anim.SetTrigger("rainbowplayer");

        }

    }

    public void PlayerGS()
    {

        rb.bodyType = RigidbodyType2D.Static;

    }

    public void FixedUpdate()
    {
        bulletUI.text = sm.bullets.ToString();
    }
}
