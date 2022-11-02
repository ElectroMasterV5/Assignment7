using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SounController : MonoBehaviour
{
    public static SounController Instance;
    public AudioSource Sound;

    void Awake() {
        if(Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip){
        Sound.PlayOneShot(clip);
    }
}
