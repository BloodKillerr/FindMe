using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesRandom : MonoBehaviour
{
    public List<Material> materials = new List<Material>();

    public List<Renderer> renderers = new List<Renderer>();

    public List<NotePicker> notePickers = new List<NotePicker>();

    public List<Sprite> noteSprites = new List<Sprite>();

    void Awake()
    {
        for (int i=0; i < materials.Count; i++)
        {
            Material temp = materials[i];
            Sprite tempSprite = noteSprites[i];
            int randomIndex = Random.Range(i, materials.Count);
            noteSprites[i] = noteSprites[randomIndex];
            materials[i] = materials[randomIndex];
            materials[randomIndex] = temp;
            noteSprites[randomIndex] = tempSprite;
        }
    }

    void Start()
    {
        for (int i=0; i < renderers.Count; i++)
        {
            renderers[i].material = materials[i];
        }

        for (int i=0; i < notePickers.Count; i++)
        {
            notePickers[i].whichNote = noteSprites[i];
        }
    }

    void Update()
    {
        
    }
}
