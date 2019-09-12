using UnityEngine;
using UnityEngine.Events;

public class TriggeEvents : MonoBehaviour
{
    public UnityEvent triggerEvent;
     private void OnMouseDown()
        {
            triggerEvent.Invoke();
        }
}