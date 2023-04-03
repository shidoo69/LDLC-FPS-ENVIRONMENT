using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class objet : MonoBehaviour
    
{
    Rigidbody rigidbody;
    public Camera camera;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
           
    }
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                transform.position = hit.point;
            }
        }
    }
}