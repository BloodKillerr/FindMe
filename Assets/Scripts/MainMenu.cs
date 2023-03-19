using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject MainPanel;

    void Start()
    {
        MainPanel.SetActive(true);
    }

    void Update()
    {
    
    }

    /*public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/

    public void QuitGame()
    {
        Application.Quit();
    }

}
