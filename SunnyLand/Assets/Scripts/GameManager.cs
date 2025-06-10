using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int pontos = 0;
    public TMP_Text pontosText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void AdicionarPontos(int valor)
    {
        pontos += valor;
        pontosText.text = "Pontos: " + pontos.ToString();
    }


}
