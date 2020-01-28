using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensBons : MonoBehaviour
{
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
        if (other.CompareTag("Player"))
        {
            BarraDeVida.felicidadeAtual += 22;
            Pontuation.quantidadeObjetosBons++;
            if(BarraDeVida.felicidadeAtual > BarraDeVida.felicidadeMaxima)
            {
                BarraDeVida.felicidadeAtual = BarraDeVida.felicidadeMaxima;
            }
            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject, 1); 
        }
    }
}
