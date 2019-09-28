using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Person Pr;
         GameObject.Find("Main Camera").GetComponent<Person>();
                
         Pr.age = 30;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
