using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private MovimentoPlayer movimentoPlayer;
    public Animator animator;
    
     void Start()
    {
        movimentoPlayer = gameObject.GetComponent<MovimentoPlayer>();
        animator.speed = 5;
    }
   void Update()
    {
            animator.SetBool("Andando", movimentoPlayer.EstraAndando());
           
    }
}
