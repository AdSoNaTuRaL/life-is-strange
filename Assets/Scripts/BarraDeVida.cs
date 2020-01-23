using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Image BarraDeFelicidade;
    public static float felicidadeAtual, felicidadeMaxima = 220;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BarraDeFelicidade.rectTransform.sizeDelta = new Vector2(felicidadeAtual, 40);

    }
}
