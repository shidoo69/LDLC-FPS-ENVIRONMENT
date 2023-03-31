using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tunning : MonoBehaviour
{
    public Light light;
    Color lerpedColor;

    void Start()
    {
        // Permet de changer la couleurs 
        light= GetComponent<Light>();
        light.color = Color.blue;
        light.color = Color.red;
        light.color = Color.green;
    }

    private void Update()
    {
        // la commande lerp perme de choisir une valeur en 0 & 1 et me permet de faire des jeux de lumiere 
        lerpedColor = Color.Lerp(Color.blue, Color.red, Mathf.PingPong(Time.time, 2));
        light.color = lerpedColor;
    }
}

