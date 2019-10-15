using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CinemaChineVirtualCamera))]
public class CinemachineController : MonoBehaviour
{
    public PlayerData PlayerData;
    private CinemaChineVirtualCamera virtualCamera;
    [SerializeField] private static object obj;

    void Awake()
    {
        virtualCamera = GetComponent<CinemaChineVirtualCamera>();
        PlayerData.instanceAction += InstanceHandler;
    }

    private void InstanceHandler(GameObject obj)
    {
        VirtualCamera.Follow = obj;
    }
}

public class VirtualCamera
{
    public static object Follow { get; set; }
}

public class CinemaChineVirtualCamera
{
    
}
