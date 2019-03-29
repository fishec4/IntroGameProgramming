using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class MusicVolume: MonoBehaviour {

    public AudioSource musicSource;
    public Slider musicVolume;
    public Toggle musicMute;

    private void Update()
    {
        if (musicSource)
        {   
            if (!musicVolume)
            {
                musicSource.volume = PlayerPrefs.GetFloat("MusicVolume");
            }
            else
            {
                musicSource.volume = musicVolume.value;
                PlayerPrefs.SetFloat("MusicVolume", musicVolume.value);
                if (musicMute.isOn)
                {
                    musicSource.volume = 0;
                }
            }
           

        }

       
    }
    private void Awake()
    {
        if (musicSource)
        {
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(musicSource);
        }
    }






}
