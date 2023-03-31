using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoovP : MonoBehaviour
{
    Rigidbody rigidbody;
    public float speed = 2f;
    Vector3 direction = new Vector3(-1f, 0f, 0f);
    private Vector3 positionInitiale;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        positionInitiale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
