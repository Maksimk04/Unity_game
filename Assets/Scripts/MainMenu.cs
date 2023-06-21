using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayLvl1()
    {
        SceneManager.LoadScene("level1");
    }
    public void PlayLvl2()
    {
        SceneManager.LoadScene("level2");
    }
    public void PlayLvl3()
    {
        SceneManager.LoadScene("level3");
    }
    public void PlayLvl4()
    {
        SceneManager.LoadScene("level4");
    }
    public void PlayLvl5()
    {
        SceneManager.LoadScene("level5");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
