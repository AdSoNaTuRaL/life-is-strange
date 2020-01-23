using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassaDeFase : MonoBehaviour
{
    public GameObject textoLivro;
    public GameObject textoFaca;
    public GameObject textoPeso;
    public GameObject textoFriends;
    public GameObject textoFruits;
    public GameObject textoMusic;
    public GameObject textoSleep;
    public GameObject textoPassaFase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && BarraDeVida.felicidadeAtual >= 132)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Player.exibirPainel = true;
            textoLivro.SetActive(false);
            textoFaca.SetActive(false);
            textoPeso.SetActive(false);
            textoFriends.SetActive(false);
            textoFruits.SetActive(false);
            textoMusic.SetActive(false);
            textoSleep.SetActive(false);
            textoPassaFase.SetActive(true);
        }
    }
}
