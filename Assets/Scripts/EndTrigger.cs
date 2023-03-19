using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject LMBImage;

    public GameObject blackScreen;

    public GameObject endgameText;

    public GameObject pauseManager;

    public GameObject Player;

    public GameObject playerCamera;

    public GameObject Flashlight;

    public GameObject soundObject;

    private PauseMenu pauseMenu;

    private PlayerLook playerLookScript;

    private PlayerMove playerMoveScript;

    private FlashLight flashLightScript;

    public AudioSource audioSource;

    public GameObject flashlightLight;

    private bool triggered;
    
    void Start()
    {
        pauseMenu = pauseManager.GetComponent<PauseMenu>();

        playerLookScript = playerCamera.GetComponent<PlayerLook>();

        playerMoveScript = Player.GetComponent<PlayerMove>();

        flashLightScript = Flashlight.GetComponent<FlashLight>();

        soundObject.SetActive(false);

        blackScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && LMBImage.activeSelf == true && triggered == true)
        {
            playerLookScript.enabled = false;
            playerMoveScript.enabled = false;
            flashLightScript.enabled = false;
            Destroy(LMBImage);
            Destroy(endgameText);
            Destroy(flashlightLight);
            soundObject.SetActive(true);
            audioSource.Play();
            StartCoroutine(EndChange(3, 5f, 4f));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LMBImage.SetActive(true);
            triggered = true;
            pauseMenu.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LMBImage.SetActive(false);
            triggered = false;
            pauseMenu.enabled = true;
        }
    }

    IEnumerator EndChange(int sceneIndex, float delay1, float delay2)
    {
        yield return new WaitForSeconds(delay1);
        blackScreen.SetActive(true);
        soundObject.SetActive(false);
        Destroy(soundObject, 1f);
        yield return new WaitForSeconds(delay2);
        SceneManager.LoadScene(sceneIndex);
    }
}
