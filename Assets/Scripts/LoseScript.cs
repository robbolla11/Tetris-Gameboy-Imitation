using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    private void Start()
    {
        AudioManager2.Instance.PlaySFX("Lose");
    }

    public void Juego()
    {
        AudioManager2.Instance.sfxSource.Stop();
        SceneManager.LoadSceneAsync(1);
    }
    public void MenuInicio()
    {
        AudioManager2.Instance.sfxSource.Stop();
        SceneManager.LoadSceneAsync(0);
    }
}
