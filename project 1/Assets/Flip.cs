using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public Vector3Data data;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(x:0,y:180,z:0);
            data.value.x = 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(x:0,y:0,z:0);
            data.value.x = -1f;
        }
    }
}
