using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour
{
    public void LoadMainGame()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void CloseGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("UBS_Settings");
    }

    public void Open_Main_Menu()
    {
        SceneManager.LoadScene("UBS_Main_Menu");
    }

    public void gleerups()
    {

    }
    
        // Update is called once per frame
    void Update()
    {
        
    }
}
