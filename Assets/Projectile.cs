using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody rigidbody;
    
    //LA VITESSE DE LA PLATEFORME
    public float speed = 2f;
    //ON DONNE UNE DIRECTION DE DEPART A LA PLATEFORME
    private Vector3 direction;
    void Start()
    {
        //RECUPERE ET ON STOCKE UNE REFERENCE VERS LE RIGIDBODY
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //ON RECUPERE ET ON STOCKE LA POSITION ACTUELLE DE LA PLATEFORME
        Vector3 currentPosition = transform.position;
        direction = transform.forward;

        //CALCUL DE LA NOUVELLE POSITION DE MA PLATEFORME 
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

        //ON APPLOQUE LA NOUVELLE POSITION
        rigidbody.MovePosition(newPosition);
    }
}
