using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour
{
    public string gleerupsUrl = "https://gleerupsportal.se/laromedel/0-teknik-1/article/e27fe4d5-f527-407e-8d3d-c3e405c161e2?page=1";

    public string youtubeUrl = "https://youtu.be/dQw4w9WgXcQ";
    public void LoadMainGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void PreGame()
    {
        SceneManager.LoadScene("Pre_Game");
    }
    
    public void CloseGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Open_Main_Menu()
    {
        SceneManager.LoadScene("Main_menu");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void gleerups()
    {
        Application.OpenURL(gleerupsUrl);
    }
    
    public void RickRoll()
    {
        Application.OpenURL(youtubeUrl);
    }

        // Update is called once per frame
    void Update()
    {
        
    }
}
