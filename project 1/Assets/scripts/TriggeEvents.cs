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

    public UnityEvent triggerEvent;
     private void OnTriggerEnter(Collider other)
        {
            triggerEvent.Invoke();
        }
}