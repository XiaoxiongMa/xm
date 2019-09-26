using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public string playerName;
    private int myNumber;
    public float speed = 5;
    public GameObject player;
    public Color playercolor = Color.red;
    
    // Start is called before the first frame update
    void Start()
    {
        myNumber = AddNumbers(a: 10, b: 5);
        Instantiate(original: ConfigGameObject());
    }

    private GameObject ConfigGameObject()
    {
        var newplayer = Instantiate(player);
        newplayer.layer = 0;
        newplayer.active = true;
        newplayer.tag = "player";
        newplayer.transform.position = Vector3.zero;
        newplayer.name = playerName;
        newplayer.GetComponent<Renderer>().material.color = playercolor;

        return gameObject;
    }
    private string WelcomPlayer()
    {    
        //Add player to database;
        //give player weapons;
        return playerName + "Welcome to the game!";
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = IncreaseSpeed(multiplier: 2);
    }

    private float IncreaseSpeed(float multiplier)
    {
        return speed * multiplier;
    }
    private int AddNumbers(int a , int b)
    {
        print(message: a + b);
        return a + b;
       
    }
}
