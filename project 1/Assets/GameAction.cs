using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : MonoBehaviour
{
    public UnityAction action;

    public void Raise()
    {
        action?.Invoke();
    }
}
