using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateform : MonoBehaviour
{
    Rigidbody rigidbody;
    
    //LA VITESSE DE LA PLATEFORME
    public float speed = 2f;
    //ON DONNE UNE DIRECTION DE DEPART A LA PLATEFORME
    Vector3 direction = new Vector3(-1f, 0f, 0f);
    private Vector3 positionInitiale;
    void Start()
    {
        //RECUPERE ET ON STOCKE UNE REFERENCE VERS LE RIGIDBODY
        rigidbody = GetComponent<Rigidbody>();

        positionInitiale = transform.position;
    }

    void FixedUpdate()
    {
        //ON RECUPERE ET ON STOCKE LA POSITION ACTUELLE DE LA PLATEFORME
        Vector3 currentPosition = transform.position;


        //CALCUL DE LA NOUVELLE POSITION DE MA PLATEFORME 
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

        //ON APPLOQUE LA NOUVELLE POSITION
        rigidbody.MovePosition(newPosition);

        if (currentPosition.x < positionInitiale.x - 10f)
        {
            direction.x = 1f;
        }
        else if (currentPosition.x > positionInitiale.x)
        {
            direction.x = -1f;
        }
    }
}
