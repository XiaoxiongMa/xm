using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnumSwitch : MonoBehaviour
{
  
  public enum states
  {
      Start,
      Playing,
      End
  }

  public states currentStates;
  public UnityEvent OnStartEvent, OnPlatingEvent, OnEndEvent;
  
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
