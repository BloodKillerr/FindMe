using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public bool isOn = false;
    public GameObject lightSource;
    public AudioSource audioSource;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isOn == false)
            {
                lightSource.SetActive(true);
                audioSource.Play();
                isOn = true;
            }
            else if (isOn == true)
            {
                lightSource.SetActive(false);
                audioSource.Play();
                isOn = false;
            }
        }
    }
}
