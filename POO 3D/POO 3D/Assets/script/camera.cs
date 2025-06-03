using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform _alvo1;

    public float interpolacao = 12f;
   
    
    public float CamMoveSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
            //transform.position = new Vector3(_alvo2.position.x, _alvo2.position.y, transform.position.z);
            
            transform.position = Vector3.Lerp(
                transform.position, 
                new Vector3(_alvo1.position.x,transform.position.y,_alvo1.position.z), 
                CamMoveSpeed * Time.deltaTime);
            

        
       
        
        
        
    }
}