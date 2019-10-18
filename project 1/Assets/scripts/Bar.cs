using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    [Header("Graphic")]
    public Image BarImg;
    public transform particlesTransform;

    [Header("Settings")]
    public float Speed;

    private bool isDone = false;
    private particleSystem[] pSysems;

    void Start()
    {
        BarImg.fillAmount = 0;
        pSysems = particlesTransform.GetComponentsInChildren<particlesTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isDone)
            return;

        BarImg.fillAmount += (Speed * Time,delataTime) / 100;

        if (BarImg.fillAmount >= 1.0f)
        {
            isDone = true;
            foreach (var particle in pSysems)
                particle.Play();
        }

    }
}
