using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilElm : MonoBehaviour
{
    private double silE = 20;
    private double silB = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > sil)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < silB)
        {
            Destroy(gameObject);
        }
    }
}
