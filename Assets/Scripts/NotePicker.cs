using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotePicker : MonoBehaviour
{
    public GameObject noteSystemHolder;

    private NotesSystem noteSystem;

    public GameObject lmbImage;

    public GameObject pauseMenuManager;

    public GameObject player;

    private PlayerMove playerMovement;

    private PauseMenu pauseMenu;

    public Sprite whichNote;

    public Sprite blankSprite;

    public bool triggered = false;

    public GameObject JSTrigger;

    void Start()
    {
        noteSystem = noteSystemHolder.GetComponent<NotesSystem>();

        pauseMenu = pauseMenuManager.GetComponent<PauseMenu>();

        playerMovement = player.GetComponent<PlayerMove>();

        lmbImage.SetActive(false);

        noteSystem.noteGraphicsImage.sprite = blankSprite;

        JSTrigger.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && lmbImage.activeSelf == true && triggered == true)
        {
            pauseMenu.enabled = false;
            playerMovement.enabled = false;
            lmbImage.SetActive(false);
            noteSystem.PickNote(whichNote);
        }
        else if (Input.GetMouseButtonDown(0) && lmbImage.activeSelf == false && triggered == true)
        {
            noteSystem.noteGraphics.SetActive(false);
            noteSystem.noteGraphicsImage.sprite = blankSprite;
            noteSystem.playerCamera.GetComponent<PlayerLook>().enabled = true;
            playerMovement.enabled = true;
            pauseMenu.enabled = true;
            JSTrigger.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggered = true;
            lmbImage.SetActive(true);
            pauseMenu.enabled = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lmbImage.SetActive(false);
            triggered = false;
            pauseMenu.enabled = true;
        }
    }
}
