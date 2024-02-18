using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa; // Cambiado de private a public para poder asignarlo directamente desde el Inspector

    private void Start()
    {
        if (menuPausa == null)
        {
            Debug.LogError("El objeto de menú de pausa no está asignado en el Inspector.");
        }

        menuPausa.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0f)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        menuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        menuPausa.SetActive(false);
    }

    public void MenuInicio()
    {
        AudioManager2.Instance.musicSource.Stop();
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
    }
}


