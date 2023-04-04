using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerStay(Collider other)
    {
        door.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        door.SetActive(true);
    }
}
