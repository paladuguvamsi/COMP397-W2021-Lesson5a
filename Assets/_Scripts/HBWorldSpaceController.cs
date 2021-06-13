using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBWorldSpaceController : MonoBehaviour
{

    public Transform playerCamera;

    private void Start()
    {
        playerCamera = GameObject.Find("PlayerCamera").transform;
    }

    private void LateUpdate()
    {
        // billboard the healthbar
        transform.LookAt(transform.position + playerCamera.forward);
    }

}
