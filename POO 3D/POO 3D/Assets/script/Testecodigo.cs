using UnityEngine;

public class Testecodigo : MonoBehaviour
{
 public void mensagem(string mensagem)
 {
     Debug.Log(mensagem);
 }

 public void IdadeDaPessoa(string nome, int idade)
 {
     string Fase = "A Pessoa de nome " + nome + " tem " + idade + " anos"; 
     mensagem(Fase);
 }

 void Start()
 {
     IdadeDaPessoa("joao", 15);
     IdadeDaPessoa("maria", 43);
     IdadeDaPessoa("Jose", 63);
     IdadeDaPessoa("marcia", 48);
 }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
