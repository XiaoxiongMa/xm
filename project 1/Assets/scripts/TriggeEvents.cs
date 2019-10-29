using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]

public class TriggeEvents : MonoBehaviour
{
    public void Awake()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    public UnityEvent triggerEnterEvent, triggerExitEvent;
     private void OnTriggerEnter(Collider other)
        {
            triggerEnterEvent.Invoke();
        }

     private void OnTriggerExit(Collider other)
     {
         triggerExitEvent.Invoke();
     }
}