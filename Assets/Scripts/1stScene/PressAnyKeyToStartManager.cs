using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKeyToStartManager : MonoBehaviour
{
    public AudioSource presssfx;

    public GameObject blackscreen;

    void Update()
    {
        if (Input.anyKeyDown)
        {

            LoadMenu();

        }
    }

    public void LoadMenu()
    {

        StartCoroutine("LoadMenuCo");

    }

    public IEnumerator LoadMenuCo()
    {

        blackscreen.SetActive(true);
        presssfx.Play();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);

    }
}
