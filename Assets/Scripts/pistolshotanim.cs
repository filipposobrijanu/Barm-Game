using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolshotanim : MonoBehaviour
{

    private Animator anim;

    public void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void PistolShotAnim()
    {

        anim.SetTrigger("pistolshot");

    }
}
