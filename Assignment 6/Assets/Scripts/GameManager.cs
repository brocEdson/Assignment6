/* Broc Edson
 * Assignment 6
 * Manages the game using singletons
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private string currentLevelName = string.Empty;

    public GameObject pauseMenu;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if(ao == null)
        {
            Debug.LogError("Unable to load scene: " + levelName);
            return;
        }
        currentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("Unable to unload scene: " + levelName);
            return;
        }
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(currentLevelName);
        if (ao == null)
        {
            Debug.LogError("Unable to unload scene: " + currentLevelName);
            return;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
