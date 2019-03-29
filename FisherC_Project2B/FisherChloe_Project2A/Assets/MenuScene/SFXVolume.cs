using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SFXVolume : MonoBehaviour
{
    
    public AudioSource sfxSource1;
    public AudioSource sfxSource2;
    public Slider sfxVolume;
    public Toggle sfxMute;

    private void Update()
    {
        if (sfxSource1 & sfxSource2)
        {
            if (!sfxVolume)
            {
                sfxSource1.volume = PlayerPrefs.GetFloat("SFXVolume");
                sfxSource2.volume = PlayerPrefs.GetFloat("SFXVolume");
            }
            else
            {
                sfxSource1.volume = sfxVolume.value;
                sfxSource2.volume = sfxVolume.value;
                PlayerPrefs.SetFloat("SFXVolume", sfxVolume.value);
                if (sfxMute.isOn)
                {
                    sfxSource1.volume = 0;
                    sfxSource2.volume = 0;
                }
            }


        }

    }
    private void Awake()
    {
        if (sfxSource2 & sfxSource1)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}