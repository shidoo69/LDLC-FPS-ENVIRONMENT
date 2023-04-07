using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class grab : MonoBehaviour

{
    Rigidbody _rigidbody;
    public Camera camera;
    public bool canGrabEverything;
    void Start()
    {


    }
    void Update()
    {
        //Quand on fait clique gauche
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //Lancer un rayon dans la direction de la caméra
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            //Action du rayon
            if (Physics.Raycast(ray, out hit))
            {
                //On prend le rigidbody de l'élément toucher par le rayon
                _rigidbody = hit.transform.GetComponent<Rigidbody>();
                
                if (_rigidbody == null)
                    return;

                if(_rigidbody.gameObject.name != "Lil Fred" && canGrabEverything == false)
                    return;

                //Désactive la gravitée
                _rigidbody.useGravity = false;
                _rigidbody.isKinematic = true;
                // Rapporcher le sac
                hit.transform.position = transform.position + (transform.forward * 2);
                hit.transform.parent = transform;


            }
        }
        if (_rigidbody != null && Mouse.current.rightButton.wasReleasedThisFrame)
        {
            //Désactive la gravitée
            _rigidbody.useGravity = true;
            _rigidbody.isKinematic = false;
            // Rapporcher le sac
            _rigidbody.transform.parent = null;



        }
    }
}