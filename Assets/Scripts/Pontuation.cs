using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuation : MonoBehaviour
{
    public Text textoItensBons;
    public Text textoItensRuins;
    public Text ptsTotal;
    public Text tempoTotal;
  

    public static int quantidadeObjetosBons = 0;
    public static int quantidadeObjetosRuins = 0;
    public static float puntosTotales = 0;
    public static float playerScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        puntosTotales = ((quantidadeObjetosBons * 22) - (quantidadeObjetosRuins * 22));
        textoItensBons.text = quantidadeObjetosBons.ToString();
        textoItensRuins.text = quantidadeObjetosRuins.ToString();
        ptsTotal.text = puntosTotales.ToString();
        tempoTotal.text = (playerScore/60).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
