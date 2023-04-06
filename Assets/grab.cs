using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class grab : MonoBehaviour

{
    Rigidbody rigidbody;
    public Camera camera;

    void Start()
    {


    }
    void Update()
    {
        //Quand on fait clique gauche
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //Lancer un rayon dans la direction de la cam�ra
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            //Action du rayon
            if (Physics.Raycast(ray, out hit))
            {
                //On prend le rigidbody de l'�l�ment toucher par le rayon
                rigidbody = hit.transform.GetComponent<Rigidbody>();
                
                if (rigidbody == null)
                    return;

                //D�sactive la gravit�e
                rigidbody.useGravity = false;
                rigidbody.isKinematic = true;
                // Rapporcher le sac
                hit.transform.position = transform.position + (transform.forward * 2);
                hit.transform.parent = transform;


            }
        }
        if (Mouse.current.rightButton.wasReleasedThisFrame)
        {
            //D�sactive la gravit�e
            rigidbody.useGravity = true;
            rigidbody.isKinematic = false;
            // Rapporcher le sac
            rigidbody.transform.parent = null;



        }
    }
}