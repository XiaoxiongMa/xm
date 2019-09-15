using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangecat : MonoBehaviour
{
	public UnityEven doesStuff;

    private void OnMouseDown()
    {
        doesStuff.Invoke();
    }
}
