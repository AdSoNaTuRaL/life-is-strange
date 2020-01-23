using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public  GameObject PainelPause;
    public  GameObject PainelInfo;

    public bool isPause = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.exibirPainel)
        {
            PainelInfo.SetActive(true);
            Time.timeScale = 0;
        }
    }

    //Logica do Pause
    public void Pause()
    {
        if (isPause)
        {
            PainelPause.SetActive(false);
            Time.timeScale = 1;
            isPause = false;
        }
        else
        {
            Time.timeScale = 0;
            PainelPause.SetActive(true);
            isPause = true;
        }
        
    }

    //Botao OK quando pressionado
    public void Okay()
    {
        Player.exibirPainel = false;
        PainelInfo.SetActive(false);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
