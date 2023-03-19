using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pausePanel;

    public GameObject playerCamera;

    public GameObject optionsPanel;

    public GameObject mainPanel;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        playerCamera.GetComponent<PlayerLook>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        optionsPanel.SetActive(false);
        mainPanel.SetActive(true);
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        
    }

    public void Pause()
    {
        playerCamera.GetComponent<PlayerLook>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
