using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilFred : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.barscore == 5)
        {
            transform.position = new Vector3(39.35194f, 1.52f, -20.6328f);
            GameManager.Instance.barscore++;
        }
    }
}
