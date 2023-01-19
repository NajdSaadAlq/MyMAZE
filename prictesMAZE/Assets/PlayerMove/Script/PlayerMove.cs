using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   
    private float speed = 10 ;
    private Rigidbody rb;
    
    private void Start()// Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()// Update is called once per frame
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * speed ;
        float verticalInput = Input.GetAxisRaw("Vertical") * speed ;

        Vector3 movement = new Vector3(horizontalInput,0,verticalInput);

        rb.velocity = movement;
        

        
    }
    
}
