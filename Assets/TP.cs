using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour

{
    Vector3 positionDepart;
    // Start is called before the first frame update
    void Start()
    {
        positionDepart = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -5F)
        {
            transform.position = positionDepart; 
        }
    }
}
