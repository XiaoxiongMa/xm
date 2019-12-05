using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float delay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,delay);
    }

    public void DestroyOnImpact()
    {
        Destroy(gameObject);
    }
}
