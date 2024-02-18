using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager2 : MonoBehaviour
{
    public static AudioManager2 Instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x=> x.name == name);

        if(s==null)
        {
            Debug.Log("No se encontro la musica");
        }

        else{
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x=> x.name == name);

        if(s==null)
        {
            Debug.Log("No se encontro la musica");
        }

        else{
            sfxSource.clip = s.clip;
            sfxSource.Play();
        }
    }
}
