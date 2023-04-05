using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class grappin : MonoBehaviour
{
    Vector3 destination;
    Vector3 position2depart;
    public float temps;
    float timer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                destination = hit.point;
                timer = 0;
                position2depart = transform.position;
            }
       
        }

        if (destination != Vector3.zero)
        {
            timer = timer + Time.deltaTime;
            float ratio = timer / temps;
            transform.position = Vector3.Lerp(position2depart, destination, ratio);
            
            if (timer > temps)
            {
                destination = Vector3.zero;
            }
           

        }
        

    }
}
