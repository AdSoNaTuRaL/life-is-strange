using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ExportTxt : MonoBehaviour
{
    int i;
    void CreatText()
    {
        //Path of the file
        string path = Application.dataPath + "/Information.txt";
        //Create a file if it doesn't exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Jogo " + i +"\n\n");
        }
        //Content of the file
        string content = "Jugado en: " + System.DateTime.Now + "\n" + 
            "Numero de objetos buenos cogidos: " + Pontuation.quantidadeObjetosBons + "\n" + 
            "Numero de objetos malos cogidos: " + Pontuation.quantidadeObjetosRuins + "\n" +
            "Puntos totales obtenidos: " + Pontuation.puntosTotales + "\n" +
            "Tiempo total del juego: " + Pontuation.playerScore/60 + " min" + "\n\n\n";
        //Add some to text to it
        File.AppendAllText(path, content);
    }
    // Start is called before the first frame update
    void Start()
    {
        i++;
        CreatText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
