using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public GameObject[] ptsDizi;
public class Swap : MonoBehaviour
{
    private float spwnX = 5;
    private float spwnZ = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spwPos = new Vector3(Random.Ramge(-spwnX, spwnX),
                0, spwnZ);

            int ptsIndex = Random.Range(0, ptsIndex.Length);
            Instantiate(ptsDizi[ptsIndex], spwPos, ptsDizi[ptsIndex].transform.rotation);
        }
    }
}
