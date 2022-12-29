using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bankGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text text = gameObject.GetComponent<Text>();
        Text textFight = GameObject.FindGameObjectWithTag("bank").GetComponent<Text>();
        text.text = textFight.text;
    }
}
