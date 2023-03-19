using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameManager : MonoBehaviour
{
    public GameObject noteSystemHolder;
    private NotesSystem noteSystem;

    public GameObject scoreText;
    public GameObject finalText;

    public Animator scoreAnimator;
    public Animator finalAnimator;

    public GameObject endTrigger;

    public AudioSource mainAudio;

    void Start()
    {
        noteSystem = noteSystemHolder.GetComponent<NotesSystem>();

        endTrigger.SetActive(false);
    }

    void Update()
    {
        if (noteSystem.notesCollected == 8 && finalText.activeSelf == false)
        {
            StartEndgame();
        }
    }

    public void StartEndgame()
    {
        mainAudio.enabled = false;
        scoreAnimator.SetTrigger("End");
        StartCoroutine(Wait(4f));
    }

    IEnumerator Wait (float delay)
    {
        yield return new WaitForSeconds(delay);
        finalText.SetActive(true);
        endTrigger.SetActive(true);
    }
}
