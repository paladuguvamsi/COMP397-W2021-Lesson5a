using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided");
            var controller = other.gameObject.GetComponent<CharacterController>();
            controller.enabled = false;
            other.gameObject.transform.position = spawnPoint.position;
            controller.enabled = true;

        }
    }
}
