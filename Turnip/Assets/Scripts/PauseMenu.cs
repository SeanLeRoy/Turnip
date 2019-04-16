using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (GameIsPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void SaveAndQuit()
    {
        GameState gameState = GameObject.Find("GameState").GetComponent<GameState>();
        gameState.playerPosition = GameObject.Find("Parker").transform.position;
        gameState.SavePlayer();
        Debug.Log("In Save And Quit");
        Debug.Log(gameState.playerPosition);

        // Can't quit in unity editor so check this log
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
