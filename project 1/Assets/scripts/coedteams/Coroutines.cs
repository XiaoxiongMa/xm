using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public float seconds = 10f;
    public UnityEvent startEvent, repeatEvent, endEvent;
    private int counter = 10;
    public bool canRun;
    private WaitForSeconds wfsObj;
    
    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds);
    }

    public void CallCoroutine()
    {
        StartCoroutine(routine: RunCoroutine());
    }
    IEnumerator RunCoroutine()
    {
        startEvent.Invoke();
        while (counter > 0) 
        {
           repeatEvent.Invoke();
           yield return wfsObj;
           counter--;
        }

        while (canRun)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            counter--;
        }

        endEvent.Invoke();
    }
}
