using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour 
{
    public int age;
    public string _name;

    public Person()
    {
        this.age = 20;
        this._name = "human";
        Debug.Log("i am a human");
    }


}
