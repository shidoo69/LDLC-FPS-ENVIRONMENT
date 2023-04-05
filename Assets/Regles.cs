using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Regles : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Rules;
    void Start()
    {
        Rules.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.tabKey.isPressed)
        {
            Rules.gameObject.SetActive(true);
        }
        else
        {
            Rules.gameObject.SetActive(false);  
        }
        
    }
}
