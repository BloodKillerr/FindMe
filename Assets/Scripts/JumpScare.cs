using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public int whichJumpScare;

    [SerializeField] GameObject soundObject;

    [SerializeField] GameObject lanternSoundObject1;

    [SerializeField] GameObject lanternSoundObject2;

    [SerializeField] GameObject Light1;

    [SerializeField] GameObject Light1Glass;

    [SerializeField] GameObject Light2Glass;
    
    [SerializeField] GameObject Light2;

    [SerializeField] GameObject rocks1;

    [SerializeField] GameObject rocks2;

    [SerializeField] GameObject fireParticle;

    [SerializeField] AudioSource soundSource;

    [SerializeField] AudioSource lanternSoundSource1;

    [SerializeField] AudioSource lanternSoundSource2;

    void Start()
    {

    }

    void Update()
    {
      
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (whichJumpScare)
            {
                case 1:
                    soundObject.SetActive(true);
                    soundSource.Play();
                    Destroy(soundObject, 2f);
                    break;

                case 2:
                    lanternSoundObject1.SetActive(true);
                    lanternSoundObject2.SetActive(true);
                    lanternSoundSource1.Play();
                    lanternSoundSource2.Play();
                    Light1.SetActive(false);
                    Light1Glass.SetActive(false);
                    Light2.SetActive(false);
                    Light2Glass.SetActive(false);
                    Destroy(lanternSoundObject1, 2f);
                    Destroy(lanternSoundObject2, 2f);
                    Destroy(Light1, 2f);
                    Destroy(Light2, 2f);
                    Destroy(Light1Glass, 2f);
                    Destroy(Light2Glass, 2f);
                    break;

                case 3:
                    soundObject.SetActive(true);
                    soundSource.Play();
                    Destroy(soundObject, 2f);
                    break;

                case 4:
                    soundObject.SetActive(true);
                    soundSource.Play();
                    Destroy(soundObject, 2f);
                    rocks1.SetActive(false);
                    rocks2.SetActive(true);
                    Destroy(rocks1, 2f);
                    break;

                case 5:
                    soundObject.SetActive(true);
                    soundSource.Play();
                    fireParticle.SetActive(false);
                    Destroy(fireParticle, 2f);
                    Destroy(soundObject, 2f);
                    break;

                case 6:
                    soundObject.SetActive(true);
                    soundSource.Play();
                    Destroy(soundObject, 4f);
                    break;

                case 7:
                    soundObject.SetActive(true);
                    soundSource.Play();
                    Destroy(soundObject, 2f);
                    break;

                case 8:
                    soundObject.SetActive(true);
                    soundSource.Play();
                    Destroy(soundObject, 2f);
                    break;
            }

            Destroy(gameObject, 1f);
        }
    }
}
