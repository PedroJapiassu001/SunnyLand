using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
   public TMP_Text texto_pontos;
    int pontos = 0;
    public ParticleSystem efeito;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pontos++;
            texto_pontos.text = "Pontos:" + pontos.ToString();
            collision.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
        }
    }
}
