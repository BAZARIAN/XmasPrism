using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("SampleScene");// � �������� �������� ����� �� ������� �������������� �������
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void ShopOpen()
    {
        SceneManager.LoadScene("Shop");
    }
    public void MenuOpen()
    {
        SceneManager.LoadScene("Menu");
    }
}