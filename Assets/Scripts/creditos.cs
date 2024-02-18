using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour
{
    public GameObject Creditos;

    private void Start()
    {
        if (Creditos == null)
        {
            Debug.LogError("El objeto de menú de pausa no está asignado en el Inspector.");
        }

        Creditos.SetActive(false);
    }

    public void ActivarMenuPausa()
    {
        Pausa();
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        Creditos.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        Creditos.SetActive(false);
    }

}
