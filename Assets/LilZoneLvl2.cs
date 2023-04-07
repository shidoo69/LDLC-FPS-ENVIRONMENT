using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class LilZoneLvl2 : MonoBehaviour
{
    public static LilZoneLvl2 Instance { get; private set; }
    public int lvl2finis;
    public GameObject panel;
    public TMP_Text Nom;
    public TMP_Text Phrase;
    public void Start()
    {
        lvl2finis = 0; 
    }
    public GameObject Lil;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if(GameManager.Instance.barscore > 5 && other.gameObject.name == "Lil Fred")
        {
            panel.SetActive(true);
            Nom.text = "Fred";
            Phrase.text = "Merci beaucoup ! Maintenant, tu peux attraper tout ce qu'il y a dans la carte.";
            StartCoroutine(PlusdeTexte());
            lvl2finis++;
        }
            
    }
    IEnumerator PlusdeTexte()
    {
        yield return new WaitForSeconds(5);
        panel.SetActive(false);
    }
}
