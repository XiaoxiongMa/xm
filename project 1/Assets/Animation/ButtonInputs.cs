using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonInputs : MonoBehaviour
{
    public UnityEvent inputEvent;
    public string inputWords;

    private void Update()
    {
        if (Input.GetButtonDown(inputWords))
        {
            inputEvent.Invoke();
        }
    }
}
