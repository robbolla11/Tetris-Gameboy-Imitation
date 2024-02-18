using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            AudioManager.Instance.PlayMusic("MusicaInicio");
        }
    }

    public void Juego()
    {
        AudioManager.Instance.musicSource.Stop();
        SceneManager.LoadSceneAsync(1);
    }


    public void Salir()
    {
        Application.Quit();
    }

    public void MenuInicio()
    {
        SceneManager.LoadSceneAsync(0);
    }

}

