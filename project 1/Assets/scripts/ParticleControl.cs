using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
    public ParticleSystem particles;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        particles.Emit(count: 100);
    }
}
