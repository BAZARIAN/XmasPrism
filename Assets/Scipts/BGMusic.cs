using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    private static BGMusic BGMusics;
    void Awake()
    {
        if (BGMusics == null)
        {
            BGMusics = this;
            DontDestroyOnLoad(BGMusics);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
