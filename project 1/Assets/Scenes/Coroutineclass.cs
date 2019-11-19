using System.Collections;
using UnityEngine;

public class Coroutineclass : MonoBehaviour
{
    public float seconds = 1f;
    public IntData index;
    public bool canRun = true;
    public WaitForSeconds wfsObj;
    private int count = 3;
    
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

        while (canRun)
        {
            wfsObj = new WaitForSeconds(1f);
            Debug.Log(count--);
            yield return wfsObj;
            index.value--;
            if (count == 1)
            {
                canRun = false;
            }
        }

        wfsObj = new WaitForSeconds(1f);
        Debug.Log(message: "Run!");
        yield return wfsObj;
        index.value--;



    }

}
