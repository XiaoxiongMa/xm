using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class ConfiguringAIwithScriptableObjects : scriptableobject
{
    public float InitialValue

    [NonSerialized]
    public float RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    
    } 

    public void OnBeforeSerialize() { }
}
