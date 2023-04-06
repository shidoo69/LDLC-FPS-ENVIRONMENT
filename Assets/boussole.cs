using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boussole : MonoBehaviour

{
    
    Vector3 currentEulerAngles;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("rotation");
    }

    // Update is called once per frame
    void Update()
    {
        currentEulerAngles.z = player.eulerAngles.y;
        //rota boussole 
        Debug.Log(transform.eulerAngles.z);
        //rota nous 
        Debug.Log(player.eulerAngles.y);
        transform.eulerAngles = currentEulerAngles;


    }

}

