using Unity.VisualScripting.FullSerializer;
using UnityEngine;
public class teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    Caminhao caminhao = new Caminhao();

    void Start()
    {

        fusca.AtribuirNome("Fusca de Pai");
        fusca.AtribuirCor("Amarelo");
        fusca.AtribuirNumeroDeRodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("O " + fusca.NomeDoCarro() + " é " + fusca.CorDoCarro() + " ten " + fusca.NumeroDeRodas() +
                  " e custa R$" + fusca.Preco());

        
        gol.AtribuirNome("Gol do Falstão");
        gol.AtribuirCor("Verde");
        gol.AtribuirNumeroDeRodas(4);
        gol.AtribuirPreco(3000.00f);
        Debug.Log("O " + gol.NomeDoCarro());

        if (fusca.ComparPreco(gol))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());

        }

        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.AtribuirNumeroDeRodas(8);
        caminhao.AtribuirPreco(6000.00f);
        caminhao.AtribuirCor("Azul");
        caminhao.AtribuirNome("caminhão do falstão");
        
        if (fusca.ComparPreco(caminhao))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o " + caminhao.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o " + caminhao.NomeDoCarro());

        }
    }
}