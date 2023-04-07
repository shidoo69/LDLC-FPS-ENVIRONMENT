using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus1Manager : MonoBehaviour
{
    public GameObject plus1;

    public void Show()
    {
        plus1.SetActive(true);
        StartCoroutine(CoPlus1());
    }
    IEnumerator CoPlus1()
    {
        yield return new WaitForSeconds(2);
        plus1.SetActive(false);
    }
}
