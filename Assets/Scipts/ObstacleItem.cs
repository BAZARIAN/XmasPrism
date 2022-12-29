using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.UIElements;
using Unity.VisualScripting;
using System.Drawing;

// объект при столкновении с объектом который имеет тэг Danger умирает
public class ObstacleItem : MonoBehaviour
{
    public float currentValue = 3;
    private Text scoreText;
    private Text scoreTextGameOver;
    private int coins = 0;
    private void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("bank").GetComponent<Text>();
    }
    private void GetDamage(float damage)//float value
    {
        currentValue -= damage;
        GetComponent<Renderer>().material.color = UnityEngine.Color.Lerp(UnityEngine.Color.white, UnityEngine.Color.red, 1/currentValue);
        if(currentValue<=0)
        {
            int score = PlayerPrefs.GetInt("Score", 0);
            PlayerPrefs.SetInt("Score", score + coins);
            Destroy(gameObject);
        }
    }

    private void GetCoin(int money)
    {
        coins += money;
        scoreText.text = coins.ToString();
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "Danger") {
            Destroy(collision.gameObject);
            GetDamage(1);
        }
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            GetCoin(1);
        }
    }
}