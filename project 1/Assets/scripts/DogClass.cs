using UnityEngine;
using UnityEngine.Events;

public class DogClass : MonoBehaviour
{
    public UnityEvent doesStuff;
    
    private void OnMouseDown()
    {
        doesStuff.Invoke();
    }
}
