using UnityEngine;

public class Movimentoinimigo : MonoBehaviour
{
    private Rigidbody rigididbory;
    public float velocidade = 10;

    private GameObject player;


    public float raioDevisao = 10;
    void Start()
    {
        rigididbory = gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Movimentoinimigo>().velocidade;
        
        player = GameObject.FindWithTag("Player");
    }
    
    
    
    void Update()
    {

        if (Vector3.Distance(transform.position, player.transform.position) < raioDevisao)
        {
            transform.LookAt( player . transform.position);
            transform.position = Vector3.MoveTowards(transform.position,
            player.transform.position,
            velocidade * Time.deltaTime);
        }
    }
}