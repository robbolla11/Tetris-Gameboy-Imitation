using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
{
    if (Instance == null)
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            AudioManager.Instance.PlayMusic("MusicaInicio");
        }
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
        Sound s = Array.Find(musicSounds, x=> x.name == name);

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
