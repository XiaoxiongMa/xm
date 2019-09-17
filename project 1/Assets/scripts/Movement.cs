using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = -3f;
    public float jumpspeed = 10f;


    private int jumpcount = 2;
    
    
    private Vector3 position;
    public CharacterController controller;
 
    void Update()
    {
        position.x = speed*Input.GetAxis("Horizontal");
        
        if (!controller.isGrounded)
        {
            position.y -= gravity;
        }
        else
        {
            position.y = 0;
            jumpcount = 2;
        }
        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpspeed;
        }

        controller.Move(position*Time.deltaTime);
        
    }
} 
