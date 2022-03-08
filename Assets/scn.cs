using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scn : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
