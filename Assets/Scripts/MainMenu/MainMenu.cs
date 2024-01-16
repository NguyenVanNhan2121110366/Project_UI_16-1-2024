using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
//using DG.Tweening;

public class ScreenUI : MonoBehaviour
{
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnSanbox;
    [SerializeField] private Button btnChallenge;
    [SerializeField] private Button btnResume;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnSetting;
    [SerializeField] private bool isSetting;
    [SerializeField] private Image SettingIMG;
    [SerializeField] private Image backGround;
    [SerializeField] private TextMeshProUGUI txtMusic;
    private string turnOn = "On";
    private string turnOff = "Off";
    [SerializeField] private bool sound;
    [SerializeField] private Button BntAds;
    [SerializeField] private Slider sliderSound;
    [SerializeField] private GameObject homeScreenUI;

    void Awake()
    {
        this.btnPlay = GameObject.Find("BntPlay").GetComponent<Button>();
        this.btnSanbox = GameObject.Find("BntSanbox").GetComponent<Button>();
        this.btnChallenge = GameObject.Find("BntChallenge").GetComponent<Button>();
        this.btnExit = GameObject.Find("BntExit").GetComponent<Button>();
        this.btnSetting = GameObject.Find("BntSetting").GetComponent<Button>();
        this.SettingIMG = GameObject.Find("Setting").GetComponent<Image>();
        this.backGround = GameObject.Find("Background").GetComponent<Image>();
        this.txtMusic = GameObject.Find("txtMusic").GetComponent<TextMeshProUGUI>();
        this.BntAds = GameObject.Find("BntAds").GetComponent<Button>();
        this.homeScreenUI = GameObject.Find("HomeScreenUI");
        this.sliderSound = GameObject.Find("SliderSound").GetComponent<Slider>();
    }
    void Start()
    {
        this.isSetting = true;
        this.SettingIMG.gameObject.SetActive(false);
        this.SettingIMG.transform.localScale = Vector2.zero;
        this.backGround.gameObject.SetActive(false);
        this.sound = true;
        if (sound)
        {
            this.txtMusic.text = "Music " + " / " + turnOn;
            sound = false;
            this.sliderSound.value = 0.5f;
        }
    }

    //Click on Play
    public void PlayClick()
    {
        Debug.Log(btnPlay.name + " was clicked");
        this.BntAds.gameObject.SetActive(false);
        this.homeScreenUI.gameObject.SetActive(false);

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
        this.backGround.gameObject.SetActive(false);

        this.SettingIMG.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        StartCoroutine(TurnOffIMG());
        //this.SettingIMG.transform.localScale = Vector2.zero;
    }

    //Click on Exit
    public void Exit()
    {
        Application.Quit();
    }

    //Check click on setting
    public void Setting()
    {
        this.btnSetting.gameObject.SetActive(false);
        this.backGround.gameObject.SetActive(true);
        this.SettingIMG.gameObject.SetActive(true);
        this.SettingIMG.transform.LeanScale(Vector2.one, 0.8f);
        StartCoroutine(Checkresume());
    }

    //Music on/off
    public void Music()
    {
        if (sound)
        {
            this.txtMusic.text = "Music " + " / " + turnOn;
            this.sliderSound.value = 0.5f;
        }

        else
        {
            this.txtMusic.text = "Music " + " / " + turnOff;
            this.sliderSound.value = 0;
        }

        sound = !sound;
    }

    IEnumerator Checkresume()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }

    IEnumerator TurnOffIMG()
    {
        yield return new WaitForSeconds(1);
        this.SettingIMG.gameObject.SetActive(false);
        this.btnSetting.gameObject.SetActive(true);
    }

    IEnumerator HomeScreen()
    {
        yield return new WaitForSeconds(1);
        this.SettingIMG.gameObject.SetActive(false);
        this.btnSetting.gameObject.SetActive(true);
        this.BntAds.gameObject.SetActive(true);
        this.homeScreenUI.gameObject.SetActive(true);
    }

    //Click on Main Menu
    public void ClickMainMenu()
    {
        Time.timeScale = 1;
        this.backGround.gameObject.SetActive(false);
        this.SettingIMG.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        StartCoroutine(HomeScreen());
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
