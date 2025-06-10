using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int pontos = 10;
    public GameManager gameManager;
    public ParticleSystem coletavelParticle;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pontos:" + pontos);
    }

    

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D outroObjeto)
    {
        if(outroObjeto.CompareTag("Player"))
        {   
            gameManager.AdicionarPontos(pontos); // Chama o método do GameManager para adicionar pontos

            outroObjeto.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f); // Aumenta o tamanho do jogador ao coletar o item
            Instantiate(coletavelParticle, transform.position, Quaternion.identity); // Instancia a partícula de coleta
            // Aqui você pode adicionar lógica para aumentar a pontuação do jogador
            Destroy(gameObject); // Destroi o coletável após ser coletado
        }
        
    }
}
