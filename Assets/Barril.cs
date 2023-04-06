using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barril : MonoBehaviour
{
    Rigidbody rigidbody;
    private GameManager gameManager;
    public float speed = 0.2f;
    Vector3 direction = new Vector3(0f, -1f, 0f);
    private Vector3 positionInitiale;
    void Start()
    {
        gameManager = GameManager.Instance;
        rigidbody = GetComponent<Rigidbody>();

        positionInitiale = transform.position;
    }

    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("touché");
            gameObject.SetActive(false);
            gameManager.UpdateScore(1);
        }

    }
    void FixedUpdate()
    {
        //ON RECUPERE ET ON STOCKE LA POSITION ACTUELLE DE LA PLATEFORME
        Vector3 currentPosition = transform.position;



        //CALCUL DE LA NOUVELLE POSITION DE MA PLATEFORME 
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

        //ON APPLOQUE LA NOUVELLE POSITION
        rigidbody.MovePosition(newPosition);

        if (currentPosition.y < positionInitiale.y - 0.1f)
        {
            direction.y = 1f;
        }
        else if (currentPosition.y > positionInitiale.y)
        {
            direction.y = -1f;
        }
    }
}

