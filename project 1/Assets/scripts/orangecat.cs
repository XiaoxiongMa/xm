using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OrangeCat : MonoBehaviour
{
    public UnityEvent doesStuff;

    private void OnMouseDown()
    {
        doesStuff.Invoke();
    }

}
