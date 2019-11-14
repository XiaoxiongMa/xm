using System.Collections;
using UnityEngine;

public class Coroutineclass : MonoBehaviour
{
    public float seconds = 1f;
    public IntData index;
    public bool canRun = true;
    public WaitForSeconds wfsObj;
    
    public void Run()
    {
        wfsObj = new WaitForSeconds(seconds);
        StartCoroutine(routine:OnRun());
    }
     IEnumerator OnRun()
    {
        while (index.value > 0)
        {
            index.value--;
            Debug.Log(index.value);
            yield return wfsObj;
        }
    }
}
