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
    int premierdialogue;
    void Start()
    {
        premierdialogue = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (premierdialogue == 0)
            {
                panel.SetActive(true);
                Nom.text = "Fred";
                Phrase.text = "Bonjour, je m'appel Fred. Dieu m'a dit que tu voulais partir de la ville. Tout d'abord apporte moi les 5 barils caché dans la ville";
                StartCoroutine(PlusdeTexte());
                premierdialogue++;
            }
            else
            {

                if(GameManager.Instance.barscore < 5)
                    {
                    if (GameManager.Instance.barscore == 4)
                    {
                        panel.SetActive(true);
                        Nom.text = "Fred";
                        Phrase.text = "Tu n'as pas encore récupéré tous les barils, viens me parler quand tu auras trouvé le dernier baril";
                        StartCoroutine(PlusdeTexte());
                    }
                    else
                    {
                        panel.SetActive(true);
                        Nom.text = "Fred";
                        Phrase.text = "Tu n'as pas encore récupéré tous les barils, viens me parler quand tu auras trouvé les " + (5 - GameManager.Instance.barscore) + " barils restants";
                        StartCoroutine(PlusdeTexte());
                    }

                    
                }
                else
                    {
                        panel.SetActive(true);
                    Nom.text = "Fred";
                    Phrase.text = "Merci pour les barils mais Lil Fred est parti quand j'avais le dos tourné. Rammène la moi s'il te plaît.";
                        StartCoroutine(PlusdeTexte());
                }
            }
        }
        IEnumerator PlusdeTexte()
        {
            yield return new WaitForSeconds(5);
            panel.SetActive(false);
        }
    }
}




