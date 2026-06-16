using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{

    public AudioSource clicksfx;
    public AudioSource click1sfx;
    public AudioSource click2sfx;
    public AudioSource click3sfx;

    public void Click()
    {

        clicksfx.Play();

    }
    public void Click1()
    {

        click1sfx.Play();

    }
    public void Click2()
    {

        click2sfx.Play();

    }
    public void Click3()
    {

        click3sfx.Play();

    }
}
