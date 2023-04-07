using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class grappin : MonoBehaviour
{
    Vector3 destination;
    Vector3 position2depart;
    public float vitesse; 
    float temps;
    float timer;
    // Start is called before the first frame update
    public LineRenderer laserLineRenderer;
    public float laserWidth = 0.1f;

    public float maxDistance;
    void ShootLaserFromTargetPosition(Vector3 targetPosition, Vector3 direction, float length)
    {
        Ray ray = new Ray(targetPosition, direction);
        RaycastHit raycastHit;
        Vector3 endPosition = targetPosition + (length * direction);

        if (Physics.Raycast(ray, out raycastHit, length))
        {
            endPosition = raycastHit.point;
        }

        laserLineRenderer.SetPosition(0, targetPosition);
        laserLineRenderer.SetPosition(1, endPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && destination == Vector3.zero ) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,maxDistance))
            {
                destination = hit.point;
                timer = 0;
                position2depart = transform.position;
                ShootLaserFromTargetPosition(Camera.main.transform.position+Camera.main.transform.right*-0.5f, (destination-Camera.main.transform.position).normalized, maxDistance);
                laserLineRenderer.enabled = true;
                float distance = Vector3.Distance(destination, position2depart);
                temps = distance/vitesse;

            }
       
        }

        if (destination != Vector3.zero)
        {
            timer = timer + Time.deltaTime;
            float ratio = timer / temps;
            transform.position = Vector3.Lerp(position2depart, destination, ratio);
           // Debug.Break();
            if (timer > temps)
            {
                destination = Vector3.zero;
                laserLineRenderer.enabled = false;

            }


        }


    }
}
