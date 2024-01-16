using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
//using DG.Tweening;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnSanbox;
    [SerializeField] private Button btnChallenge;
    [SerializeField] private Button btnResume;
    //[SerializeField] private Button btnExit;
    [SerializeField] private Button btnSetting;
    [SerializeField] private Image SettingIMG;
    [SerializeField] private Image backGround;
    [SerializeField] private TextMeshProUGUI txtSound;
    private string turnOn = "On";
    private string turnOff = "Off";
    [SerializeField] private bool sound;
    [SerializeField] private Button BntAds;
    [SerializeField] private Slider sliderSound;
    [SerializeField] private GameObject homeScreenUI;

    void Awake()
    {
        btnPlay = GameObject.Find("BntPlay").GetComponent<Button>();
        btnSanbox = GameObject.Find("BntSanbox").GetComponent<Button>();
        btnChallenge = GameObject.Find("BntChallenge").GetComponent<Button>();
        //this.btnExit = GameObject.Find("BntExit").GetComponent<Button>();
        btnSetting = GameObject.Find("BntSetting").GetComponent<Button>();
        SettingIMG = GameObject.Find("Setting").GetComponent<Image>();
        backGround = GameObject.Find("Background").GetComponent<Image>();
        txtSound = GameObject.Find("txtOn/Off").GetComponent<TextMeshProUGUI>();
        BntAds = GameObject.Find("BntAds").GetComponent<Button>();
        homeScreenUI = GameObject.Find("HomeScreenUI");
        sliderSound = GameObject.Find("SliderSound").GetComponent<Slider>();
    }
    void Start()
    {
        SettingIMG.gameObject.SetActive(false);
        //SettingIMG.transform.localScale = Vector2.zero;
        backGround.gameObject.SetActive(false);
        sound = true;
        if (sound)
        {
            txtSound.text = turnOn;
            sound = false;
            sliderSound.value = 0.5f;
        }
    }

    //Click on Play
    public void PlayClick()
    {
        Debug.Log(btnPlay.name + " was clicked");
        BntAds.gameObject.SetActive(false);
        homeScreenUI.gameObject.SetActive(false);

    }

    //Click on Sanbox
    public void SanboxClick()
    {
        Debug.Log(btnSanbox.name + " was clicked");
    }

    //Click on Challenge
    public void ChallengeClick()
    {
        Debug.Log(btnChallenge.name + " was clicked");
    }

    //Click on Resume
    public void Resume()
    {
        Time.timeScale = 1;
        backGround.gameObject.SetActive(false);
        SettingIMG.gameObject.SetActive(false);
        btnSetting.gameObject.SetActive(true);
    }

    //Click on Exit
    public void Exit()
    {
        //Debug.Log(btnExit.name + " was clicked");
        Application.Quit();
    }

    //Check click on setting
    public void Setting()
    {
        btnSetting.gameObject.SetActive(false);
        backGround.gameObject.SetActive(true);
        SettingIMG.gameObject.SetActive(true);
        Time.timeScale = 0;

    }

    //Music on/off
    public void Music()
    {
        if (sound)
        {
            txtSound.text = turnOn;
            sliderSound.value = 0.5f;
        }

        else
        {
            txtSound.text = turnOff;
            sliderSound.value = 0;
        }

        sound = !sound;
    }


    //Click on Main Menu
    public void ClickMainMenu()
    {
        Time.timeScale = 1;
        backGround.gameObject.SetActive(false);
        //SettingIMG.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        SettingIMG.gameObject.SetActive(false);
        btnSetting.gameObject.SetActive(true);
        BntAds.gameObject.SetActive(true);
        homeScreenUI.gameObject.SetActive(true);
    }

    //Click on Shop
    public void Shop()
    {
        Debug.Log("Shop was clicked");
    }

    //Click on Collcetion
    public void Collcetion()
    {
        Debug.Log("Collcetion was clicked");
    }

    //Click on Ads
    public void Ads()
    {
        Debug.Log("Ads was clicked");
    }

}
