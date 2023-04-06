using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class Interaction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public TMP_Text Nom;
    public TMP_Text Phrase;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if(GameManager.Instance.barscore < 5)
                {
                    panel.SetActive(true);
                    Nom.text = "Fred";
                    Phrase.text = "Tu n'as pas assez de barils pour me parler.";
                    StartCoroutine(PlusdeTexte());
                    
            }
            else
                {
                    panel.SetActive(true);
                Nom.text = "Fred";
                Phrase.text = "Bravo";
                    StartCoroutine(PlusdeTexte());
            }
        }
    }
    IEnumerator PlusdeTexte()
    {
        yield return new WaitForSeconds(3);
        panel.SetActive(false);
    }

}
