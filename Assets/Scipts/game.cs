using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    private GameObject myPrefab;
    public Transform parent;
    public GameObject gameOverPanel;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        string activePLayer = PlayerPrefs.GetString("ActivePlayer", "PlayerBoy");
        if (activePLayer)
        {
            myPrefab = Resources.Load<GameObject>(activePLayer);
        }
        else
        {
            myPrefab = Resources.Load<GameObject>("PlayerBoy");
        }
        Instantiate(myPrefab, parent, true);
    }

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
