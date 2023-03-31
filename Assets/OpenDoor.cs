using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    GameObject doorObject;


    private void OnTriggerStay(Collider other)

    {
        Debug.Log("Il y a collision avec " + other.gameObject.name);
        doorObject.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        doorObject.SetActive(true);
    }
}
    