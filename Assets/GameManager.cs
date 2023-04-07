using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

using TMPro;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public TMP_Text scoreText;
    public  GameObject panel;
    public TMP_Text Nom;
    public TMP_Text Phrase;


    public int barscore;
    void Start()
    {
        UpdateScore(0);
        barscore = 0;
        panel.SetActive(true);
        Nom.text = "Dieu";
        Phrase.text = "Bonjour, c'est Dieu qui te parle. Appuie sur la touche Tab si tu as besoin d'informations. Va parler à Fred, elle va te dire comment t'échapper de la ville.";
        StartCoroutine(TexteIntro());

    }
     void Update()
    {

    }
    public void UpdateScore(int scoreToAdd)
    {
        barscore += scoreToAdd;
        scoreText.text = "Score: " + barscore + " / 5" ;
        if (barscore == 5)
        {
            panel.SetActive(true);
            Nom.text = "Dieu";
            Phrase.text = "Bravo ! Va parler à Fred.";
            StartCoroutine(PlusdeTexte());

        }
        if (barscore == 1)
        {
            panel.SetActive(true);
            Nom.text = "Dieu";
            Phrase.text = "Continue comme ça, il ne t'en reste plus que 4.";
            StartCoroutine(PlusdeTexte());

        }



    }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    IEnumerator PlusdeTexte()
    {
        yield return new WaitForSeconds(4);
        panel.SetActive(false);
    }
    IEnumerator TexteIntro()
    {
        yield return new WaitForSeconds(6);
        panel.SetActive(false);
    }

}
