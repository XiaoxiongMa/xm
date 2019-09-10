using UnityEngine;
using UnityEngine.Events;

public class TrggeEvents : MonoBehaviour
{
    public UnityEvent triggerEvent;
    private void OnTriggerEnter(Collider other)
    {
       triggerEvent.Invoke();
    }
}
