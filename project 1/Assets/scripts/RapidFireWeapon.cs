using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFireWeapon : MonoBehaviour
{
    public float holdTime = 1f;
    public WaitForSeconds waitForSeconds;
    private bool canRun = true;
    public GameAction gameActionobj;
    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(holdTime);
    }

    private IEnumerator OnMouseDown()
    {
        canRun = true;
        while (canRun)
        {
            gameActionobj.Raise();
            yield return waitForSeconds;
        }
    }

    private void OnMouseUp()
    {
        canRun = false;
    }
}
