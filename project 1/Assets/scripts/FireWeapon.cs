using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public ApplyForce ammo;
    
    void Update()
    {
        if (Input.GetButtonDown("Firel")) 
        {
            Instantiate(original:ammo,transform.position,Quaternion.identity);
        }
    }
}
