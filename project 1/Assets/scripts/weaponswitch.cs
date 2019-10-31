using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitch : MonoBehaviour
{
    
    public weapon states
    {
        Start,
        Playing,
        End
    }

    public states currentStates;
    public UnityEvent OnStartEvent, OnPlatingEvent, OnEndEvent;
    public WeaponData WeaponData;
    // Update is called once per frame
    void Update()
    {
        switch (currentStates)
        {
            case states.Start:
                break;
            case states.Playing:
                break;
            case states.End :
                OnEndEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
