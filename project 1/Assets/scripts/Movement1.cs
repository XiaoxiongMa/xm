using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement1 : MonoBehaviour
{

    private CharacterController Controller;
    public float movespeed = 10f, gravity = 9.81f, jumpspeed = 30f;
    private int jumpCount;
    public int jumpCountMax;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        position.x = movespeed*Input.GetAxis("Horizontal");
        position.y -= gravity;

        if (Controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax) 
        {
            position.y = jumpspeed;
            jumpCount++;
        }
        Controller.Move(position*Time.deltaTime);
        
    }
}
