using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemachinePixelPerfect : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private Cinemachine.CinemachineVirtualCamera vcamScript;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] vcam = GameObject.FindGameObjectsWithTag("EVENT_CAMERA");
        vcamScript = GetComponent<Cinemachine.CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        vcamScript.m_Lens.OrthographicSize = mainCamera.orthographicSize;
    }
}
