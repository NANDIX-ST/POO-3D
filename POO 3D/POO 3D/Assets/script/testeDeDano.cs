using System;
using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    private Personagem personagem;
    
    private void OnCollisionEnter(Collision colisao)
    {
        Debug.Log(colisao.gameObject.name);
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            
            int energia_atual = personagem.EnergiaDoPersonagem() 
                                - colisao.gameObject.GetComponent<Inimigo>().DanoDonimigo();
           
            personagem.AtribuirEnergia(energia_atual);
           
            Debug.Log("O personagem " +personagem.NomeDoPersonagem()+" tem agora "+personagem.EnergiaDoPersonagem());
        }
    }

    void Start()
    {
        personagem = GetComponent<Personagem>();
    }

  
    void Update()
    {
        
    }
}