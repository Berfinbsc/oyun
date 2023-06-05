using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public  GameObject elma;

    public float horizontalInput;

    public float verticalInput;
    public float speedy = 5f;
    public float speedyRotate = 15f;

    public bool jumpKey;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(elma, transform.position, elma.transform.rotation);

        }





        verticalInput = Input.GetAxis("Vertical");

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speedy);
        transform.Rotate(Vector3.up,speedy * horizontalInput * Time.deltaTime* speedyRotate);
    }


   
    }

