using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public ParticleSystem dust;

    public Rigidbody2D rb;

    public Camera cam;

    public static Vector2 mousepos;

    public GameObject deathgroundact;

    public CursorManager crm;

    public ScoreManager sm;

    public void Start()
    {

        if(sm.lastpressedskies == 0)
        {

            crm.CursorTex1();

        }
        else if (sm.lastpressedskies == 1)
        {

            crm.CursorTex();

        }
        else if (sm.lastpressedskies == 2)
        {

            crm.CursorTex1();

        }
        else if (sm.lastpressedskies == 3)
        {

            crm.CursorTex();

        }
        else if (sm.lastpressedskies == 4)
        {

            crm.CursorTex1();

        }

    }

    void Update()
    {

        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }

    private void FixedUpdate()
    {
        Vector2 lookdir = mousepos - rb.position;

        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg;
        if (angle <= -90)
        {

            transform.localScale = new Vector3((float)0.15, (float)-0.15);

        }
        else if (angle >= 90)
        {

            transform.localScale = new Vector3((float)0.15, (float)-0.15);

        }
        else
        {

            transform.localScale = new Vector3((float)0.15, (float)0.15);

        }

        if (transform.localPosition.x <= -10.5)
        {

            transform.position = new Vector3((float)10.5, transform.localPosition.y);

        }
        else if (transform.localPosition.x >= 10.5)
        {

            transform.position = new Vector3((float)-10.5, transform.localPosition.y);

        }

        rb.rotation = angle;

        if (transform.localPosition.y <= -4.5)
        {

            deathgroundact.gameObject.SetActive(true);

        }
        else if (transform.localPosition.y > -4.5)
        {

            deathgroundact.gameObject.SetActive(false);

        }

    }

    public void CreateDust()
    {

        dust.Play();
    }

}
