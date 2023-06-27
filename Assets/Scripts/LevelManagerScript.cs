using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadNextLevel()
    {
        if (StageGenScript.level_id != Levels.levels.Count)
        {
            StageGenScript.level_id += 1;
            SceneManager.LoadScene("Level_test");
        }
    }
}
