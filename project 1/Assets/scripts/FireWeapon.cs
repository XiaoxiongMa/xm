using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public ApplyForce ammo;
    public void Fire()
    {
        Instantiate(original:ammo,transform.position,Quaternion.identity);
    }
}