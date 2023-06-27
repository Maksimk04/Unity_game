using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayLevel(int id)
    {
        StageGenScript.level_id = id;
        SceneManager.LoadScene("Level_test");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
