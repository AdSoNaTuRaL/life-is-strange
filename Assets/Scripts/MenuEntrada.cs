using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEntrada : MonoBehaviour
{
    public Animator anim;
    public bool estaTocando = false;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MuteSound()
    {
        if (estaTocando)
        {
            AudioListener.pause = false;
            estaTocando = false;
        }
        else
        {
            AudioListener.pause = true;
            estaTocando = true;
        }
    }

    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/adson.n4tural");
    }

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/adsonzinhoo");
    }
}
