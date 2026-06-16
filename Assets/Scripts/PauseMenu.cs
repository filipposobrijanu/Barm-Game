using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool isPaused = false;

    public GameObject pauseMenuUI;

    public GameObject quitMenuUI;
    public GameObject resumeButton;
    public GameObject menuButton;
    public GameObject quitButton;

    public GameObject uiscore;
    public GameObject uicoin;
    public GameObject uicoin1;
    public GameObject uicoins;

    public Animator anim;

    public CursorManager crm;

    public ScoreManager sm;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {

                Resume();
                BackQuitButton();

            }
            else
            {

                Pause();

            }


        }
    }

    public void Resume()
    {

        GameObject.FindWithTag("Player").GetComponent<Shooting>().enabled = true;

        if (sm.lastpressedskies == 0)
        {

            crm.CursorTex1();
            uicoin.SetActive(true);

        }
        else if (sm.lastpressedskies == 1)
        {

            crm.CursorTex();
            uicoin1.SetActive(true);

        }
        else if (sm.lastpressedskies == 2)
        {

            crm.CursorTex1();
            uicoin.SetActive(true);

        }
        else if (sm.lastpressedskies == 3)
        {

            crm.CursorTex();
            uicoin1.SetActive(true);

        }
        else if (sm.lastpressedskies == 4)
        {

            crm.CursorTex1();
            uicoin.SetActive(true);

        }

        pauseMenuUI.SetActive(false);
        uiscore.SetActive(true);
        uicoins.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;

    }

    public void Pause()
    {

        GameObject.FindWithTag("Player").GetComponent<Shooting>().enabled = false;

        crm.CursorTex();
        pauseMenuUI.SetActive(true);
        uiscore.SetActive(false);
        uicoin.SetActive(false);
        uicoin1.SetActive(false);
        uicoins.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;

    }

    public void LoadMenu()
    {

        StartCoroutine("LoadMenuCo");

    }

    public IEnumerator LoadMenuCo()
    {

        anim.SetTrigger("GoingToMenu");
        sh.PlayerGS();
        Time.timeScale = 1f;    
        yield return new WaitForSeconds(1.3f);   
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {

        Application.Quit();

    }

    public void QuitButton()
    {

        quitMenuUI.SetActive(true);
        resumeButton.SetActive(false);
        menuButton.SetActive(false);
        quitButton.SetActive(false);
        anim.SetTrigger("QuitMenu");


    }

    public void BackQuitButton()
    {

        quitMenuUI.SetActive(false);
        resumeButton.SetActive(true);
        menuButton.SetActive(true);
        quitButton.SetActive(true);


    }

    public Shooting sh;
}
