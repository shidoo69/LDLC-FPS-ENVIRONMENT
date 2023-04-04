using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("J'ai cliqué sur le bouton");
            Instantiate(projectilePrefab, Camera.main.transform.position + Camera.main.transform.forward, Camera.main.transform.rotation);
        }
    }
}
