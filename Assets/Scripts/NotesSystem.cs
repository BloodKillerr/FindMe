using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NotesSystem : MonoBehaviour
{
    public int notesCollected = 0;

    public GameObject score, dialogue;

    public TMP_Text scoreText, dialogueText;

    public GameObject noteGraphics;

    public Image noteGraphicsImage;

    public GameObject playerCamera;

    void Start()
    {
        noteGraphics.SetActive(false);
        dialogue.SetActive(false);
        score.SetActive(true);
        dialogueText.text = "";
    }

    void Update()
    {
        scoreText.text = notesCollected + "/8";
    }

    public void PickNote(Sprite whichGFX)
    {
        notesCollected += 1;
        noteGraphicsImage.sprite = whichGFX;
        noteGraphics.SetActive(true);
        playerCamera.GetComponent<PlayerLook>().enabled = false;

        switch (notesCollected)
        {
            case 1:
                StartCoroutine(Dialogue2("Gdzie ja trafiłem?", "To miejsce przyprawia mnie o ciarki na plecach...", 2, 4));
                break;
            case 2:
                StartCoroutine(Dialogue1("Zaczyna robić się coraz dziwniej.", 3));
                break;
            case 3:
                StartCoroutine(Dialogue1("Kolejna...", 2));
                break;
            case 4:
                StartCoroutine(Dialogue2("O co tu chodzi?", "Mam tego dość!", 2, 2));
                break;
            case 5:
                StartCoroutine(Dialogue2("Czy ktoś mnie obserwuje?", "Czy ktoś mnie śledzi?", 3, 3));
                break;
            case 6:;
                StartCoroutine(Dialogue3("Co to było?", "Może się przesłyszałem?", "Tak...To pewnie tylko moja wyobraźnia...chyba...", 2, 3, 5));
                break;
            case 7:
                StartCoroutine(Dialogue1("Dość...Dość...Dość...Dość...Dość...Dość...", 5));
                break;
            case 8:
                StartCoroutine(Dialogue2("Jak tu spokojnie...", "Nic nie czuję...", 2, 2));
                break;
        }
            
    }

    IEnumerator Dialogue1 (string message, float delay)
    {
        dialogueText.text = message;
        dialogue.SetActive(true);
        yield return new WaitForSeconds(delay);
        dialogue.SetActive(false);
    }

    IEnumerator Dialogue2 (string message1, string message2, float delay1, float delay2)
    {
        dialogueText.text = message1;
        dialogue.SetActive(true);
        yield return new WaitForSeconds(delay1);
        dialogue.SetActive(false);
        StartCoroutine(Dialogue1(message2, delay2));
    }

    IEnumerator Dialogue3 (string message1, string message2, string message3, float delay1, float delay2, float delay3)
    {
        dialogueText.text = message1;
        dialogue.SetActive(true);
        yield return new WaitForSeconds(delay1);
        dialogue.SetActive(false);
        StartCoroutine(Dialogue2(message2, message3, delay2, delay3));
    }
}
