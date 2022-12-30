using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("BoyPlayer", 1);
        PlayerPrefs.SetInt("Score", 500);
        if (PlayerPrefs.GetInt("BoyPlayer") == 1 && PlayerPrefs.GetInt("GirlPlayer") == 0)
        {
            PlayerPrefs.SetString("ActivePlayer", "BoyPlayer");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
