using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public CineMShake cms;

    public AudioSource deathsfx;

    public AudioSource pistolequip;

    public void RestartGame()
    {

        StartCoroutine("RestartGameCo");

    }

    public IEnumerator RestartGameCo()
    {

        //cms.ShakeCamera(10f, 0.05f);
        deathsfx.Play();
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(2);

    }
}
