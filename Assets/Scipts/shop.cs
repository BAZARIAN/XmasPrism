using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public Text textGirl;
    public Text textBtnGirl;
    public Text textBank;

    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        Text scoreText = GameObject.FindGameObjectWithTag("globalBank").GetComponent<Text>();
        scoreText.text = score.ToString();
        searchplayers();
    }

    public void btnBoy()
    {
        PlayerPrefs.SetString("ActivePlayer", "PlayerBoy");
    }
    public void btnGirl()
    {
        if (150 <= PlayerPrefs.GetInt("Score", 0) && PlayerPrefs.GetInt("GirlPlayer") != 0)
        {
            int bank = PlayerPrefs.GetInt("Score", 0);
            PlayerPrefs.SetInt("Score", bank - 150);
            bank = PlayerPrefs.GetInt("Score", 0);
            textBank.text = bank.ToString();
            PlayerPrefs.SetInt("GirlPlayer", 1);
            searchplayers();
        }
        if (PlayerPrefs.GetInt("GirlPlayer") == 1)
        {
            PlayerPrefs.SetString("ActivePlayer", "PlayerGirl");
        }
        // else
        // {
        //     if (150 <= PlayerPrefs.GetInt("Score", 0))
        //     {
        //         int bank = PlayerPrefs.GetInt("Score", 0);
        //         PlayerPrefs.SetInt("Score", bank - 150);
        //         PlayerPrefs.SetInt("GirlPlayer", 1);
        //         searchplayers();
        //     }
        // }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void searchplayers()
    {
        if (PlayerPrefs.GetInt("GirlPlayer") == 1)
        {
            textGirl.text = "";
            textBtnGirl.text = "Выбрать";
        }
        else
        {
            textGirl.text = "150 coins";
            textBtnGirl.text = "Купить";
        }
    }
}
