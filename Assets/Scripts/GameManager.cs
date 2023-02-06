using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    void Start()
    {
    }


    //SPLASH SCENE
    public void MenuScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        Debug.Log("MENU");
    }

    //MAIN MENU
    public void PlayScene()
    {
        Debug.Log("PLAY");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Easy");
    }
    public void DifficultyScene()
    {
        Debug.Log("DIFFICULTY");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Difficulty");
    }
    public void SettingsScene()
    {
        Debug.Log("SETTINGS");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Settings");
        
    }

    //DIFFICULTY 
    public void EASY()
    {
        Debug.Log("EASY");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Easy");
    }

    public void MEDIUM()
    {
        Debug.Log("MEDIUM");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Medium");
    }

    public void HARD()
    {
        Debug.Log("HARD");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Hard");
    }

    public void BACKBTN()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }


    public void RULES()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Rules");
    }
    public void ABOUTUS()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Aboutus");
    }


    public void ExitScene()
    {
        Application.Quit();
    }


}
