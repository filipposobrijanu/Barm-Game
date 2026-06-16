using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public CursorManager crm;

    public GameObject playButton;
    public GameObject cosmeticsButton;
    public GameObject settingsButton;
    public GameObject quitButton;

    public GameObject settingsMenu;
    public GameObject cosmeticsMenu;

    public void Awake()
    {

        crm.CursorTex();       

    }

    public void LoadPlayScreen()
    {

        StartCoroutine("LoadPlayScreenCo");

    }

    public IEnumerator LoadPlayScreenCo()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);

    }

    public void QuitGame()
    {

        Application.Quit();

    }

    public void Settings()
    {

        playButton.gameObject.SetActive(false);
        cosmeticsButton.gameObject.SetActive(false);
        settingsButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);

        settingsMenu.gameObject.SetActive(true);

    }

    public void Cosmetics()
    {

        playButton.gameObject.SetActive(false);
        cosmeticsButton.gameObject.SetActive(false);
        settingsButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);

        cosmeticsMenu.gameObject.SetActive(true);

    }

    public void BackCosmetics()
    {

        playButton.gameObject.SetActive(true);
        cosmeticsButton.gameObject.SetActive(true);
        settingsButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);

        cosmeticsMenu.gameObject.SetActive(false);

    }

    public void BackSettings()
    {

        playButton.gameObject.SetActive(true);
        cosmeticsButton.gameObject.SetActive(true);
        settingsButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);

        settingsMenu.gameObject.SetActive(false);

    }

    public GameObject vigchromabb;

    public void SetQualityLow()
    {

        QualitySettings.SetQualityLevel(0);
        vigchromabb.SetActive(false);       

    }

    public void SetQualityMedium()
    {

        QualitySettings.SetQualityLevel(1);
        vigchromabb.SetActive(true);

    }

    public void SetQualityHigh()
    {

        QualitySettings.SetQualityLevel(2);
        vigchromabb.SetActive(true);

    }

    public AudioMixer audioMixer;

    public bool isFullscreen = true;

    [SerializeField] private Slider volumeSlider;

    [SerializeField] private Toggle fullscreenToggle;

    public void SetFullscreen(bool isFullscreen)
    {

        Screen.fullScreen = isFullscreen;

        if (isFullscreen == false)
        {

            PlayerPrefs.SetInt("togglestate", 1);

        }
        else
        {

            isFullscreen = true;
            PlayerPrefs.SetInt("togglestate", 0);

        }

    }

    private int screenInt;

    public void SaveFullscreen()
    {

        screenInt = PlayerPrefs.GetInt("togglestate");

        if(screenInt == 1)
        {

            fullscreenToggle.isOn = false;
            isFullscreen = false;

        }
        else
        {

            fullscreenToggle.isOn = true;

        }
    }

    public void Update()
    {

        LoadValue();
        SaveFullscreen();

    }

    public void SetVolume(float volumeValue)
    {

        audioMixer.SetFloat("volumeValue", volumeValue);
        volumeTextUI.text = Mathf.Round(volumeValue) + "dB";
        SaveVolume();

    }

    public void SaveVolume()
    {

        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("volumeValue", volumeValue);
        LoadValue();

    }

    public void LoadValue()
    {

        float volumeValue = PlayerPrefs.GetFloat("volumeValue");
        volumeSlider.value = volumeValue;

    }

    public TextMeshProUGUI volumeTextUI = null;

    public void Youtube()
    {

        Application.OpenURL("https://www.youtube.com/c/monkassvisuals");

    }
    public void Instagram()
    {

        Application.OpenURL("https://www.instagram.com/monkassvisuals/");

    }

    public void Twitter()
    {

        Application.OpenURL("https://twitter.com/MonkassDev");

    }

    public GameObject quitMenuUI;

    public Animator anim;

    public void QuitButton()
    {

        quitMenuUI.SetActive(true);
        playButton.SetActive(false);
        cosmeticsButton.SetActive(false);
        quitButton.SetActive(false);
        settingsButton.SetActive(false);
        anim.SetTrigger("QuitMenu");


    }

    public void BackQuitButton()
    {

        quitMenuUI.SetActive(false);
        cosmeticsButton.SetActive(true);
        playButton.SetActive(true);
        settingsButton.SetActive(true);
        quitButton.SetActive(true);


    }
}
